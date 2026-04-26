using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;


namespace Group5
{
    public partial class SendaNotice : Form
    {

        private string mysqlCon;
        private string attachedFilePath = null;
        private Guna2WinProgressIndicator loader;

        public SendaNotice(string connectionString)
        {
            InitializeComponent();
            InitializeLoading();
            mysqlCon = connectionString;




        }





        private void InitializeLoading()
        {
            loader = new Guna2WinProgressIndicator
            {
                Size = new Size(100, 100),
                Location = new Point((this.ClientSize.Width - 100) / 2,
                                     (this.ClientSize.Height - 100) / 2),
                Visible = false,
                ProgressColor = Color.Yellow,
                BackColor = Color.Transparent
            };

            this.Controls.Add(loader);
            loader.BringToFront();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtFullName.Clear();
            txt_Notice.Clear();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

            txtFullName.Text = SessionData.FullName;
            txtEmail.Text = SessionData.Email;


            string mysqlCon = "server=127.0.0.1; user=root; database=sample; password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();


                    MySqlCommand cmdName = new MySqlCommand(
                        "SELECT CONCAT(first_name, ' ', COALESCE(middle_name, ''), ' ', surname) AS full_name_combined FROM students_tbl", conn);
                    MySqlDataReader readerName = cmdName.ExecuteReader();

                    AutoCompleteStringCollection nameCollection = new AutoCompleteStringCollection();
                    while (readerName.Read())
                    {

                        nameCollection.Add(readerName.GetString("full_name_combined"));
                    }
                    readerName.Close();

                    txtFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtFullName.AutoCompleteCustomSource = nameCollection;


                    MySqlCommand cmdEmail = new MySqlCommand("SELECT email FROM students_tbl", conn);
                    MySqlDataReader readerEmail = cmdEmail.ExecuteReader();

                    AutoCompleteStringCollection emailCollection = new AutoCompleteStringCollection();
                    while (readerEmail.Read())
                    {
                        emailCollection.Add(readerEmail.GetString("email"));
                    }
                    readerEmail.Close();

                    txtEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtEmail.AutoCompleteCustomSource = emailCollection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading autocomplete data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Submit_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
         string.IsNullOrWhiteSpace(txtEmail.Text) ||
         string.IsNullOrWhiteSpace(txt_Notice.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            loader.Visible = true;
            loader.Start();
            this.Cursor = Cursors.WaitCursor;

            string studentEmail = txtEmail.Text.Trim();
            string studentName = txtFullName.Text.Trim();
            string noticeBody = txt_Notice.Text.Trim();

            string attached = attachedFilePath; 

            try
            {
                await Task.Run(() =>
                {
                    string senderEmail = "dutsrominick@gmail.com";
                    string senderPassword = "jczf izep ayqp duyb"; 

                    string subject = "Notice from PDM Registrar";
                    string body = $"Dear {studentName},\n\n{noticeBody}\n\n- PDM Registrar";

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress(senderEmail, "PDM Registrar");
                        mail.To.Add(studentEmail);
                        mail.Subject = subject;
                        mail.Body = body;

                        if (!string.IsNullOrEmpty(attached) && File.Exists(attached))
                        {
                            mail.Attachments.Add(new Attachment(attached));
                        }

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.EnableSsl = true;
                            smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                            smtp.Send(mail);
                        }
                    }
                });

                MessageBox.Show("Notice sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtEmail.Clear();
                txtFullName.Clear();
                txt_Notice.Clear();
                lblAttachmentStatus.Text = "No file attached.";
                lblAttachmentStatus.ForeColor = Color.Black;
                attachedFilePath = null;
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("Email failed. Check your App Password or internet.\n\nDetails: " + smtpEx.Message,
                    "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loader.Stop();
                loader.Visible = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void lbl_Informa_Click(object sender, EventArgs e)
        {

        }

        private void txt_Notice_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_Back_Click(object sender, EventArgs e)
        {
            loader.Visible = true;
            loader.Start();

            await Task.Run(() => System.Threading.Thread.Sleep(2000));

            loader.Stop();
            loader.Visible = false;



        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Logout?", "Log out Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                AdminLogin form7 = new AdminLogin();
                form7.Show();
            }
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingStatus form5 = new PendingStatus();
            form5.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Title = "Select File to Attach";


                openFileDialog.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    attachedFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(attachedFilePath);


                    lblAttachmentStatus.Text = "Attached: " + fileName;
                    lblAttachmentStatus.ForeColor = Color.Green;




                    MessageBox.Show("Attached File: " + fileName,
                                    "Attachment Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {

                    attachedFilePath = null;
                    lblAttachmentStatus.Text = "No file attached.";
                    lblAttachmentStatus.ForeColor = Color.Black;
                }
            }
        }

        private void rECEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
            this.Hide();
        }

        private void oVERVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Overboard overboard = new Overboard();
            overboard.Show();
            this.Hide();
        }
    }
}


