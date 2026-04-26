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

namespace Group5
{
    public partial class StudentArchive : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=sample; password=";
        public StudentArchive()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingStatus form5 = new PendingStatus();
            form5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentArchive_Load(object sender, EventArgs e)
        {
            LoadArchivedRequests();
            PopulateFilters();
            PopulateYearFilter();

            dataGridView_Archive.ReadOnly = true;
            dataGridView_Archive.AllowUserToAddRows = false;
            dataGridView_Archive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Archive.MultiSelect = false;

            if (cmb_ArchCourse.Items.Count > 0)
                cmb_ArchCourse.SelectedIndex = 0;

            if (cmb_ArchYear.Items.Count > 0)
                cmb_ArchYear.SelectedIndex = 0;
        }
        private void UpdateNoRecordsLabel()
        {
            DataTable dt = dataGridView_Archive.DataSource as DataTable;
            if (dt != null)
            {
                if (dt.DefaultView.Count == 0)
                {
                    lblNoRecords2.Text = "No records found";
                    lblNoRecords2.Visible = true;
                }
                else
                {
                    lblNoRecords2.Visible = false;
                }
            }
        }
        private void LoadArchivedRequests()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();

                    string query = @"SELECT 
            student_no AS 'Student No',
           surname AS 'Surname',
          first_name AS 'First Name',
              middle_name AS 'Middle Name',
            email AS 'Email',
             course AS 'Course', last_year_yearlevel AS 'YearLevel',
            date_registered AS 'Date Registered',
           request_for AS 'Request For',
             payment AS 'Payment (₱)',
             payment_status AS 'Payment Status',
           pickup_date AS 'Pickup Date'
          FROM archived_pending_requests
           ORDER BY date_registered DESC;";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView_Archive.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading archived records: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFilters()
        {
            cmb_ArchCourse.Items.Clear();
            cmb_ArchCourse.Items.Add("All Courses");

            string[] courses = { "BSIT", "BSCS", "BSOA", "BSHM", "BSTM", "BCED", "BTLED" };

            foreach (string course in courses)
                cmb_ArchCourse.Items.Add(course);

            cmb_ArchCourse.SelectedIndex = 0;
        }

        private void PopulateYearFilter()
        {
            cmb_ArchYear.Items.Clear();
            cmb_ArchYear.Items.Add("All Years");

            for (int year = 2014; year <= 2025; year++)
                cmb_ArchYear.Items.Add(year.ToString());

            cmb_ArchYear.SelectedIndex = 0;
        }


        private void cmb_ArchCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ArchCourse.SelectedItem == null)
                return;

            string selectedCourse = cmb_ArchCourse.SelectedItem.ToString();

            DataTable dt = dataGridView_Archive.DataSource as DataTable;
            if (dt == null) return;

            if (selectedCourse == "All Courses")
                dt.DefaultView.RowFilter = "";
            else
                dt.DefaultView.RowFilter = $"Course = '{selectedCourse}'";

            dataGridView_Archive.Refresh();
            UpdateNoRecordsLabel();

        }

        private void cmbYearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dataGridView_Archive.DataSource as DataTable;
            if (dt != null)
            {
                string searchText = txt_search.Text.Trim();

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

                dataGridView_Archive.Refresh();
                UpdateNoRecordsLabel();
            }
        }

        private void cmb_ArchYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataGridView_Archive.DataSource as DataTable;
            if (dt != null)
            {
                string selectedYear = cmb_ArchYear.SelectedItem.ToString();

                if (selectedYear == "All Years")
                    dt.DefaultView.RowFilter = "";
                else
                    dt.DefaultView.RowFilter = $"[Student No] LIKE '%-{selectedYear}-%'";

                cmb_ArchYear.Refresh();
                UpdateNoRecordsLabel();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_Archive.CurrentCell == null)
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = dataGridView_Archive.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView_Archive.Rows[rowIndex];
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
                        string deleteQuery = "DELETE FROM archived_pending_requests WHERE student_no = @studno";

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

                   
                    LoadArchivedRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}