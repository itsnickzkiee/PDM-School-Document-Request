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
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Group5
{
    public partial class PendingStatus : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=sample;  password=";
        private Guna2WinProgressIndicator loader;
        public PendingStatus()
        {
            InitializeComponent();
            InitializeLoading();

        }
        private bool showingHidden = false;

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadPendingRequests();
            PopulateFilters();
            PopulateYearFilter();


            dataGridPending.ReadOnly = true;

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
        private void PopulateFilters()
        {
            cmbCourseFilter.Items.Clear();


            cmbCourseFilter.Items.Add("All Courses");


            string[] courses = { "BSIT", "BSCS", "BSOA", "BSHM", "BSTM", "BCED", "BTLED" };

            foreach (string course in courses)
            {
                cmbCourseFilter.Items.Add(course);
            }


            cmbCourseFilter.SelectedIndex = 0;
        }

        private void UpdateNoRecordsLabel()
        {
            DataTable dt = dataGridPending.DataSource as DataTable;
            if (dt != null)
            {
                if (dt.DefaultView.Count == 0)
                {
                    lblNoRecords.Text = "No records found";
                    lblNoRecords.Visible = true;
                }
                else
                {
                    lblNoRecords.Visible = false;
                }
            }
        }
        private void PopulateYearFilter()
        {
            cmbYearFilter.Items.Clear();


            cmbYearFilter.Items.Add("All Years");


            for (int year = 2014; year <= 2025; year++)
            {
                cmbYearFilter.Items.Add(year.ToString());
            }


            cmbYearFilter.SelectedIndex = 0;
        }


        private void LoadPendingRequests()
        {



            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();

                    string query = @"SELECT student_no AS 'Student No',
                                surname AS 'Surname',
                                first_name AS 'First Name',
                                middle_name AS 'Middle Name',
                                email AS 'Email',
                                course AS 'Course', last_year_yearlevel AS 'YearLevel',
                                date_registered AS 'Date Registered',
                                request_for AS 'Request For',
                                payment AS 'Payment',
                                payment_status AS 'Payment Status',
                                pickup_date AS 'Pickup Date'
                         FROM pending_requests";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridPending.DataSource = dt;

                    dataGridPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridPending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridPending.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student requests: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void dataGridPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void dataGridReceived_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void dataGridReceived_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void btn_EDIT_Click(object sender, EventArgs e)
        {


            if (dataGridPending.CurrentCell == null)
            {
                MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = dataGridPending.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridPending.Rows[rowIndex];


                dataGridPending.ReadOnly = false;


                foreach (DataGridViewColumn col in dataGridPending.Columns)
                    col.ReadOnly = true;


                selectedRow.Cells["Surname"].ReadOnly = false;
                selectedRow.Cells["First Name"].ReadOnly = false;
                selectedRow.Cells["Middle Name"].ReadOnly = false;
                selectedRow.Cells["Email"].ReadOnly = false;
                selectedRow.Cells["Course"].ReadOnly = false;
                selectedRow.Cells["YearLevel"].ReadOnly = false;
                selectedRow.Cells["Request For"].ReadOnly = false;
                selectedRow.Cells["Payment"].ReadOnly = false;
                selectedRow.Cells["Payment Status"].ReadOnly = false;
                selectedRow.Cells["Pickup Date"].ReadOnly = false;


                foreach (DataGridViewRow r in dataGridPending.Rows)
                    r.DefaultCellStyle.BackColor = Color.White;

                selectedRow.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

                MessageBox.Show("Edit mode enabled for the selected record. Click 'Update' to save changes.",
                    "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enabling edit mode: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_SendaNotice_Click(object sender, EventArgs e)
        {




            SendaNotice sendNoticeForm = new SendaNotice(mysqlCon);
            sendNoticeForm.ShowDialog();



        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?", "Confirm Exit.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

















        private void cmvYearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = dataGridPending.DataSource as DataTable;
            if (dt != null)
            {
                string selectedYear = cmbYearFilter.SelectedItem.ToString();

                if (selectedYear == "All Years")
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter = $"[Student No] LIKE '%-{selectedYear}-%'";
                }

                dataGridPending.Refresh();
                UpdateNoRecordsLabel();
            }
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sENDANOTICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            string connStr = "server=127.0.0.1; user=root; database=sample; password=";
            SendaNotice form6 = new SendaNotice(connStr);
            form6.Show();
        }

        private void aNALYTICSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analytics form9 = new Analytics();
            form9.Show();
        }

        private void oVERVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overboard form8 = new Overboard();
            form8.Show();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void cmbCourseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = dataGridPending.DataSource as DataTable;
            if (dt != null)
            {
                string selectedCourse = cmbCourseFilter.SelectedItem.ToString();

                if (selectedCourse == "All Courses")
                    dt.DefaultView.RowFilter = "";
                else
                    dt.DefaultView.RowFilter = $"Course = '{selectedCourse}'";

                dataGridPending.Refresh();
                UpdateNoRecordsLabel();
            }
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = dataGridPending.DataSource as DataTable;
            if (dt != null)
            {
                string searchText = txt_SearchName.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter =
                            $"[First Name] LIKE '%{searchText}%' OR " +
                            $"[Surname] LIKE '%{searchText}%' OR " +
                            $"[Middle Name] LIKE '%{searchText}%'";
                }

                dataGridPending.Refresh();
                UpdateNoRecordsLabel(); 
            }
        }

        private void dataGridPending_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridPending.CurrentCell != null;
            btn_Archive.Enabled = hasSelection;
            btn_EDIT.Enabled = hasSelection;
            btn_Update.Enabled = hasSelection;
            btn_Remove.Enabled = hasSelection;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridPending.CurrentCell == null)
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = dataGridPending.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridPending.Rows[rowIndex];
                string studentNo = row.Cells["Student No"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to permanently delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM pending_requests WHERE student_no = @studno";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@studno", studentNo);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                                MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No record found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    LoadPendingRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridPending.CurrentCell == null)
            {
                MessageBox.Show("Please select a record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DataGridViewRow row = dataGridPending.Rows[dataGridPending.CurrentCell.RowIndex];

            string studentNo = row.Cells["Student No"].Value.ToString();
            string surname = row.Cells["Surname"].Value.ToString();
            string firstName = row.Cells["First Name"].Value.ToString();
            string middleName = row.Cells["Middle Name"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string course = row.Cells["Course"].Value.ToString();
            string lastyearlevel = row.Cells["YearLevel"].Value.ToString();
            string requestFor = row.Cells["Request For"].Value.ToString();
            string payment = row.Cells["Payment"].Value.ToString();
            string paymentStatus = row.Cells["Payment Status"].Value.ToString();
            object dateRegistered = row.Cells["Date Registered"].Value ?? DBNull.Value;
            object pickupDate = row.Cells["Pickup Date"].Value ?? DBNull.Value;

     
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("First Name and Surname cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            loader.Visible = true;
            loader.Start();
            this.Cursor = Cursors.WaitCursor;

            try
            {
               
                await Task.Run(() =>
                {
        
                    using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                    {
                        conn.Open();

                        string query = @"UPDATE pending_requests SET 
                                    surname=@surname,
                                    first_name=@first_name,
                                    middle_name=@middle_name,
                                    email=@email,
                                    course=@course,
                                    last_year_yearlevel = @last_year_yearlevel,
                                    date_registered=@date_registered,
                                    request_for=@request_for,
                                    payment=@payment,
                                    payment_status=@payment_status,
                                    pickup_date=@pickup_date
                                WHERE student_no=@student_no";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@student_no", studentNo);
                            cmd.Parameters.AddWithValue("@surname", surname);
                            cmd.Parameters.AddWithValue("@first_name", firstName);
                            cmd.Parameters.AddWithValue("@middle_name", middleName);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@course", course);
                            cmd.Parameters.AddWithValue("@last_year_yearlevel", lastyearlevel);
                            cmd.Parameters.AddWithValue("@date_registered", dateRegistered);
                            cmd.Parameters.AddWithValue("@request_for", requestFor);
                            cmd.Parameters.AddWithValue("@payment", payment);
                            cmd.Parameters.AddWithValue("@payment_status", paymentStatus);
                            cmd.Parameters.AddWithValue("@pickup_date", pickupDate);

                            cmd.ExecuteNonQuery(); 
                        }
                    }
                });

             
                loader.Stop();
                loader.Visible = false;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

       
                dataGridPending.ReadOnly = true;
                LoadPendingRequests();
            }
            catch (Exception ex)
            {
               
                loader.Stop();
                loader.Visible = false;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Error updating record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Archive_Click(object sender, EventArgs e)
        {
            if (dataGridPending.CurrentCell == null)
            {
                MessageBox.Show("Please select a record to archive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dataGridPending.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridPending.Rows[rowIndex];
            string studentNo = row.Cells["Student No"].Value.ToString();


            DialogResult result = MessageBox.Show(
                "Are you sure you want to archive this record?",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
     
                loader.Visible = true;
                loader.Start();
                this.Cursor = Cursors.WaitCursor;

                try
                {
                   
                    await Task.Run(() =>
                    {
                      
                        using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                        {
                            conn.Open();

                        
                            string insertQuery = @"INSERT INTO archived_pending_requests 
                        (student_no, surname, first_name, middle_name, email, course,last_year_yearlevel, date_registered, request_for, payment, payment_status, pickup_date)
                        SELECT student_no, surname, first_name, middle_name, email, course,last_year_yearlevel, date_registered, request_for, payment, payment_status, pickup_date
                        FROM pending_requests
                        WHERE student_no = @studno";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@studno", studentNo);
                                insertCmd.ExecuteNonQuery(); 
                            }

                           
                            string deleteQuery = "DELETE FROM pending_requests WHERE student_no = @studno";
                            using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@studno", studentNo);
                                deleteCmd.ExecuteNonQuery();
                            }
                        }
                    });

         
                    loader.Stop();
                    loader.Visible = false;
                    this.Cursor = Cursors.Default;

                    MessageBox.Show("Record successfully archived!", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                    LoadPendingRequests();
                }
                catch (Exception ex)
                {
              
                    loader.Stop();
                    loader.Visible = false;
                    this.Cursor = Cursors.Default;

                    MessageBox.Show("Error archiving record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            StudentArchive studentArchive = new StudentArchive();
            studentArchive.Show();
            this.Hide();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rCEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
            this.Hide();
        }
    }

}


        