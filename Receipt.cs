using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using PdfSharp.Drawing; 
using PdfSharp.Pdf;


namespace Group5
{
    public partial class Receipt : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=sample; password=";
        private Guna2WinProgressIndicator loader;
        public Receipt()
        {
            InitializeComponent();
            InitializeLoading();
            txt_studno.TextChanged += TxtStudentNo_TextChanged;
        }

        private void TxtStudentNo_TextChanged(object sender, EventArgs e)
        {
            string studentNo = txt_studno.Text.Trim();


            if (studentNo.Length >= 3)
                LoadStudentInfo(studentNo);
            else
                ClearLabels();
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }


        private void LoadStudentInfo(string studentNo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        CONCAT(first_name, ' ', middle_name, ' ', surname) AS full_name,
                                        course,
                                        last_year_yearlevel,
                                        purpose,
                                        request_for,
                                        payment AS amount_pay,
                                        date_registered AS date_issued,
                                        pickup_date
                                    FROM students_tbl
                                    WHERE student_no = @studNo";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studNo", studentNo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_Name.Text = reader["full_name"].ToString();
                            lbl_Course.Text = reader["course"].ToString();
                            lbl_YearLevel.Text = reader["last_year_yearlevel"].ToString();
                            lbl_Purpose.Text = reader["purpose"].ToString();
                            lbl_Reqfor.Text = reader["request_for"].ToString();
                            lbl_amount.Text = "₱ " + reader["amount_pay"].ToString();
                            lbl_issued.Text = Convert.ToDateTime(reader["date_issued"]).ToString("yyyy-MM-dd");
                            lbl_pickupdate.Text = reader["pickup_date"].ToString();
                        }
                        else
                        {
                            ClearLabels();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearLabels()
        {
            lbl_Name.Text = "";
            lbl_Course.Text = "";
            lbl_YearLevel.Text = "";
            lbl_Purpose.Text = "";
            lbl_Reqfor.Text = "";
            lbl_amount.Text = "";
            lbl_issued.Text = "";
            lbl_pickupdate.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_studno.Text))
            {
                LoadStudentInfo(txt_studno.Text.Trim());
            }
        }

        private async void btn_SendGmail_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_studno.Text) || string.IsNullOrWhiteSpace(lbl_Name.Text))
            {
                MessageBox.Show("Please enter a valid Student No. to load the receipt data first.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Receipt_" + txt_studno.Text.Trim() + ".pdf";
                saveFileDialog.Title = "Save Payment Receipt as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    loader.Visible = true;
                    loader.Start();
                    this.Cursor = Cursors.WaitCursor;


                    string finalFileName = saveFileDialog.FileName;

                    try
                    {

                        await Task.Run(() =>
                        {

                            PdfDocument document = new PdfDocument();
                            document.Info.Title = "Official Payment Receipt";


                            PdfPage page = document.AddPage();
                            XGraphics gfx = XGraphics.FromPdfPage(page);


                            XFont fontTitle = new XFont("Arial", 16, XFontStyle.Bold);
                            XFont fontHeader = new XFont("Arial", 10, XFontStyle.Bold);
                            XFont fontBody = new XFont("Arial", 10, XFontStyle.Regular);
                            XFont fontFooter = new XFont("Arial", 8, XFontStyle.Italic);

                            double lineY = 50;
                            double margin = 50;
                            double column1 = margin;
                            double column2 = margin + 120;
                            double lineHeight = 20;


                            gfx.DrawString("OFFICIAL PAYMENT RECEIPT", fontTitle, XBrushes.Black,
                                            new XRect(0, lineY, page.Width, fontTitle.Height), XStringFormats.TopCenter);
                            lineY += 40;

                            gfx.DrawString("Student No:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(txt_studno.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawLine(XPens.Gray, margin, lineY, page.Width - margin, lineY);
                            lineY += 10;

                            gfx.DrawString("Name:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_Name.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawString("Course:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_Course.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawString("Purpose:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_Purpose.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawString("Request for:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_Reqfor.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawString("Amount Pay:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_amount.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawString("Date Issued:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_issued.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            gfx.DrawString("Pickup Date:", fontHeader, XBrushes.Black, column1, lineY);
                            gfx.DrawString(lbl_pickupdate.Text, fontBody, XBrushes.Black, column2, lineY);
                            lineY += lineHeight;

                            lineY += 30;
                            gfx.DrawString("This is an official receipt of payment. Please keep this copy for your record.", fontFooter, XBrushes.Gray,
                                new XRect(margin, lineY, page.Width - 2 * margin, fontFooter.Height), XStringFormats.TopLeft);

                            document.Save(finalFileName);
                        });


                        loader.Stop();
                        loader.Visible = false;
                        this.Cursor = Cursors.Default;

                        MessageBox.Show("Receipt successfully saved as PDF!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        loader.Stop();
                        loader.Visible = false;
                        this.Cursor = Cursors.Default;

                        MessageBox.Show("Error generating PDF: " + ex.Message, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }







        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Purpose_Click(object sender, EventArgs e)
        {

        }

        private void lbl_amount_Click(object sender, EventArgs e)
        {

        }

        private void oVERBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Overboard overboard = new Overboard();
            overboard.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Course_Click(object sender, EventArgs e)
        {

        }
    }
}

