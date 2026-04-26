namespace Group5
{
    partial class StudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker_Today = new DateTimePicker();
            cmb_Courses = new ComboBox();
            txt_StudNo = new TextBox();
            txt_EMAIL = new TextBox();
            txt_ContactNo = new TextBox();
            txt_Surname = new TextBox();
            txt_FirstName = new TextBox();
            txt_MiddleName = new TextBox();
            BTN_Back = new Button();
            BTN_NEXT = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dateTimePicker2_BirthDate = new DateTimePicker();
            txt_BirthPlace = new TextBox();
            txt_LastSemYR = new TextBox();
            lbl_StudNoWarning = new Label();
            lbl_EmailWarning = new Label();
            lbl_LastSemWarning = new Label();
            lbl_ContactWarning = new Label();
            panel1 = new Panel();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label1.Location = new Point(9, 67);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label2.Location = new Point(568, 189);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label3.Location = new Point(849, 113);
            label3.Name = "label3";
            label3.Size = new Size(98, 17);
            label3.TabIndex = 2;
            label3.Text = "Student No.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label4.Location = new Point(838, 189);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label5.Location = new Point(270, 186);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 4;
            label5.Text = "Contact No:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label6.Location = new Point(10, 110);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 5;
            label6.Text = "Surname:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label7.Location = new Point(270, 113);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 6;
            label7.Text = "First Name:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label8.Location = new Point(539, 111);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 7;
            label8.Text = "Middle Name:";
            label8.Click += label8_Click;
            // 
            // dateTimePicker_Today
            // 
            dateTimePicker_Today.Font = new Font("Arial Rounded MT Bold", 11.25F);
            dateTimePicker_Today.Location = new Point(62, 61);
            dateTimePicker_Today.Name = "dateTimePicker_Today";
            dateTimePicker_Today.Size = new Size(300, 25);
            dateTimePicker_Today.TabIndex = 8;
            dateTimePicker_Today.Value = new DateTime(2025, 10, 29, 0, 21, 50, 0);
            dateTimePicker_Today.ValueChanged += dateTimePicker_Today_ValueChanged;
            // 
            // cmb_Courses
            // 
            cmb_Courses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Courses.Font = new Font("Arial Rounded MT Bold", 11.25F);
            cmb_Courses.FormattingEnabled = true;
            cmb_Courses.Items.AddRange(new object[] { "BSIT", "BSCS", "BSOA", "BSTM", "BSHM", "BCED", "BTLED" });
            cmb_Courses.Location = new Point(640, 183);
            cmb_Courses.Name = "cmb_Courses";
            cmb_Courses.Size = new Size(121, 25);
            cmb_Courses.TabIndex = 9;
            cmb_Courses.SelectedIndexChanged += cmb_Courses_SelectedIndexChanged;
            // 
            // txt_StudNo
            // 
            txt_StudNo.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_StudNo.Location = new Point(969, 110);
            txt_StudNo.Name = "txt_StudNo";
            txt_StudNo.Size = new Size(160, 25);
            txt_StudNo.TabIndex = 10;
            txt_StudNo.TextChanged += txt_StudNo_TextChanged;
            // 
            // txt_EMAIL
            // 
            txt_EMAIL.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_EMAIL.Location = new Point(895, 189);
            txt_EMAIL.Name = "txt_EMAIL";
            txt_EMAIL.Size = new Size(160, 25);
            txt_EMAIL.TabIndex = 11;
            txt_EMAIL.TextChanged += txt_EMAIL_TextChanged_1;
            // 
            // txt_ContactNo
            // 
            txt_ContactNo.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_ContactNo.Location = new Point(373, 180);
            txt_ContactNo.Name = "txt_ContactNo";
            txt_ContactNo.Size = new Size(160, 25);
            txt_ContactNo.TabIndex = 12;
            txt_ContactNo.TextChanged += txt_ContactNo_TextChanged_1;
            // 
            // txt_Surname
            // 
            txt_Surname.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_Surname.Location = new Point(95, 110);
            txt_Surname.Name = "txt_Surname";
            txt_Surname.Size = new Size(160, 25);
            txt_Surname.TabIndex = 13;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_FirstName.Location = new Point(368, 110);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(160, 25);
            txt_FirstName.TabIndex = 14;
            txt_FirstName.TextChanged += txt_FirstName_TextChanged;
            // 
            // txt_MiddleName
            // 
            txt_MiddleName.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_MiddleName.Location = new Point(651, 110);
            txt_MiddleName.Name = "txt_MiddleName";
            txt_MiddleName.Size = new Size(160, 25);
            txt_MiddleName.TabIndex = 15;
            txt_MiddleName.TextChanged += txt_MiddleName_TextChanged;
            // 
            // BTN_Back
            // 
            BTN_Back.BackColor = Color.Gold;
            BTN_Back.FlatStyle = FlatStyle.Popup;
            BTN_Back.Font = new Font("Arial Rounded MT Bold", 11.25F);
            BTN_Back.Location = new Point(838, 437);
            BTN_Back.Name = "BTN_Back";
            BTN_Back.Size = new Size(112, 53);
            BTN_Back.TabIndex = 16;
            BTN_Back.Text = "BACK";
            BTN_Back.UseVisualStyleBackColor = false;
            BTN_Back.Click += BTN_Back_Click;
            // 
            // BTN_NEXT
            // 
            BTN_NEXT.BackColor = Color.Gold;
            BTN_NEXT.FlatStyle = FlatStyle.Popup;
            BTN_NEXT.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_NEXT.Location = new Point(987, 437);
            BTN_NEXT.Name = "BTN_NEXT";
            BTN_NEXT.Size = new Size(112, 51);
            BTN_NEXT.TabIndex = 17;
            BTN_NEXT.Text = "NEXT";
            BTN_NEXT.UseVisualStyleBackColor = false;
            BTN_NEXT.Click += BTN_NEXT_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label10.Location = new Point(14, 279);
            label10.Name = "label10";
            label10.Size = new Size(94, 17);
            label10.TabIndex = 19;
            label10.Text = "Birth Place:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label11.Location = new Point(14, 186);
            label11.Name = "label11";
            label11.Size = new Size(87, 17);
            label11.TabIndex = 20;
            label11.Text = "Birth Date:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label12.Location = new Point(326, 279);
            label12.Name = "label12";
            label12.Size = new Size(193, 17);
            label12.TabIndex = 21;
            label12.Text = "Year Level /Yr. Attended: ";
            // 
            // dateTimePicker2_BirthDate
            // 
            dateTimePicker2_BirthDate.Font = new Font("Arial Rounded MT Bold", 11.25F);
            dateTimePicker2_BirthDate.Location = new Point(101, 183);
            dateTimePicker2_BirthDate.Name = "dateTimePicker2_BirthDate";
            dateTimePicker2_BirthDate.Size = new Size(161, 25);
            dateTimePicker2_BirthDate.TabIndex = 22;
            // 
            // txt_BirthPlace
            // 
            txt_BirthPlace.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_BirthPlace.Location = new Point(114, 276);
            txt_BirthPlace.Name = "txt_BirthPlace";
            txt_BirthPlace.Size = new Size(160, 25);
            txt_BirthPlace.TabIndex = 23;
            // 
            // txt_LastSemYR
            // 
            txt_LastSemYR.Font = new Font("Arial Rounded MT Bold", 11.25F);
            txt_LastSemYR.Location = new Point(514, 276);
            txt_LastSemYR.Name = "txt_LastSemYR";
            txt_LastSemYR.Size = new Size(148, 25);
            txt_LastSemYR.TabIndex = 24;
            // 
            // lbl_StudNoWarning
            // 
            lbl_StudNoWarning.AutoSize = true;
            lbl_StudNoWarning.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lbl_StudNoWarning.Location = new Point(915, 146);
            lbl_StudNoWarning.Name = "lbl_StudNoWarning";
            lbl_StudNoWarning.Size = new Size(0, 17);
            lbl_StudNoWarning.TabIndex = 25;
            lbl_StudNoWarning.Visible = false;
            lbl_StudNoWarning.Click += lbl_StudNoWarning_Click;
            // 
            // lbl_EmailWarning
            // 
            lbl_EmailWarning.AutoSize = true;
            lbl_EmailWarning.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lbl_EmailWarning.Location = new Point(829, 232);
            lbl_EmailWarning.Name = "lbl_EmailWarning";
            lbl_EmailWarning.Size = new Size(8, 17);
            lbl_EmailWarning.TabIndex = 26;
            lbl_EmailWarning.Text = "\r\n";
            // 
            // lbl_LastSemWarning
            // 
            lbl_LastSemWarning.AutoSize = true;
            lbl_LastSemWarning.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lbl_LastSemWarning.Location = new Point(498, 307);
            lbl_LastSemWarning.Name = "lbl_LastSemWarning";
            lbl_LastSemWarning.Size = new Size(0, 17);
            lbl_LastSemWarning.TabIndex = 27;
            lbl_LastSemWarning.Visible = false;
            // 
            // lbl_ContactWarning
            // 
            lbl_ContactWarning.AutoSize = true;
            lbl_ContactWarning.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lbl_ContactWarning.Location = new Point(364, 222);
            lbl_ContactWarning.Name = "lbl_ContactWarning";
            lbl_ContactWarning.Size = new Size(0, 17);
            lbl_ContactWarning.TabIndex = 28;
            lbl_ContactWarning.Click += lbl_ContactWarning_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(dateTimePicker2_BirthDate);
            panel1.Controls.Add(BTN_Back);
            panel1.Controls.Add(BTN_NEXT);
            panel1.Controls.Add(lbl_LastSemWarning);
            panel1.Controls.Add(lbl_ContactWarning);
            panel1.Controls.Add(txt_LastSemYR);
            panel1.Controls.Add(lbl_EmailWarning);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txt_BirthPlace);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dateTimePicker_Today);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_FirstName);
            panel1.Controls.Add(txt_Surname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_StudNoWarning);
            panel1.Controls.Add(txt_MiddleName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_EMAIL);
            panel1.Controls.Add(txt_ContactNo);
            panel1.Controls.Add(cmb_Courses);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_StudNo);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(104, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 563);
            panel1.TabIndex = 29;
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.BackColor = Color.Goldenrod;
            guna2TrackBar1.Enabled = false;
            guna2TrackBar1.FillColor = Color.Yellow;
            guna2TrackBar1.Location = new Point(398, 678);
            guna2TrackBar1.Maximum = 4;
            guna2TrackBar1.Minimum = 1;
            guna2TrackBar1.Name = "guna2TrackBar1";
            guna2TrackBar1.Size = new Size(565, 24);
            guna2TrackBar1.TabIndex = 30;
            guna2TrackBar1.ThumbColor = Color.Yellow;
            guna2TrackBar1.Value = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(522, 650);
            label9.Name = "label9";
            label9.Size = new Size(160, 25);
            label9.TabIndex = 31;
            label9.Text = "Fill up Information";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label9);
            Controls.Add(guna2TrackBar1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker_Today;
        private ComboBox cmb_Courses;
        private TextBox txt_StudNo;
        private TextBox txt_EMAIL;
        private TextBox txt_ContactNo;
        private TextBox txt_Surname;
        private TextBox txt_FirstName;
        private TextBox txt_MiddleName;
        private Button BTN_Back;
        private Button BTN_NEXT;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker2_BirthDate;
        private TextBox txt_BirthPlace;
        private TextBox txt_LastSemYR;
        private Label lbl_StudNoWarning;
        private Label lbl_EmailWarning;
        private Label lbl_LastSemWarning;
        private Label lbl_ContactWarning;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Label label9;
    }
}