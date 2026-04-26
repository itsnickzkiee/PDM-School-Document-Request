using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Group5
{


    public partial class StudentForm2 : Form
    {
        private string studentNo;
        bool isUpdatingCombo = false;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loader;
        public StudentForm2(string studNo)
        {
            InitializeComponent();
            InitializeLoader();
            studentNo = studNo;

            cmb_StudentStatus.Items.AddRange(new string[]
             {
                "Alumnus",
                "Not Enrolled",
                "Enrolled"
             });


            cmb_Purpose.Items.AddRange(new string[]
            {
                "For Employment",
                "For Reference",
                "For Financial",
                "For Scholarship"
            });


            cmb_ReqFor.Items.AddRange(new string[]
            {
                "Transfer Credentials (HD, COG, TOR, GMC) - (Php. 200.00)",
                "Certification, Authentication and Verification (CAV) - (Php. 200.00)",
                "Scholastic Record - (Php. 50.00)",
                "To Cross-enroll Permit - (Php. 50.00)",
                "True Copy of Grades - (Php. 50.00)",
                "Certificate of Registration (COR) - (Php. 50.00)",
                "Grades Form - A.Y._____ Semester/s:_____ (Php. 50.00)"
            });
        }


        private void InitializeLoader()
        {
            loader = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            loader.Size = new Size(100, 100);
            loader.ProgressColor = Color.Yellow;
            loader.Location = new Point(
                (this.ClientSize.Width - loader.Width) / 2,
                (this.ClientSize.Height - loader.Height) / 2
            );
            loader.Visible = false;
            loader.BackColor = Color.Transparent;
            this.Controls.Add(loader);
            loader.BringToFront();
        }

        private void ShowLoader()
        {
            loader.Visible = true;
            loader.Start();
            loader.BringToFront();
            this.Refresh();
        }

        private void HideLoader()
        {
            loader.Stop();
            loader.Visible = false;
        }
        private void txt_AddressLAst_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_PAYSUBMIT_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txt_AddressLAst.Text))
            {
                MessageBox.Show("Please enter your Last School Address.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AddressLAst.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_HomeAdd.Text))
            {
                MessageBox.Show("Please enter your Home Address.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_HomeAdd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_SchoolLastAttend.Text))
            {
                MessageBox.Show("Please enter your Last School Name.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SchoolLastAttend.Focus();
                return;
            }

            if (cmb_Purpose.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Purpose.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_ReqFor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Request For.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string homeAdd = txt_HomeAdd.Text;
            string lastSchoolName = txt_SchoolLastAttend.Text;
            string lastSchoolAddress = txt_AddressLAst.Text;
            string studentStatus = cmb_StudentStatus.Text;
            string purpose = cmb_Purpose.Text;
            string requestFor = cmb_ReqFor.Text;
            string payment = lbl_Paymet.Text.Replace("Your Payment: ₱", "");
            DateTime pickupDate = dateTimePicker_Pick.Value;


            loader.Visible = true;
            loader.Start();
            loader.BringToFront();
            this.Refresh();

            string connStr = "server=127.0.0.1; user=root; database=sample; password=";

            try
            {
                await Task.Run(() =>
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();


                        string updateQuery = @"UPDATE students_tbl SET
                    present_address=@present_address,
                    last_school_name=@last_school_name,
                    last_school_address=@last_school_address,
                    student_status=@student_status,
                    purpose=@purpose,
                    request_for=@request_for,
                    payment=@payment,
                    payment_status=@payment_status,
                    date_submitted=NOW(),
                    pickup_date=@pickup_date
                    WHERE student_no=@student_no";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@present_address", homeAdd);
                            cmd.Parameters.AddWithValue("@last_school_name", lastSchoolName);
                            cmd.Parameters.AddWithValue("@last_school_address", lastSchoolAddress);
                            cmd.Parameters.AddWithValue("@student_status", studentStatus);
                            cmd.Parameters.AddWithValue("@purpose", purpose);
                            cmd.Parameters.AddWithValue("@request_for", requestFor);
                            cmd.Parameters.AddWithValue("@payment", payment);
                            cmd.Parameters.AddWithValue("@student_no", studentNo);
                            cmd.Parameters.AddWithValue("@payment_status", "Paying");
                            cmd.Parameters.AddWithValue("@pickup_date", pickupDate);

                            cmd.ExecuteNonQuery();
                        }

                        string checkPending = "SELECT COUNT(*) FROM pending_requests WHERE student_no=@student_no";
                        int count = 0;
                        using (MySqlCommand checkCmd = new MySqlCommand(checkPending, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@student_no", studentNo);
                            count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        }

                        if (count == 0)
                        {
                            string insertPending = @"INSERT INTO pending_requests 
                        (student_no, surname, first_name, middle_name, email, course,last_year_yearlevel, date_registered, request_for, payment, payment_status, pickup_date)
                        SELECT student_no, surname, first_name, middle_name, email, course, last_year_yearlevel, date_registered, request_for, payment, @payment_status, @pickup_date
                        FROM students_tbl WHERE student_no=@student_no";

                            using (MySqlCommand cmdPending = new MySqlCommand(insertPending, conn))
                            {
                                cmdPending.Parameters.AddWithValue("@student_no", studentNo);
                                cmdPending.Parameters.AddWithValue("@payment_status", "Pending");
                                cmdPending.Parameters.AddWithValue("@pickup_date", pickupDate);
                                cmdPending.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updatePending = @"UPDATE pending_requests SET
                        request_for=@request_for,
                        payment=@payment,
                        payment_status=@payment_status,
                        pickup_date=@pickup_date
                        WHERE student_no=@student_no";

                            using (MySqlCommand cmdPendingUpdate = new MySqlCommand(updatePending, conn))
                            {
                                cmdPendingUpdate.Parameters.AddWithValue("@request_for", requestFor);
                                cmdPendingUpdate.Parameters.AddWithValue("@payment", payment);
                                cmdPendingUpdate.Parameters.AddWithValue("@payment_status", "Pending");
                                cmdPendingUpdate.Parameters.AddWithValue("@pickup_date", pickupDate);
                                cmdPendingUpdate.Parameters.AddWithValue("@student_no", studentNo);
                                cmdPendingUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                });


                loader.Stop();
                loader.Visible = false;


                MessageBox.Show("Student record updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();

                guna2TrackBar1.Value = 4;

                ThankYouSubmission thankYouSubmission = new ThankYouSubmission();
                thankYouSubmission.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                loader.Stop();
                loader.Visible = false;
                MessageBox.Show("Error while updating student record: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            txt_HomeAdd.Text = "";
            txt_AddressLAst.Text = "";
            txt_SchoolLastAttend.Text = "";
            cmb_StudentStatus.SelectedIndex = -1;
            cmb_Purpose.SelectedIndex = -1;
            cmb_ReqFor.SelectedIndex = -1;
            lbl_Paymet.Text = "Your Payment: ₱0";
            dateTimePicker_Pick.Value = DateTime.Now;


            FormData.Clear();
        }


        private void cmb_ReqFor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isUpdatingCombo) return;
            if (cmb_ReqFor.SelectedItem == null) return;

            string selected = cmb_ReqFor.SelectedItem.ToString();

            if (selected.StartsWith("Grades Form"))
            {
                string ay = Interaction.InputBox("Enter Academic Year (e.g. 2024-2025):", "Academic Year");
                if (string.IsNullOrWhiteSpace(ay))
                {
                    MessageBox.Show("Action cancelled. Academic Year is required.", "Cancelled",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isUpdatingCombo = true;
                    cmb_ReqFor.SelectedIndex = -1;
                    isUpdatingCombo = false;
                    return;
                }

                string sem = Interaction.InputBox("Enter Semester (1st or 2nd):", "Semester");


                if (string.IsNullOrWhiteSpace(sem))
                {
                    MessageBox.Show("Action cancelled. Semester is required.", "Cancelled",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isUpdatingCombo = true;
                    cmb_ReqFor.SelectedIndex = -1;
                    isUpdatingCombo = false;
                    return;
                }


                sem = sem.Trim().ToLower();

                if (sem != "1st" && sem != "2nd")
                {
                    MessageBox.Show("Invalid input! Please enter only '1st' or '2nd' for Semester.", "Invalid Semester",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    isUpdatingCombo = true;
                    cmb_ReqFor.SelectedIndex = -1;
                    isUpdatingCombo = false;
                    return;
                }


                sem = char.ToUpper(sem[0]) + sem.Substring(1);

                isUpdatingCombo = true;
                if (cmb_ReqFor.SelectedIndex >= 0)
                {
                    cmb_ReqFor.Items[cmb_ReqFor.SelectedIndex] =
                        $"Grades Form - A.Y. {ay} Semester: {sem} (Php. 50.00)";
                }
                isUpdatingCombo = false;
            }

            if (cmb_ReqFor.SelectedItem != null)
            {
                string text = cmb_ReqFor.SelectedItem.ToString();
                decimal payment = 0;

                if (text.Contains("Php. 200.00")) payment = 200;
                else if (text.Contains("Php. 50.00")) payment = 50;

                lbl_Paymet.Text = $"Your Payment: ₱{payment}";
            }

        }


        private void Student2_Load(object sender, EventArgs e)
        {

            dateTimePicker_Pick.MinDate = DateTime.Now;
            dateTimePicker_Pick.MaxDate = DateTime.Now.AddDays(1);
            guna2TrackBar1.Value = 3;

            if (!string.IsNullOrEmpty(FormData.StudentNo))
            {
                LoadFormData();
            }

            dateTimePicker_Pick.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Pick.CustomFormat = "yyyy-MM-dd";

            cmb_StudentStatus.Items.Clear();
            cmb_StudentStatus.Items.Add("Alumnus");

            cmb_StudentStatus.Items.Add("Enrolled");


            cmb_Purpose.Items.Clear();
            cmb_Purpose.Items.Add("For Employment");
            cmb_Purpose.Items.Add("For Reference");
            cmb_Purpose.Items.Add("For Financial");
            cmb_Purpose.Items.Add("For Scholarship");


            cmb_ReqFor.Items.Clear();
            cmb_ReqFor.Items.Add("Transfer Credentials (HD, COG, TOR, GMC) - (Php. 200.00)");
            cmb_ReqFor.Items.Add("Certification, Authentication and Verification (CAV) - (Php. 200.00)");
            cmb_ReqFor.Items.Add("Scholastic Record - (Php. 50.00)");
            cmb_ReqFor.Items.Add("To Cross-enroll Permit - (Php. 50.00)");
            cmb_ReqFor.Items.Add("True Copy of Grades - (Php. 50.00)");
            cmb_ReqFor.Items.Add("Certificate of Registration (COR) - (Php. 50.00)");
            cmb_ReqFor.Items.Add("Grades Form - A.Y._____ Semester/s:_____ (Php. 50.00)");
            cmb_ReqFor.Items.Add("Certificate of Graduation - (Php. 50.00)");
            cmb_ReqFor.Items.Add("NO ID Issurance Certification - (Php. 50.00)");
            cmb_ReqFor.Items.Add("NSTP Serial No. Certification  - (Php. 50.00)");
            cmb_ReqFor.Items.Add("CTC of Document - (Php. 50.00)");
            cmb_ReqFor.Items.Add("Medium of Instruction (MOI) - (Php. 50.00)");



            if (!string.IsNullOrEmpty(FormData.StudentNo))
            {
                txt_HomeAdd.Text = FormData.HomeAddress;
                txt_AddressLAst.Text = FormData.LastSchoolAddress;
                txt_SchoolLastAttend.Text = FormData.LastSchoolName;
                cmb_StudentStatus.SelectedItem = FormData.StudentStatus;
                cmb_Purpose.SelectedItem = FormData.Purpose;
                cmb_ReqFor.SelectedItem = FormData.RequestFor;
                dateTimePicker_Pick.Value = FormData.PickupDate != DateTime.MinValue ? FormData.PickupDate : DateTime.Now;
            }
        }

        private void LoadFormData()
        {
            txt_HomeAdd.Text = FormData.HomeAddress;
            txt_AddressLAst.Text = FormData.LastSchoolAddress;
            txt_SchoolLastAttend.Text = FormData.LastSchoolName;
            cmb_StudentStatus.SelectedItem = FormData.StudentStatus;
            cmb_Purpose.SelectedItem = FormData.Purpose;
            cmb_ReqFor.SelectedItem = FormData.RequestFor;
            dateTimePicker_Pick.Value = FormData.PickupDate != DateTime.MinValue
                ? FormData.PickupDate
                : DateTime.Now;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ShowLoader();
            FormData.HomeAddress = txt_HomeAdd.Text;
            FormData.LastSchoolName = txt_SchoolLastAttend.Text;
            FormData.LastSchoolAddress = txt_AddressLAst.Text;
            FormData.StudentStatus = cmb_StudentStatus.Text;
            FormData.Purpose = cmb_Purpose.Text;
            FormData.RequestFor = cmb_ReqFor.Text;
            FormData.PickupDate = dateTimePicker_Pick.Value;

            Task.Delay(300).ContinueWith(_ =>
            {
                this.Invoke(() =>
                {
                    HideLoader();
                    StudentForm studentForm = new StudentForm();
                    studentForm.Show();
                    this.Hide();
                });
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
