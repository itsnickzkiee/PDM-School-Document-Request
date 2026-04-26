namespace Group5
{
    partial class Receipt
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
            txt_studno = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbl_Name = new Label();
            lbl_Course = new Label();
            lbl_Purpose = new Label();
            lbl_Reqfor = new Label();
            lbl_amount = new Label();
            lbl_issued = new Label();
            lbl_pickupdate = new Label();
            btn_SendGmail = new Button();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            oVERBOARDToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lbl_YearLevel = new Label();
            label10 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(126, 28);
            label1.Name = "label1";
            label1.Size = new Size(203, 18);
            label1.TabIndex = 0;
            label1.Text = "Official Payment Receipt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(75, 124);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(49, 70);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Student No:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(67, 156);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 3;
            label4.Text = "Course:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(67, 218);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 4;
            label5.Text = "Purpose:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(38, 253);
            label6.Name = "label6";
            label6.Size = new Size(111, 18);
            label6.TabIndex = 5;
            label6.Text = "Request For:";
            label6.Click += label6_Click;
            // 
            // txt_studno
            // 
            txt_studno.ForeColor = Color.SaddleBrown;
            txt_studno.Location = new Point(138, 67);
            txt_studno.Name = "txt_studno";
            txt_studno.Size = new Size(238, 23);
            txt_studno.TabIndex = 6;
            txt_studno.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(43, 318);
            label7.Name = "label7";
            label7.Size = new Size(108, 18);
            label7.TabIndex = 7;
            label7.Text = "Date Issued:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(42, 350);
            label8.Name = "label8";
            label8.Size = new Size(109, 18);
            label8.TabIndex = 8;
            label8.Text = "Pickup Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(38, 285);
            label9.Name = "label9";
            label9.Size = new Size(113, 18);
            label9.TabIndex = 9;
            label9.Text = "Amount Pay :";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.ForeColor = Color.SaddleBrown;
            lbl_Name.Location = new Point(166, 127);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(0, 15);
            lbl_Name.TabIndex = 10;
            // 
            // lbl_Course
            // 
            lbl_Course.AutoSize = true;
            lbl_Course.ForeColor = Color.SaddleBrown;
            lbl_Course.Location = new Point(166, 156);
            lbl_Course.Name = "lbl_Course";
            lbl_Course.Size = new Size(0, 15);
            lbl_Course.TabIndex = 11;
            lbl_Course.Click += lbl_Course_Click;
            // 
            // lbl_Purpose
            // 
            lbl_Purpose.AutoSize = true;
            lbl_Purpose.ForeColor = Color.SaddleBrown;
            lbl_Purpose.Location = new Point(166, 218);
            lbl_Purpose.Name = "lbl_Purpose";
            lbl_Purpose.Size = new Size(0, 15);
            lbl_Purpose.TabIndex = 12;
            lbl_Purpose.Click += lbl_Purpose_Click;
            // 
            // lbl_Reqfor
            // 
            lbl_Reqfor.AutoSize = true;
            lbl_Reqfor.ForeColor = Color.SaddleBrown;
            lbl_Reqfor.Location = new Point(166, 253);
            lbl_Reqfor.Name = "lbl_Reqfor";
            lbl_Reqfor.Size = new Size(0, 15);
            lbl_Reqfor.TabIndex = 13;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.ForeColor = Color.SaddleBrown;
            lbl_amount.Location = new Point(166, 288);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(0, 15);
            lbl_amount.TabIndex = 14;
            lbl_amount.Click += lbl_amount_Click;
            // 
            // lbl_issued
            // 
            lbl_issued.AutoSize = true;
            lbl_issued.ForeColor = Color.SaddleBrown;
            lbl_issued.Location = new Point(166, 318);
            lbl_issued.Name = "lbl_issued";
            lbl_issued.Size = new Size(0, 15);
            lbl_issued.TabIndex = 15;
            // 
            // lbl_pickupdate
            // 
            lbl_pickupdate.AutoSize = true;
            lbl_pickupdate.ForeColor = Color.SaddleBrown;
            lbl_pickupdate.Location = new Point(166, 353);
            lbl_pickupdate.Name = "lbl_pickupdate";
            lbl_pickupdate.Size = new Size(0, 15);
            lbl_pickupdate.TabIndex = 16;
            // 
            // btn_SendGmail
            // 
            btn_SendGmail.BackColor = Color.Orange;
            btn_SendGmail.FlatStyle = FlatStyle.Popup;
            btn_SendGmail.ForeColor = Color.Black;
            btn_SendGmail.Location = new Point(138, 437);
            btn_SendGmail.Name = "btn_SendGmail";
            btn_SendGmail.Size = new Size(139, 54);
            btn_SendGmail.TabIndex = 17;
            btn_SendGmail.Text = "Generate to PDF";
            btn_SendGmail.UseVisualStyleBackColor = false;
            btn_SendGmail.Click += btn_SendGmail_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 26);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oVERBOARDToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(68, 22);
            mENUToolStripMenuItem.Text = "MENU";
            mENUToolStripMenuItem.Click += mENUToolStripMenuItem_Click;
            // 
            // oVERBOARDToolStripMenuItem
            // 
            oVERBOARDToolStripMenuItem.Name = "oVERBOARDToolStripMenuItem";
            oVERBOARDToolStripMenuItem.Size = new Size(184, 22);
            oVERBOARDToolStripMenuItem.Text = "OVERBOARD";
            oVERBOARDToolStripMenuItem.Click += oVERBOARDToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lbl_YearLevel);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txt_studno);
            panel1.Controls.Add(btn_SendGmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lbl_pickupdate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_issued);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lbl_amount);
            panel1.Controls.Add(lbl_Name);
            panel1.Controls.Add(lbl_Reqfor);
            panel1.Controls.Add(lbl_Course);
            panel1.Controls.Add(lbl_Purpose);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(528, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 520);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_YearLevel
            // 
            lbl_YearLevel.AutoSize = true;
            lbl_YearLevel.ForeColor = Color.SaddleBrown;
            lbl_YearLevel.Location = new Point(166, 191);
            lbl_YearLevel.Name = "lbl_YearLevel";
            lbl_YearLevel.Size = new Size(0, 15);
            lbl_YearLevel.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SaddleBrown;
            label10.Location = new Point(41, 188);
            label10.Name = "label10";
            label10.Size = new Size(97, 18);
            label10.TabIndex = 18;
            label10.Text = "Year Level:";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 671);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private TextBox txt_studno;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_Name;
        private Label lbl_Course;
        private Label lbl_Purpose;
        private Label lbl_Reqfor;
        private Label lbl_amount;
        private Label lbl_issued;
        private Label lbl_pickupdate;
        private Button btn_SendGmail;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem oVERBOARDToolStripMenuItem;
        private Label lbl_YearLevel;
        private Label label10;
    }
}