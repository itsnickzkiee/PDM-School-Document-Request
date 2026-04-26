namespace Group5
{
    partial class AddRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRequest));
            btn_Req = new Button();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            lOGINToolStripMenuItem = new ToolStripMenuItem();
            lblCaptcha = new Label();
            chkNotRobot = new CheckBox();
            txtCaptchaAnswer = new TextBox();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_SchoolYear = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Req
            // 
            btn_Req.BackColor = Color.Orange;
            btn_Req.FlatStyle = FlatStyle.Popup;
            btn_Req.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Req.Location = new Point(564, 369);
            btn_Req.Name = "btn_Req";
            btn_Req.Size = new Size(228, 79);
            btn_Req.TabIndex = 0;
            btn_Req.Text = "Add Request";
            btn_Req.UseVisualStyleBackColor = false;
            btn_Req.Click += btn_Req_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lOGINToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(64, 21);
            mENUToolStripMenuItem.Text = "MENU";
            // 
            // lOGINToolStripMenuItem
            // 
            lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            lOGINToolStripMenuItem.Size = new Size(129, 22);
            lOGINToolStripMenuItem.Text = "LOG IN";
            lOGINToolStripMenuItem.Click += lOGINToolStripMenuItem_Click;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.BackColor = Color.Transparent;
            lblCaptcha.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaptcha.Location = new Point(628, 472);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(71, 24);
            lblCaptcha.TabIndex = 2;
            lblCaptcha.Text = "label1";
            lblCaptcha.Click += lblCaptcha_Click;
            // 
            // chkNotRobot
            // 
            chkNotRobot.AutoSize = true;
            chkNotRobot.BackColor = Color.Transparent;
            chkNotRobot.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkNotRobot.Location = new Point(567, 568);
            chkNotRobot.Name = "chkNotRobot";
            chkNotRobot.Size = new Size(196, 32);
            chkNotRobot.TabIndex = 5;
            chkNotRobot.Text = "Im not a Robot";
            chkNotRobot.UseVisualStyleBackColor = false;
            chkNotRobot.CheckedChanged += chkNotRobot_CheckedChanged;
            // 
            // txtCaptchaAnswer
            // 
            txtCaptchaAnswer.Location = new Point(567, 518);
            txtCaptchaAnswer.Name = "txtCaptchaAnswer";
            txtCaptchaAnswer.Size = new Size(196, 23);
            txtCaptchaAnswer.TabIndex = 6;
            txtCaptchaAnswer.TextChanged += txtCaptchaAnswer_TextChanged;
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.BackColor = Color.Goldenrod;
            guna2TrackBar1.Enabled = false;
            guna2TrackBar1.FillColor = Color.Yellow;
            guna2TrackBar1.Location = new Point(374, 652);
            guna2TrackBar1.Maximum = 4;
            guna2TrackBar1.Minimum = 1;
            guna2TrackBar1.Name = "guna2TrackBar1";
            guna2TrackBar1.Size = new Size(565, 24);
            guna2TrackBar1.TabIndex = 7;
            guna2TrackBar1.ThumbColor = Color.Yellow;
            guna2TrackBar1.Value = 4;
            guna2TrackBar1.Scroll += guna2TrackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 72);
            label1.Name = "label1";
            label1.Size = new Size(709, 57);
            label1.TabIndex = 8;
            label1.Text = "Pambayang Dalubhasaan ng Marilao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(567, 139);
            label2.Name = "label2";
            label2.Size = new Size(244, 38);
            label2.TabIndex = 9;
            label2.Text = "Document Request";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(567, 205);
            label3.Name = "label3";
            label3.Size = new Size(55, 38);
            label3.TabIndex = 10;
            label3.Text = "A.Y";
            // 
            // lbl_SchoolYear
            // 
            lbl_SchoolYear.AutoSize = true;
            lbl_SchoolYear.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SchoolYear.Location = new Point(637, 205);
            lbl_SchoolYear.Name = "lbl_SchoolYear";
            lbl_SchoolYear.Size = new Size(155, 38);
            lbl_SchoolYear.TabIndex = 11;
            lbl_SchoolYear.Text = "2025-2026";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download_removebg_preview;
            pictureBox1.Location = new Point(152, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 152);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1069, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 152);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(374, 624);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 14;
            label5.Text = "Start";
            // 
            // AddRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_SchoolYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2TrackBar1);
            Controls.Add(txtCaptchaAnswer);
            Controls.Add(chkNotRobot);
            Controls.Add(lblCaptcha);
            Controls.Add(btn_Req);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddRequest";
            Text = "Add Request";
            Load += AddRequest_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Req;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private Label lblCaptcha;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Button button1;
        private CheckBox chkNotRobot;
        private TextBox txtCaptchaAnswer;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_SchoolYear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
    }
}