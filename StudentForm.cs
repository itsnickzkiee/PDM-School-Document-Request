using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace Group5
{
    public partial class StudentForm : Form


    {


        private Guna.UI2.WinForms.Guna2WinProgressIndicator loader;



        public StudentForm()
        {

            InitializeComponent();

            txt_LastSemYR.KeyPress += txt_LastSemYR_KeyPress;
            txt_LastSemYR.TextChanged += txt_LastSemYR_TextChanged;
            txt_ContactNo.KeyPress += txt_ContactNo_KeyPress;
            txt_ContactNo.TextChanged += txt_ContactNo_TextChanged;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {




            guna2TrackBar1.Value = 2;
            InitializeLoader();

            dateTimePicker_Today.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Today.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2_BirthDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker2_BirthDate.CustomFormat = "yyyy-MM-dd";
            dateTimePicker_Today.Value = DateTime.Now;
            dateTimePicker_Today.Enabled = false;

            txt_EMAIL.TextChanged += Txt_EMAIL_TextChanged;

            if (FormData.ClearFieldsFlag)
            {
                ClearFormFields();
                FormData.ClearFieldsFlag = false;
            }
            else if (!string.IsNullOrEmpty(FormData.StudentNo))
            {
                LoadFormData();
            }
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



        private void ClearFormFields()
        {
            txt_StudNo.Text = "";
            txt_FirstName.Text = "";
            txt_MiddleName.Text = "";
            txt_Surname.Text = "";
            txt_EMAIL.Text = "";
            txt_ContactNo.Text = "";
            cmb_Courses.SelectedIndex = -1;
            txt_BirthPlace.Text = "";
            txt_LastSemYR.Text = "";
            dateTimePicker2_BirthDate.Value = DateTime.Now;
        }

        private void LoadFormData()
        {
            txt_StudNo.Text = FormData.StudentNo;
            txt_FirstName.Text = FormData.FirstName;
            txt_MiddleName.Text = FormData.MiddleName;
            txt_Surname.Text = FormData.Surname;
            txt_EMAIL.Text = FormData.Email;
            txt_ContactNo.Text = FormData.ContactNo;
            cmb_Courses.SelectedItem = FormData.Course;
            txt_BirthPlace.Text = FormData.BirthPlace;
            txt_LastSemYR.Text = FormData.LastSemYear;
            dateTimePicker2_BirthDate.Value = FormData.BirthDate;
        }


        private void InitializeLoader()
        {
            loader = new Guna2WinProgressIndicator();
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



        private void txt_LastSemYR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }


        private void txt_LastSemYR_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 6;
            if (txt_LastSemYR.Text.Length > maxLength)
            {
                txt_LastSemYR.Text = txt_LastSemYR.Text.Substring(0, maxLength);
                txt_LastSemYR.SelectionStart = txt_LastSemYR.Text.Length;
            }


            ValidateLastSem();
        }

        private void ValidateLastSem()
        {
            string text = txt_LastSemYR.Text.Trim();


            string pattern = @"^\d{4}-[1-2]$";

            if (System.Text.RegularExpressions.Regex.IsMatch(text, pattern))
            {
                lbl_LastSemWarning.Visible = false;
            }
            else
            {
                lbl_LastSemWarning.Text = "Invalid format! Use YYYY-1 or YYYY-2";
                lbl_LastSemWarning.Visible = true;
            }
        }

        private void ValidateContactNo()
        {
            string phone = txt_ContactNo.Text.Trim();

            if (phone.Length == 11)
            {
                lbl_ContactWarning.Visible = false;
            }
            else
            {
                lbl_ContactWarning.Text = "Phone number must be 11 digits";
                lbl_ContactWarning.Visible = true;
            }


        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txt_ContactNo_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 11;
            if (txt_ContactNo.Text.Length > maxLength)
            {
                txt_ContactNo.Text = txt_ContactNo.Text.Substring(0, maxLength);
                txt_ContactNo.SelectionStart = txt_ContactNo.Text.Length;
            }


            ValidateContactNo();
        }

        private void Txt_EMAIL_TextChanged(object sender, EventArgs e)
        {
            string email = txt_EMAIL.Text.Trim();

            bool isValidEmail = email.Contains("@") && email.Contains(".");


            if (string.IsNullOrEmpty(email))
            {
                txt_EMAIL.ForeColor = Color.Black;
            }
            else if (isValidEmail)
            {
                txt_EMAIL.ForeColor = Color.Black;
            }
            else
            {
                txt_EMAIL.ForeColor = Color.Black;
            }
        }

        private async void BTN_NEXT_Click(object sender, EventArgs e)
        {

            loader.Visible = true;
            loader.Start();


            FormData.StudentNo = txt_StudNo.Text.Trim();
            FormData.FirstName = txt_FirstName.Text.Trim();
            FormData.MiddleName = txt_MiddleName.Text.Trim();
            FormData.Surname = txt_Surname.Text.Trim();
            FormData.Email = txt_EMAIL.Text.Trim().ToLower();
            FormData.ContactNo = txt_ContactNo.Text.Trim();
            FormData.Course = cmb_Courses.SelectedItem?.ToString();
            FormData.BirthPlace = txt_BirthPlace.Text.Trim();
            FormData.LastSemYear = txt_LastSemYR.Text.Trim();
            FormData.BirthDate = dateTimePicker2_BirthDate.Value;
            DateTime today = dateTimePicker_Today.Value;

        
            if (string.IsNullOrWhiteSpace(FormData.StudentNo) ||
                string.IsNullOrWhiteSpace(FormData.FirstName) ||
                string.IsNullOrWhiteSpace(FormData.Surname) ||
                string.IsNullOrWhiteSpace(FormData.Email) ||
                string.IsNullOrWhiteSpace(FormData.ContactNo) ||
                string.IsNullOrWhiteSpace(FormData.Course) ||
                string.IsNullOrWhiteSpace(FormData.BirthPlace) ||
                string.IsNullOrWhiteSpace(FormData.LastSemYear) ||
                FormData.BirthDate.Date == new DateTime(2025, 10, 29).Date)
            {
                MessageBox.Show("Please fill up the form completely.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loader.Stop();
                loader.Visible = false;
                return;
            }

            if (lbl_StudNoWarning.Visible || lbl_EmailWarning.Visible)
            {
                MessageBox.Show("Please fix the highlighted errors before continuing.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loader.Stop();
                loader.Visible = false;
                return;
            }

            if (FormData.ContactNo.Length != 11)
            {
                MessageBox.Show("Contact Number must be 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ContactNo.Focus();
                loader.Stop();
                loader.Visible = false;
                return;
            }

            string connStr = "server=127.0.0.1; user=root; database=sample; password=";

            try
            {
                await Task.Run(() =>
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();


                        string checkQuery = "SELECT COUNT(*) FROM students_tbl WHERE student_no=@student_no";
                        int count;
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@student_no", FormData.StudentNo);
                            count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        }

                        if (count == 0)
                        {
                            string insertQuery = @"INSERT INTO students_tbl 
                    (student_no, surname, first_name, middle_name, email, contact_no, course, date_registered, birth_date, birth_place, last_year_yearlevel)
                    VALUES (@student_no, @surname, @first_name, @middle_name, @email, @contact_no, @course, @date_registered, @birth_date, @birth_place, @last_year_yearlevel)";

                            using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@student_no", FormData.StudentNo);
                                cmd.Parameters.AddWithValue("@surname", FormData.Surname);
                                cmd.Parameters.AddWithValue("@first_name", FormData.FirstName);
                                cmd.Parameters.AddWithValue("@middle_name", FormData.MiddleName);
                                cmd.Parameters.AddWithValue("@email", FormData.Email);
                                cmd.Parameters.AddWithValue("@contact_no", FormData.ContactNo);
                                cmd.Parameters.AddWithValue("@course", FormData.Course);
                                cmd.Parameters.AddWithValue("@last_year_yearlevel", FormData.LastSemYear);
                                cmd.Parameters.AddWithValue("@date_registered", today);
                                cmd.Parameters.AddWithValue("@birth_date", FormData.BirthDate);
                                cmd.Parameters.AddWithValue("@birth_place", FormData.BirthPlace);
                                
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateQuery = @"UPDATE students_tbl SET
                        surname=@surname,
                        first_name=@first_name,
                        middle_name=@middle_name,
                        email=@email,
                        contact_no=@contact_no,
                        course=@course,
                        birth_date=@birth_date,
                        birth_place=@birth_place,
                        last_year_yearlevel=@last_year_yearlevel
                        WHERE student_no=@student_no";

                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@surname", FormData.Surname);
                                cmd.Parameters.AddWithValue("@first_name", FormData.FirstName);
                                cmd.Parameters.AddWithValue("@middle_name", FormData.MiddleName);
                                cmd.Parameters.AddWithValue("@email", FormData.Email);
                                cmd.Parameters.AddWithValue("@contact_no", FormData.ContactNo);
                                cmd.Parameters.AddWithValue("@course", FormData.Course);
                                cmd.Parameters.AddWithValue("@last_year_yearlevel", FormData.LastSemYear);
                                cmd.Parameters.AddWithValue("@birth_date", FormData.BirthDate);
                                cmd.Parameters.AddWithValue("@birth_place", FormData.BirthPlace);
                                cmd.Parameters.AddWithValue("@student_no", FormData.StudentNo);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                });

                loader.Stop();
                loader.Visible = false;


                StudentForm2 s2 = new StudentForm2(FormData.StudentNo);
                s2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                loader.Stop();
                loader.Visible = false;
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_MiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(
                "Do you want to go back to Add Request? Your current entries will be saved.",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                ShowLoader();

                FormData.StudentNo = txt_StudNo.Text.Trim();
                FormData.FirstName = txt_FirstName.Text.Trim();
                FormData.MiddleName = txt_MiddleName.Text.Trim();
                FormData.Surname = txt_Surname.Text.Trim();
                FormData.Email = txt_EMAIL.Text.Trim().ToLower();
                FormData.ContactNo = txt_ContactNo.Text.Trim();
                FormData.Course = cmb_Courses.SelectedItem?.ToString();
                FormData.BirthPlace = txt_BirthPlace.Text.Trim();
                FormData.LastSemYear = txt_LastSemYR.Text.Trim();
                FormData.BirthDate = dateTimePicker2_BirthDate.Value;

                FormData.ClearFieldsFlag = true;


                Task.Delay(300).ContinueWith(_ =>
                {
                    this.Invoke(() =>
                    {
                        HideLoader();

                        AddRequest addRequest = new AddRequest();
                        addRequest.Show();
                        this.Hide();
                    });
                });
            }
        }

        private void dateTimePicker_Today_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_StudNo_TextChanged(object sender, EventArgs e)
        {
            if (!txt_StudNo.Text.StartsWith("PDM-"))
            {
                txt_StudNo.Text = "PDM-";
                txt_StudNo.SelectionStart = txt_StudNo.Text.Length;
            }

            string pattern = @"^PDM-\d{4}-\d{6}$";
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_StudNo.Text, pattern))
            {
                lbl_StudNoWarning.Visible = false;
            }
            else
            {
                lbl_StudNoWarning.Text = "Format must be PDM-0000-000000";
                lbl_StudNoWarning.Visible = true;
            }
        }

        private void lbl_StudNoWarning_Click(object sender, EventArgs e)
        {

        }

        private void txt_EMAIL_TextChanged_1(object sender, EventArgs e)
        {
            string email = txt_EMAIL.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                lbl_EmailWarning.Visible = false;
                return;
            }


            if (email.Contains("@") && email.Contains("."))
            {
                lbl_EmailWarning.Visible = false;
            }
            else
            {
                lbl_EmailWarning.Text = "Invalid email format (must contain @ and .)";
                lbl_EmailWarning.Visible = true;
            }
        }

        private void txt_ContactNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ContactWarning_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
