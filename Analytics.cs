using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Group5
{
    public partial class Analytics : Form
    {
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loader;
        private readonly string[] Courses = { "BSIT", "BSCS", "BSOA", "BSHM", "BSTM", "BTLED", "BCED" };

        private readonly string[] RequestTypes = {
            "Transfer Credentials (HD, COG, TOR, GMC)",
            "Certification, Authentication and Verification (CAV)",
            "Scholastic Record",
            "To Cross-enroll Permit",
            "True Copy of Grades",
            "Certificate of Registration (COR)",
            "Grades Form - A.Y._____ Semester/s:_____",
            "Certificate of Graduation",
            "NO ID Issuance Certification",
            "NSTP Serial No. Certification",
            "CTC of Document",
            "Medium of Instruction (MOI)"
        };

        private readonly string connStr = "server=127.0.0.1; user=root; database=sample; password=";

        public Analytics()
        {
            InitializeComponent();

            InitializeComboBox();
            SetupYearComboBox();
            InitializeLoader();

            guna2ProgressBar1.Minimum = 0;
            guna2ProgressBar1.Maximum = 100;


            cmbChartType.SelectedIndexChanged -= cmbChartType_SelectedIndexChanged;
            cmbChartType.SelectedIndex = 0;
            cmbChartType.SelectedIndexChanged += cmbChartType_SelectedIndexChanged;


            LoadDataGrid(cmbChartType.SelectedItem?.ToString());
            DrawChart();

            if (pictureBox1 != null) pictureBox1.Visible = true;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
        }



        #region Chart Drawing (Your Original Methods Retained)

        private void DrawPieChart(string[] categories, float[] values)
        {
            if (values == null || values.Length == 0) { pictureBox1.Image = null; pictureBox1.Visible = false; return; }

            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Yellow, Color.Cyan, Color.Magenta };
            Bitmap bmp = new Bitmap(Math.Max(300, pictureBox1.Width), Math.Max(300, pictureBox1.Height));

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                float total = values.Sum();
                if (total == 0) total = 1;
                float startAngle = 0;
                int chartSize = Math.Min(bmp.Width, bmp.Height);
                Rectangle pieRect = new Rectangle(20, 20, chartSize - 100, chartSize - 100);
                PointF pieCenter = new PointF(pieRect.X + pieRect.Width / 2, pieRect.Y + pieRect.Height / 2);
                float pieRadius = pieRect.Width / 2;
                Font labelFont = new Font("Arial", 9, FontStyle.Bold);
                Font legendFont = new Font("Arial", 9);

                int legendX = pieRect.Right + 10;
                int legendY = 20;
                int legendBoxSize = 10;
                int legendLineHeight = 20;

                for (int i = 0; i < values.Length; i++)
                {
                    float sweepAngle = values[i] / total * 360f;
                    Color color = colors[i % colors.Length];

                    using (Brush brush = new SolidBrush(color))
                        g.FillPie(brush, pieRect, startAngle, sweepAngle);

                    if (sweepAngle > 5)
                    {
                        float midAngle = startAngle + sweepAngle / 2;
                        float labelRadius = pieRadius * 0.6f;
                        double angleRad = midAngle * Math.PI / 180.0;
                        float x = pieCenter.X + (float)(labelRadius * Math.Cos(angleRad));
                        float y = pieCenter.Y + (float)(labelRadius * Math.Sin(angleRad));
                        string text = $"{values[i]} ({values[i] / total * 100:0}%)";
                        SizeF size = g.MeasureString(text, labelFont);
                        g.DrawString(text, labelFont, Brushes.Black, x - size.Width / 2, y - size.Height / 2);
                    }

                    string legendText = $"{categories[i]} {values[i]} ({values[i] / total * 100:0}%)";
                    g.FillRectangle(new SolidBrush(color), legendX, legendY, legendBoxSize, legendBoxSize);
                    g.DrawString(legendText, legendFont, Brushes.Black, legendX + legendBoxSize + 5, legendY - 3);
                    legendY += legendLineHeight;

                    startAngle += sweepAngle;
                }
            }

            pictureBox1.Image = bmp;
            pictureBox1.Visible = true;
        }

        private void SetupYearComboBox()
        {
            cmbYear.Items.Clear();

            int currentYear = DateTime.Now.Year;
            for (int y = currentYear; y >= currentYear - 5; y--)
            {
                cmbYear.Items.Add(y.ToString());
            }

            cmbYear.SelectedItem = currentYear.ToString();
        }

        private void DrawLineChartFromGrid()
        {
            if (!dataGridView1.Columns.Contains("RequestType"))
            {
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
                return;
            }

            List<string> xRequestTypes = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                object rt = row.Cells["RequestType"]?.Value;
                if (rt == null) continue;
                string rtStr = rt.ToString();
                if (!xRequestTypes.Contains(rtStr))
                    xRequestTypes.Add(rtStr);
            }

            if (xRequestTypes.Count == 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
                return;
            }

            Dictionary<string, List<float>> series = new Dictionary<string, List<float>>();
            foreach (var c in Courses)
                series[c] = new List<float>();

            foreach (var rt in xRequestTypes)
            {
                foreach (var course in Courses)
                {
                    float val = 0f;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        object rtObj = row.Cells["RequestType"]?.Value;
                        object courseObj = row.Cells["Course"]?.Value;
                        object totalObj = row.Cells["Total"]?.Value;

                        if (rtObj == null || courseObj == null) continue;

                        if (rtObj.ToString() == rt && courseObj.ToString() == course)
                        {
                            if (float.TryParse(totalObj?.ToString(), out float parsed))
                                val = parsed;
                            else val = 0f;
                            break;
                        }
                    }
                    series[course].Add(val);
                }
            }

            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Cyan, Color.Magenta, Color.Brown };

            int xCount = xRequestTypes.Count;
            int minWidth = 400;
            int widthPerPoint = 90;

            int marginLeft = 80;
            int marginBottom = 120;
            int marginTop = 40;
            int legendMarginRight = 150;

            int calculatedChartAreaWidth = (xCount > 1) ? (xCount - 1) * widthPerPoint : widthPerPoint;
            int calculatedWidth = calculatedChartAreaWidth + marginLeft + legendMarginRight;

            int width = Math.Max(minWidth, calculatedWidth);
            int height = Math.Max(500, pictureBox1.Height);
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                int chartWidth = width - marginLeft - legendMarginRight;
                int chartHeight = height - marginTop - marginBottom;

                float maxY = 1;
                foreach (var s in series.Values)
                {
                    if (s.Count > 0)
                    {
                        maxY = Math.Max(maxY, s.Max());
                    }
                }
                if (maxY == 0) maxY = 1;

                Pen axisPen = new Pen(Color.Black, 1);
                g.DrawLine(axisPen, marginLeft, marginTop + chartHeight, marginLeft + chartWidth, marginTop + chartHeight);
                g.DrawLine(axisPen, marginLeft, marginTop, marginLeft, marginTop + chartHeight);

                float xStep = (xCount > 1) ? chartWidth / (xCount - 1) : chartWidth;
                Font xLabelFont = new Font("Arial", 8);

                for (int xi = 0; xi < xCount; xi++)
                {
                    float x = marginLeft + (xCount > 1 ? xi * xStep : chartWidth / 2);

                    g.DrawLine(Pens.LightGray, x, marginTop, x, marginTop + chartHeight);

                    string lbl = xRequestTypes[xi];

                    float tx = x;
                    float ty = marginTop + chartHeight + 6;

                    System.Drawing.Drawing2D.Matrix originalMatrix = g.Transform;

                    g.TranslateTransform(tx, ty);

                    g.RotateTransform(45);

                    g.DrawString(lbl, xLabelFont, Brushes.Black, 0, 0);

                    g.Transform = originalMatrix;
                }

                int yTicks = 5;
                for (int t = 0; t <= yTicks; t++)
                {
                    float yVal = maxY * t / yTicks;
                    float y = marginTop + chartHeight - (yVal / maxY * chartHeight);
                    g.DrawLine(Pens.LightGray, marginLeft, y, marginLeft + chartWidth, y);
                    g.DrawString(yVal.ToString("0"), new Font("Arial", 8), Brushes.Black, 10, y - 8);
                }

                int idx = 0;
                foreach (var kvp in series)
                {
                    var values = kvp.Value;
                    Color color = colors[idx % colors.Length];
                    Pen pen = new Pen(color, 2);
                    PointF? prev = null;

                    for (int i = 0; i < values.Count; i++)
                    {
                        float x = marginLeft + (xCount > 1 ? i * xStep : chartWidth / 2);
                        float y = marginTop + chartHeight - (values[i] / maxY * chartHeight);

                        if (prev != null)
                            g.DrawLine(pen, prev.Value, new PointF(x, y));

                        g.FillEllipse(new SolidBrush(color), x - 3, y - 3, 6, 6);
                        prev = new PointF(x, y);
                    }

                    int legendX = marginLeft + chartWidth + 10;
                    int legendY = marginTop + idx * 20;

                    g.FillRectangle(new SolidBrush(color), legendX, legendY, 12, 12);

                    g.DrawString(kvp.Key, new Font("Arial", 9), Brushes.Black, legendX + 18, legendY - 2);

                    idx++;
                }
            }

            pictureBox1.Image = bmp;
            pictureBox1.Visible = true;
        }

        private void DrawPieChartFromGrid()
        {
            var grouped = new Dictionary<string, float>(StringComparer.OrdinalIgnoreCase);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                object courseObj = row.Cells["Course"]?.Value;
                object totalObj = row.Cells["Total"]?.Value;
                if (courseObj == null || totalObj == null) continue;

                string course = courseObj.ToString();
                if (!float.TryParse(totalObj.ToString(), out float t)) t = 0;

                if (!grouped.ContainsKey(course))
                    grouped[course] = 0;
                grouped[course] += t;
            }

            if (grouped.Count == 0)
            {
                grouped["No Data"] = 0;
            }

            var nonZero = grouped.Where(kv => kv.Value >= 0).ToList();

            string[] cats = nonZero.Select(kv => kv.Key).ToArray();
            float[] vals = nonZero.Select(kv => kv.Value).ToArray();

            DrawPieChart(cats, vals);
        }

        private void DrawChart()
        {
            pictureBox1.Image = null;
            pictureBox1.Visible = false;

            if (cmbChartType.SelectedItem?.ToString() == "Per Course")
            {
                DrawPieChartFromGrid();
            }
            else if (cmbChartType.SelectedItem?.ToString() == "Request Type")
            {
                DrawLineChartFromGrid();
            }
            else if (cmbChartType.SelectedItem?.ToString() == "Year Level")
            {
                DrawBarChartFromGrid();
            }
        }

        private void DrawBarChartFromGrid()
        {
            if (!dataGridView1.Columns.Contains("YearLevel"))
            {
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
                return;
            }

            string[] YearLevels = { "1st Year", "2nd Year", "3rd Year", "4th Year" };

            var data = new Dictionary<string, Dictionary<string, float>>();
            float maxY = 1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string course = row.Cells["Course"]?.Value?.ToString() ?? "N/A";
                string yearLevel = row.Cells["YearLevel"]?.Value?.ToString() ?? "N/A";

                if (!float.TryParse(row.Cells["Total"]?.Value?.ToString(), out float total)) total = 0;

                if (!data.ContainsKey(course))
                    data[course] = new Dictionary<string, float>();

                data[course][yearLevel] = total;
                maxY = Math.Max(maxY, total);
            }

            if (data.Count == 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
                return;
            }

            if (maxY == 0) maxY = 1;

            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange };

            int width = Math.Max(800, pictureBox1.Width);
            int height = Math.Max(400, pictureBox1.Height);
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                int marginLeft = 60;
                int marginBottom = 50;
                int marginTop = 40;
                int legendMarginRight = 100;

                int chartWidth = width - marginLeft - legendMarginRight;
                int chartHeight = height - marginTop - marginBottom;

                int courseCount = Courses.Length;
                float groupWidth = chartWidth / (float)courseCount;
                float barWidth = groupWidth / (YearLevels.Length + 1);

                Pen axisPen = new Pen(Color.Black, 1);
                g.DrawLine(axisPen, marginLeft, marginTop + chartHeight, marginLeft + chartWidth, marginTop + chartHeight);
                g.DrawLine(axisPen, marginLeft, marginTop, marginLeft, marginTop + chartHeight);

                Font labelFont = new Font("Arial", 8);

                int yTicks = 5;
                for (int t = 0; t <= yTicks; t++)
                {
                    float yVal = maxY * t / yTicks;
                    float y = marginTop + chartHeight - (yVal / maxY * chartHeight);
                    g.DrawLine(Pens.LightGray, marginLeft, y, marginLeft + chartWidth, y);
                    g.DrawString(yVal.ToString("0"), labelFont, Brushes.Black, 10, y - 8);
                }

                for (int i = 0; i < courseCount; i++)
                {
                    string course = Courses[i];
                    float groupStartX = marginLeft + i * groupWidth;

                    SizeF s = g.MeasureString(course, labelFont);
                    g.DrawString(course, labelFont, Brushes.Black, groupStartX + groupWidth / 2 - s.Width / 2, marginTop + chartHeight + 5);

                    if (data.ContainsKey(course))
                    {
                        for (int j = 0; j < YearLevels.Length; j++)
                        {
                            string year = YearLevels[j];
                            Color color = colors[j % colors.Length];

                            float total = data[course].ContainsKey(year) ? data[course][year] : 0;

                            if (total > 0)
                            {
                                float barHeight = total / maxY * chartHeight;
                                float barX = groupStartX + (j * barWidth) + (barWidth / 2);
                                float barY = marginTop + chartHeight - barHeight;

                                RectangleF barRect = new RectangleF(barX, barY, barWidth * 0.8f, barHeight);

                                g.FillRectangle(new SolidBrush(color), barRect);

                                g.DrawString(total.ToString("0"), labelFont, Brushes.Black,
                                             barX + barWidth * 0.8f / 2 - g.MeasureString(total.ToString("0"), labelFont).Width / 2,
                                             barY - 15);
                            }
                        }
                    }
                }

                int legendX = marginLeft + chartWidth + 10;
                int legendY = marginTop + 10;

                for (int j = 0; j < YearLevels.Length; j++)
                {
                    Color color = colors[j % colors.Length];
                    g.FillRectangle(new SolidBrush(color), legendX, legendY, 12, 12);
                    g.DrawString(YearLevels[j], new Font("Arial", 9), Brushes.Black, legendX + 18, legendY - 2);
                    legendY += 20;
                }
            }

            pictureBox1.Image = bmp;
            pictureBox1.Visible = true;
        }

        #endregion

        #region Setup Columns & Unified Loading Data 

        private void InitializeComboBox()
        {
            cmbChartType.Items.Clear();
            cmbChartType.Items.Add("Per Course");
            cmbChartType.Items.Add("Request Type");
            cmbChartType.Items.Add("Year Level");
        }

        private void SetColumnsPerCourse()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Course", "Course");
            var totalCol = new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Total" };
            dataGridView1.Columns.Add(totalCol);
        }

        private void SetColumnsRequestType()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("RequestType", "Request Type");
            dataGridView1.Columns.Add("Course", "Course");
            dataGridView1.Columns.Add("Total", "Total");
        }

        private void SetColumnsYearLevel()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Course", "Course");
            dataGridView1.Columns.Add("YearLevel", "Year Level");
            dataGridView1.Columns.Add("Total", "Total");
        }


        private void LoadDataGrid(string type)
        {
            string currentYear = cmbYear.Text;
            if (string.IsNullOrWhiteSpace(currentYear)) currentYear = DateTime.Now.Year.ToString();

            bool dbHasRows = TryLoadFromDatabase(type, currentYear);

            if (!dbHasRows)
            {

                LoadChartDataFromFile();


                string[] YearLevels = { "1st Year", "2nd Year", "3rd Year", "4th Year" };

                bool isPerCourseInGrid = dataGridView1.Columns.Contains("Course") && !dataGridView1.Columns.Contains("RequestType") && !dataGridView1.Columns.Contains("YearLevel");
                bool isRequestTypeInGrid = dataGridView1.Columns.Contains("RequestType");
                bool isYearLevelInGrid = dataGridView1.Columns.Contains("YearLevel");

                if (dataGridView1.RowCount == 0 ||
                    (type == "Per Course" && !isPerCourseInGrid) ||
                    (type == "Request Type" && !isRequestTypeInGrid) ||
                    (type == "Year Level" && !isYearLevelInGrid))
                {
                    dataGridView1.Rows.Clear();

                    if (type == "Per Course")
                    {
                        SetColumnsPerCourse();

                        int[] initialTotals_2022 = { 50, 23, 12, 23, 15, 10, 8 };

                        for (int i = 0; i < Courses.Length; i++)
                        {
                            int total = (currentYear == "2022") ? initialTotals_2022[i] : 0;
                            dataGridView1.Rows.Add(Courses[i], total);
                        }
                    }
                    else if (type == "Request Type")
                    {
                        SetColumnsRequestType();

                        foreach (var req in RequestTypes)
                        {
                            foreach (var c in Courses)
                            {
                                int total = 0;
                                if (currentYear == "2025" && req.StartsWith("Transfer Credentials"))
                                {
                                    if (c == "BSIT" || c == "BSCS") total = 21;
                                    else if (c == "BSOA") total = 11;
                                }
                                dataGridView1.Rows.Add(req, c, total);
                            }
                        }
                    }
                    else if (type == "Year Level")
                    {
                        SetColumnsYearLevel();

                        foreach (var course in Courses)
                        {
                            foreach (var year in YearLevels)
                            {
                                int total = 0;
                                dataGridView1.Rows.Add(course, year, total);
                            }
                        }
                    }
                }
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = (col.Name != "Total");
            }

            LoadTotals();
        }

        private bool TryLoadFromDatabase(string type, string yearString)
        {
            if (!int.TryParse(yearString, out int year)) return false;

            bool hadRows = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    if (type == "Per Course")
                    {
                        SetColumnsPerCourse();
                        string sql = "SELECT course, total FROM per_course_analytics WHERE year=@year";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@year", year);
                            using (var r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    dataGridView1.Rows.Add(r.GetString("course"), r.GetInt32("total"));
                                    hadRows = true;
                                }
                            }
                        }
                    }
                    else if (type == "Request Type")
                    {
                        SetColumnsRequestType();
                        string sql = "SELECT request_type, course, total FROM request_type_analytics WHERE year=@year";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@year", year);
                            using (var r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {

                                    dataGridView1.Rows.Add(r.GetString("request_type"), r.GetString("course"), r.GetInt32("total"));
                                    hadRows = true;
                                }
                            }
                        }
                    }
                    else if (type == "Year Level")
                    {
                        SetColumnsYearLevel();
                        string sql = "SELECT course, year_level, total FROM year_level_analytics WHERE year=@year";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@year", year);
                            using (var r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    dataGridView1.Rows.Add(r.GetString("course"), r.GetString("year_level"), r.GetInt32("total"));
                                    hadRows = true;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

                hadRows = false;
            }

            return hadRows;
        }

        #endregion

        #region CSV Save/Load (Revised Filename to include Chart Type)

        private void SaveChartDataToFile()
        {
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string currentYear = cmbYear.Text;
                string chartType = cmbChartType.SelectedItem?.ToString().Replace(" ", "") ?? "PerCourse";

                if (string.IsNullOrWhiteSpace(currentYear)) currentYear = DateTime.Now.Year.ToString();

                string fileName = $"chart_data_{currentYear}_{chartType}.csv";
                string filePath = Path.Combine(documentsPath, fileName);

                var lines = new List<string>();


                if (dataGridView1.Columns.Contains("Course") && dataGridView1.Columns.Contains("YearLevel") && dataGridView1.Columns.Contains("Total"))
                {
                    lines.Add("Course,YearLevel,Total");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string course = row.Cells["Course"].Value?.ToString() ?? string.Empty;
                        string yearLevel = row.Cells["YearLevel"].Value?.ToString() ?? string.Empty;
                        string total = row.Cells["Total"].Value?.ToString() ?? "0";
                        lines.Add($"{EscapeCsv(course)},{EscapeCsv(yearLevel)},{total}");
                    }
                }

                else if (dataGridView1.Columns.Contains("RequestType") && dataGridView1.Columns.Contains("Course") && dataGridView1.Columns.Contains("Total"))
                {
                    lines.Add("RequestType,Course,Total");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string rt = row.Cells["RequestType"].Value?.ToString() ?? string.Empty;
                        string course = row.Cells["Course"].Value?.ToString() ?? string.Empty;
                        string total = row.Cells["Total"].Value?.ToString() ?? "0";
                        lines.Add($"{EscapeCsv(rt)},{EscapeCsv(course)},{total}");
                    }
                }

                else if (dataGridView1.Columns.Contains("Course") && dataGridView1.Columns.Contains("Total"))
                {
                    lines.Add("Course,Total");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string course = row.Cells["Course"].Value?.ToString() ?? string.Empty;
                        string total = row.Cells["Total"].Value?.ToString() ?? "0";
                        lines.Add($"{EscapeCsv(course)},{total}");
                    }
                }

                File.WriteAllLines(filePath, lines);
                MessageBox.Show($"Chart Data for {currentYear} ({cmbChartType.SelectedItem}) Successfully Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                TrySaveToDatabase(cmbChartType.SelectedItem?.ToString(), currentYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving chart data: " + ex.Message, "File Error");
            }
        }


        private void TrySaveToDatabase(string chartType, string yearString)
        {
            if (!int.TryParse(yearString, out int year)) year = DateTime.Now.Year;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    if (chartType == "PerCourse" || chartType == "Per Course" || (cmbChartType.SelectedItem?.ToString() == "Per Course"))
                    {

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string course = row.Cells["Course"]?.Value?.ToString() ?? "";
                            if (!int.TryParse(row.Cells["Total"]?.Value?.ToString(), out int total)) total = 0;

                            string sql = @"
                                INSERT INTO per_course_analytics (year, course, total)
                                VALUES (@year, @course, @total)
                                ON DUPLICATE KEY UPDATE total=@total";
                            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@year", year);
                                cmd.Parameters.AddWithValue("@course", course);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else if (chartType == "RequestType" || chartType == "Request Type" || (cmbChartType.SelectedItem?.ToString() == "Request Type"))
                    {

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string requestType = row.Cells["RequestType"]?.Value?.ToString() ?? "";
                            string course = row.Cells["Course"]?.Value?.ToString() ?? "";
                            if (!int.TryParse(row.Cells["Total"]?.Value?.ToString(), out int total)) total = 0;

                            string sql = @"
                                INSERT INTO request_type_analytics (year, request_type, course, total)
                                VALUES (@year, @req, @course, @total)
                                ON DUPLICATE KEY UPDATE total=@total";
                            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@year", year);
                                cmd.Parameters.AddWithValue("@req", requestType);
                                cmd.Parameters.AddWithValue("@course", course);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else if (chartType == "YearLevel" || chartType == "Year Level" || (cmbChartType.SelectedItem?.ToString() == "Year Level"))
                    {

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string course = row.Cells["Course"]?.Value?.ToString() ?? "";
                            string yearLevel = row.Cells["YearLevel"]?.Value?.ToString() ?? "";
                            if (!int.TryParse(row.Cells["Total"]?.Value?.ToString(), out int total)) total = 0;

                            string sql = @"
                                INSERT INTO year_level_analytics (year, course, year_level, total)
                                VALUES (@year, @course, @ylevel, @total)
                                ON DUPLICATE KEY UPDATE total=@total";
                            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@year", year);
                                cmd.Parameters.AddWithValue("@course", course);
                                cmd.Parameters.AddWithValue("@ylevel", yearLevel);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Warning: could not save to database.\n" + ex.Message, "DB Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadChartDataFromFile()
        {
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string currentYear = cmbYear.Text;
                string chartType = cmbChartType.SelectedItem?.ToString().Replace(" ", "") ?? "PerCourse";

                if (string.IsNullOrWhiteSpace(currentYear)) currentYear = DateTime.Now.Year.ToString();

                string fileName = $"chart_data_{currentYear}_{chartType}.csv";
                string filePath = Path.Combine(documentsPath, fileName);


                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (!File.Exists(filePath))
                    return;

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length <= 1) return;

                var header = lines[0].Split(',').Select(h => h.Trim().ToLower()).ToArray();


                if (header.Contains("course") && header.Contains("yearlevel") && header.Contains("total"))
                {
                    SetColumnsYearLevel();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var parts = ParseCsvLine(lines[i]);
                        if (parts.Length >= 3)
                            dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }

                else if (header.Contains("requesttype") && header.Contains("course") && header.Contains("total"))
                {
                    SetColumnsRequestType();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var parts = ParseCsvLine(lines[i]);
                        if (parts.Length >= 3)
                            dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }

                else if (header.Contains("course") && header.Contains("total"))
                {
                    SetColumnsPerCourse();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var parts = ParseCsvLine(lines[i]);
                        if (parts.Length >= 2)
                            dataGridView1.Rows.Add(parts[0], parts[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message, "File Error");
            }
        }

        private string EscapeCsv(string s)
        {
            if (s == null) return "";
            if (s.Contains(",") || s.Contains("\"") || s.Contains(Environment.NewLine))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private string[] ParseCsvLine(string line)
        {
            var tokens = new List<string>();
            bool inQuotes = false;
            var cur = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        cur.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                    continue;
                }
                if (c == ',' && !inQuotes)
                {
                    tokens.Add(cur.ToString().Trim());
                    cur.Clear();
                }
                else
                    cur.Append(c);
            }
            tokens.Add(cur.ToString().Trim());
            return tokens.ToArray();
        }

        #endregion

        #region Events & Helpers (Corrected event calls)

        private async void Analytics_Load(object sender, EventArgs e)
        {
            LoadDataGrid(cmbChartType.SelectedItem?.ToString());
            guna2ProgressBar1.Visible = false;


            DrawChart();


            guna2ProgressBar1.Minimum = 0;
            guna2ProgressBar1.Maximum = 100;
            guna2ProgressBar1.Value = 0;


            ShowLoader();


            guna2ProgressBar1.Visible = false;


            int totalSteps = 30;
            int stepValue = guna2ProgressBar1.Maximum / totalSteps;


            for (int i = 0; i <= totalSteps; i++)
            {

                int newValue = i * stepValue;
                if (newValue > guna2ProgressBar1.Maximum) newValue = guna2ProgressBar1.Maximum;

                guna2ProgressBar1.Value = newValue;


                await Task.Delay(100);
            }


            LoadChartDataFromFile();



            HideLoader();
            guna2ProgressBar1.Value = guna2ProgressBar1.Maximum;
            guna2ProgressBar1.Visible = false;
        }

        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGrid(cmbChartType.SelectedItem?.ToString());
            DrawChart();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGrid(cmbChartType.SelectedItem?.ToString());
            DrawChart();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

            DrawChart();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveChartDataToFile();
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
        private void LoadTotals()
        {

            string connStrLocal = "server=127.0.0.1; user=root; database=sample; password=";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStrLocal))
                {
                    conn.Open();

                    MySqlCommand cmdTotal = new MySqlCommand(
                        "SELECT (SELECT COUNT(*) FROM pending_requests) + (SELECT COUNT(*) FROM archived_pending_requests)", conn);
                    lblTotal.Text = Convert.ToInt32(cmdTotal.ExecuteScalar()).ToString();

                    MySqlCommand cmdPending = new MySqlCommand("SELECT COUNT(*) FROM pending_requests WHERE payment_status='Pending'", conn);
                    lblPending.Text = Convert.ToInt32(cmdPending.ExecuteScalar()).ToString();

                    MySqlCommand cmdCompleted = new MySqlCommand("SELECT COUNT(*) FROM archived_pending_requests", conn);
                    lblCompleted.Text = Convert.ToInt32(cmdCompleted.ExecuteScalar()).ToString();
                }
            }
            catch
            {

            }
        }

        #endregion

        #region Numeric input enforcement (Restored Original Logic)

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;

            int colIndex = dataGridView1.CurrentCell.ColumnIndex;
            string colName = dataGridView1.Columns[colIndex].Name;

            e.Control.KeyPress -= NumericColumn_KeyPress;

            if (colName == "Total")
            {
                e.Control.KeyPress += NumericColumn_KeyPress;
            }
        }

        private void NumericColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox)?.Text.Contains(".") == true)
            {
                e.Handled = true;
            }
        }

        #endregion

        private async void btn_Load_Click_1(object sender, EventArgs e)
        {


            guna2ProgressBar1.Visible = true;
            guna2ProgressBar1.Value = 0;


            guna2ProgressBar1.Minimum = 0;
            guna2ProgressBar1.Maximum = 100;


            dataGridView1.EndEdit();
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);


            int totalSteps = 30;
            int stepDuration = 100;
            int stepValue = guna2ProgressBar1.Maximum / totalSteps;

            for (int i = 1; i <= totalSteps; i++)
            {

                guna2ProgressBar1.Value = i * stepValue;


                await Task.Delay(stepDuration);
            }


            DrawChart();

            guna2ProgressBar1.Value = guna2ProgressBar1.Maximum;
            guna2ProgressBar1.Visible = false;



        }

        private async void btn_save_Click_1(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

            SaveChartDataToFile();


            DrawChart();


            loader.Visible = true;
            loader.Start();
            this.Cursor = Cursors.WaitCursor;


            await Task.Run(() =>
            {

                System.Threading.Thread.Sleep(2500);
            });


            loader.Stop();
            loader.Visible = false;
            this.Cursor = Cursors.Default;

            MessageBox.Show("Data successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeLoader()
        {
            loader = new Guna.UI2.WinForms.Guna2WinProgressIndicator
            {
                Size = new Size(100, 100),

                Location = new Point((this.ClientSize.Width - 100) / 2,
                                     (this.ClientSize.Height - 100) / 2),
                Visible = false,
                ProgressColor = Color.Yellow,
                BackColor = Color.Transparent,
            };

            this.Controls.Add(loader);
            loader.BringToFront();
        }
        private void cmbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbYear.SelectedItem == null || cmbChartType.SelectedItem == null)
                return;


            dataGridView1.EndEdit();
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);


            LoadDataGrid(cmbChartType.SelectedItem.ToString());
            DrawChart();
        }

        private void Analytics_Load_1(object sender, EventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void sENDANOTICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingStatus form5 = new PendingStatus();
            form5.Show();


        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            string connStr = "server=127.0.0.1; user=root; database=sample; password=";
            SendaNotice form6 = new SendaNotice(connStr);
            form6.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Show();
        }

        private void lblPending_Click(object sender, EventArgs e)
        {

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
