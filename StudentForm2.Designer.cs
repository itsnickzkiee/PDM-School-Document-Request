namespace Group5
{
    partial class StudentForm2
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
            txt_HomeAdd = new TextBox();
            txt_SchoolLastAttend = new TextBox();
            txt_AddressLAst = new TextBox();
            cmb_StudentStatus = new ComboBox();
            cmb_Purpose = new ComboBox();
            cmb_ReqFor = new ComboBox();
            lbl_Paymet = new Label();
            btn_PAYSUBMIT = new Button();
            button1 = new Button();
            dateTimePicker_Pick = new DateTimePicker();
            label7 = new Label();
            panel1 = new Panel();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(32, 79);
            label1.Name = "label1";
            label1.Size = new Size(201, 18);
            label1.TabIndex = 0;
            label1.Text = "Present Home Address: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(30, 123);
            label2.Name = "label2";
            label2.Size = new Size(443, 18);
            label2.TabIndex = 1;
            label2.Text = "Name of School Last Attended (Before entering PDM) : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(32, 176);
            label3.Name = "label3";
            label3.Size = new Size(260, 18);
            label3.TabIndex = 2;
            label3.Text = "Address of Sch. Last Attended: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(32, 230);
            label4.Name = "label4";
            label4.Size = new Size(136, 18);
            label4.TabIndex = 3;
            label4.Text = "Student Status: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(32, 279);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 4;
            label5.Text = "Purpose: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(32, 344);
            label6.Name = "label6";
            label6.Size = new Size(115, 18);
            label6.TabIndex = 5;
            label6.Text = "Request For: ";
            // 
            // txt_HomeAdd
            // 
            txt_HomeAdd.Location = new Point(239, 79);
            txt_HomeAdd.Name = "txt_HomeAdd";
            txt_HomeAdd.Size = new Size(266, 23);
            txt_HomeAdd.TabIndex = 6;
            // 
            // txt_SchoolLastAttend
            // 
            txt_SchoolLastAttend.Location = new Point(479, 123);
            txt_SchoolLastAttend.Name = "txt_SchoolLastAttend";
            txt_SchoolLastAttend.Size = new Size(266, 23);
            txt_SchoolLastAttend.TabIndex = 7;
            // 
            // txt_AddressLAst
            // 
            txt_AddressLAst.Location = new Point(298, 176);
            txt_AddressLAst.Name = "txt_AddressLAst";
            txt_AddressLAst.Size = new Size(304, 23);
            txt_AddressLAst.TabIndex = 8;
            txt_AddressLAst.TextChanged += txt_AddressLAst_TextChanged;
            // 
            // cmb_StudentStatus
            // 
            cmb_StudentStatus.BackColor = SystemColors.InactiveBorder;
            cmb_StudentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_StudentStatus.FormattingEnabled = true;
            cmb_StudentStatus.Items.AddRange(new object[] { "Alumnus", "Not Enrolled", "Enrolled" });
            cmb_StudentStatus.Location = new Point(183, 230);
            cmb_StudentStatus.Name = "cmb_StudentStatus";
            cmb_StudentStatus.Size = new Size(180, 23);
            cmb_StudentStatus.TabIndex = 9;
            // 
            // cmb_Purpose
            // 
            cmb_Purpose.BackColor = SystemColors.InactiveBorder;
            cmb_Purpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Purpose.FormattingEnabled = true;
            cmb_Purpose.Items.AddRange(new object[] { "For Employment ", "For Reference", "For Financial Assistance ", "For Scholarship" });
            cmb_Purpose.Location = new Point(183, 279);
            cmb_Purpose.Name = "cmb_Purpose";
            cmb_Purpose.Size = new Size(180, 23);
            cmb_Purpose.TabIndex = 10;
            // 
            // cmb_ReqFor
            // 
            cmb_ReqFor.BackColor = SystemColors.InactiveBorder;
            cmb_ReqFor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ReqFor.FormattingEnabled = true;
            cmb_ReqFor.Items.AddRange(new object[] { "", "Transfer Credentials (HD, COG, TOR, GMC) - (Php. 200.00)", "Certification, Authentication and Verification (CAV) - (Php. 200.00)", "Scholastic Record - (Php. 50.00)", "To Cross-enroll Permit - (Php. 50.00)", "True Copy of Grades - (Php. 50.00)", "Certificate of Registration (COR) - (Php. 50.00)", "Grades Form - A.Y._______ Semester/s:______--(Php. 50.00)", "" });
            cmb_ReqFor.Location = new Point(183, 344);
            cmb_ReqFor.Name = "cmb_ReqFor";
            cmb_ReqFor.Size = new Size(352, 23);
            cmb_ReqFor.TabIndex = 11;
            cmb_ReqFor.SelectedIndexChanged += cmb_ReqFor_SelectedIndexChanged;
            // 
            // lbl_Paymet
            // 
            lbl_Paymet.AutoSize = true;
            lbl_Paymet.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Paymet.ForeColor = Color.SaddleBrown;
            lbl_Paymet.Location = new Point(52, 496);
            lbl_Paymet.Name = "lbl_Paymet";
            lbl_Paymet.Size = new Size(0, 40);
            lbl_Paymet.TabIndex = 13;
            // 
            // btn_PAYSUBMIT
            // 
            btn_PAYSUBMIT.BackColor = Color.Orange;
            btn_PAYSUBMIT.FlatStyle = FlatStyle.Popup;
            btn_PAYSUBMIT.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btn_PAYSUBMIT.Location = new Point(676, 499);
            btn_PAYSUBMIT.Name = "btn_PAYSUBMIT";
            btn_PAYSUBMIT.Size = new Size(113, 61);
            btn_PAYSUBMIT.TabIndex = 14;
            btn_PAYSUBMIT.Text = "PAY AND SUBMIT";
            btn_PAYSUBMIT.UseVisualStyleBackColor = false;
            btn_PAYSUBMIT.Click += btn_PAYSUBMIT_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            button1.Location = new Point(532, 496);
            button1.Name = "button1";
            button1.Size = new Size(105, 64);
            button1.TabIndex = 15;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker_Pick
            // 
            dateTimePicker_Pick.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_Pick.Location = new Point(183, 411);
            dateTimePicker_Pick.Name = "dateTimePicker_Pick";
            dateTimePicker_Pick.Size = new Size(239, 23);
            dateTimePicker_Pick.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(32, 411);
            label7.Name = "label7";
            label7.Size = new Size(117, 18);
            label7.TabIndex = 17;
            label7.Text = "Pickup Date : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_Paymet);
            panel1.Controls.Add(btn_PAYSUBMIT);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_HomeAdd);
            panel1.Controls.Add(dateTimePicker_Pick);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_SchoolLastAttend);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_AddressLAst);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmb_ReqFor);
            panel1.Controls.Add(cmb_StudentStatus);
            panel1.Controls.Add(cmb_Purpose);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(205, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 575);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.BackColor = Color.Goldenrod;
            guna2TrackBar1.Enabled = false;
            guna2TrackBar1.FillColor = Color.Yellow;
            guna2TrackBar1.Location = new Point(372, 659);
            guna2TrackBar1.Maximum = 4;
            guna2TrackBar1.Minimum = 1;
            guna2TrackBar1.Name = "guna2TrackBar1";
            guna2TrackBar1.Size = new Size(565, 24);
            guna2TrackBar1.TabIndex = 31;
            guna2TrackBar1.ThumbColor = Color.Yellow;
            guna2TrackBar1.Value = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(684, 631);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 32;
            label9.Text = "Payment Proceed";
            // 
            // StudentForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label9);
            Controls.Add(guna2TrackBar1);
            Controls.Add(panel1);
            Name = "StudentForm2";
            Text = "Student2";
            Load += Student2_Load;
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
        private TextBox txt_HomeAdd;
        private TextBox txt_SchoolLastAttend;
        private TextBox txt_AddressLAst;
        private ComboBox cmb_StudentStatus;
        private ComboBox cmb_Purpose;
        private ComboBox cmb_ReqFor;
        private Label lbl_Paymet;
        private Button btn_PAYSUBMIT;
        private Button button1;
        private DateTimePicker dateTimePicker_Pick;
        private Label label7;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Label label9;
    }
}