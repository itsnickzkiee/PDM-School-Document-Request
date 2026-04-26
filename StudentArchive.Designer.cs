namespace Group5
{
    partial class StudentArchive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_Archive = new DataGridView();
            btn_back = new Button();
            txt_search = new TextBox();
            cmb_ArchCourse = new ComboBox();
            cmb_ArchYear = new ComboBox();
            btn_Remove = new Button();
            lblNoRecords2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Archive).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Archive
            // 
            dataGridView_Archive.BackgroundColor = Color.Wheat;
            dataGridView_Archive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Archive.Location = new Point(52, 153);
            dataGridView_Archive.Name = "dataGridView_Archive";
            dataGridView_Archive.Size = new Size(1169, 516);
            dataGridView_Archive.TabIndex = 0;
            dataGridView_Archive.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(1076, 95);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 46);
            btn_back.TabIndex = 1;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(52, 112);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(435, 23);
            txt_search.TabIndex = 2;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // cmb_ArchCourse
            // 
            cmb_ArchCourse.Font = new Font("Arial Rounded MT Bold", 11.25F);
            cmb_ArchCourse.FormattingEnabled = true;
            cmb_ArchCourse.Location = new Point(525, 112);
            cmb_ArchCourse.Name = "cmb_ArchCourse";
            cmb_ArchCourse.Size = new Size(155, 25);
            cmb_ArchCourse.TabIndex = 3;
            cmb_ArchCourse.Text = "Filter by Course";
            cmb_ArchCourse.SelectedIndexChanged += cmb_ArchCourse_SelectedIndexChanged;
            // 
            // cmb_ArchYear
            // 
            cmb_ArchYear.Font = new Font("Arial Rounded MT Bold", 11.25F);
            cmb_ArchYear.FormattingEnabled = true;
            cmb_ArchYear.Location = new Point(698, 112);
            cmb_ArchYear.Name = "cmb_ArchYear";
            cmb_ArchYear.Size = new Size(155, 25);
            cmb_ArchYear.TabIndex = 4;
            cmb_ArchYear.Text = "Filter by Year";
            cmb_ArchYear.SelectedIndexChanged += cmb_ArchYear_SelectedIndexChanged;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.Orange;
            btn_Remove.FlatStyle = FlatStyle.Popup;
            btn_Remove.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Remove.Location = new Point(908, 95);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(142, 45);
            btn_Remove.TabIndex = 5;
            btn_Remove.Text = "REMOVE";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // lblNoRecords2
            // 
            lblNoRecords2.AutoSize = true;
            lblNoRecords2.BackColor = Color.Wheat;
            lblNoRecords2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoRecords2.ForeColor = Color.SaddleBrown;
            lblNoRecords2.Location = new Point(567, 400);
            lblNoRecords2.Name = "lblNoRecords2";
            lblNoRecords2.Size = new Size(225, 28);
            lblNoRecords2.TabIndex = 6;
            lblNoRecords2.Text = "No Records Found";
            // 
            // StudentArchive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblNoRecords2);
            Controls.Add(btn_Remove);
            Controls.Add(cmb_ArchYear);
            Controls.Add(cmb_ArchCourse);
            Controls.Add(txt_search);
            Controls.Add(btn_back);
            Controls.Add(dataGridView_Archive);
            Name = "StudentArchive";
            Text = "Student Archive";
            Load += StudentArchive_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Archive).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Archive;
        private Button btn_back;
        private TextBox txt_search;
        private ComboBox cmb_ArchCourse;
        private ComboBox cmb_ArchYear;
        private Button btn_Remove;
        private Label lblNoRecords2;
    }
}