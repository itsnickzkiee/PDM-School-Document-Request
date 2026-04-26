
namespace Group5
{
    partial class AdminLogin
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
            txt_USERNAME = new TextBox();
            txt_PASSWORD = new TextBox();
            btn_LOGIN = new Button();
            btn_CANCEL = new Button();
            btn_BACK = new Button();
            chk_ShowPass = new CheckBox();
            lblLockoutCountdown = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(52, 109);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "USERNAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(52, 163);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD:";
            label2.Click += label2_Click;
            // 
            // txt_USERNAME
            // 
            txt_USERNAME.Location = new Point(160, 106);
            txt_USERNAME.Name = "txt_USERNAME";
            txt_USERNAME.Size = new Size(260, 23);
            txt_USERNAME.TabIndex = 2;
            // 
            // txt_PASSWORD
            // 
            txt_PASSWORD.Location = new Point(160, 160);
            txt_PASSWORD.Name = "txt_PASSWORD";
            txt_PASSWORD.Size = new Size(260, 23);
            txt_PASSWORD.TabIndex = 3;
            txt_PASSWORD.UseSystemPasswordChar = true;
            // 
            // btn_LOGIN
            // 
            btn_LOGIN.BackColor = Color.Orange;
            btn_LOGIN.FlatStyle = FlatStyle.Popup;
            btn_LOGIN.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_LOGIN.Location = new Point(211, 275);
            btn_LOGIN.Name = "btn_LOGIN";
            btn_LOGIN.Size = new Size(75, 35);
            btn_LOGIN.TabIndex = 4;
            btn_LOGIN.Text = "LOG IN";
            btn_LOGIN.UseVisualStyleBackColor = false;
            btn_LOGIN.Click += btn_LOGIN_Click;
            // 
            // btn_CANCEL
            // 
            btn_CANCEL.BackColor = Color.Orange;
            btn_CANCEL.FlatStyle = FlatStyle.Popup;
            btn_CANCEL.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_CANCEL.Location = new Point(281, 337);
            btn_CANCEL.Name = "btn_CANCEL";
            btn_CANCEL.Size = new Size(83, 43);
            btn_CANCEL.TabIndex = 5;
            btn_CANCEL.Text = "CANCEL";
            btn_CANCEL.UseVisualStyleBackColor = false;
            btn_CANCEL.Click += button2_Click;
            // 
            // btn_BACK
            // 
            btn_BACK.BackColor = Color.Orange;
            btn_BACK.FlatStyle = FlatStyle.Popup;
            btn_BACK.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_BACK.Location = new Point(141, 337);
            btn_BACK.Name = "btn_BACK";
            btn_BACK.Size = new Size(75, 43);
            btn_BACK.TabIndex = 6;
            btn_BACK.Text = "BACK";
            btn_BACK.UseVisualStyleBackColor = false;
            btn_BACK.Click += btn_BACK_Click;
            // 
            // chk_ShowPass
            // 
            chk_ShowPass.AutoSize = true;
            chk_ShowPass.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_ShowPass.Location = new Point(202, 200);
            chk_ShowPass.Name = "chk_ShowPass";
            chk_ShowPass.Size = new Size(97, 20);
            chk_ShowPass.TabIndex = 7;
            chk_ShowPass.Text = "Show Password";
            chk_ShowPass.UseVisualStyleBackColor = true;
            chk_ShowPass.CheckedChanged += chk_ShowPass_CheckedChanged;
            // 
            // lblLockoutCountdown
            // 
            lblLockoutCountdown.AutoSize = true;
            lblLockoutCountdown.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLockoutCountdown.Location = new Point(211, 237);
            lblLockoutCountdown.Name = "lblLockoutCountdown";
            lblLockoutCountdown.Size = new Size(48, 18);
            lblLockoutCountdown.TabIndex = 8;
            lblLockoutCountdown.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(txt_USERNAME);
            panel1.Controls.Add(btn_CANCEL);
            panel1.Controls.Add(btn_BACK);
            panel1.Controls.Add(lblLockoutCountdown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chk_ShowPass);
            panel1.Controls.Add(txt_PASSWORD);
            panel1.Controls.Add(btn_LOGIN);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(468, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 445);
            panel1.TabIndex = 9;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Name = "AdminLogin";
            Text = "Login";
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_USERNAME;
        private TextBox txt_PASSWORD;
        private Button btn_LOGIN;
        private Button btn_CANCEL;
        private Button btn_BACK;
        private CheckBox chk_ShowPass;
        private Label lblLockoutCountdown;
        private Panel panel1;
    }
}