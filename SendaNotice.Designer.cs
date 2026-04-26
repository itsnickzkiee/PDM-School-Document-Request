namespace Group5
{
    partial class SendaNotice
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
            txt_Notice = new TextBox();
            btn_Submit = new Button();
            btn_Cancel = new Button();
            lbl_Informa = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            lblFullName = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            oVERVIEWToolStripMenuItem = new ToolStripMenuItem();
            sTATToolStripMenuItem = new ToolStripMenuItem();
            aBOUTUSToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem1 = new ToolStripMenuItem();
            rECEIPTToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            lblAttachmentStatus = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(239, 170);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 0;
            label1.Text = "Write your Notice: ";
            label1.Click += label1_Click;
            // 
            // txt_Notice
            // 
            txt_Notice.Location = new Point(142, 211);
            txt_Notice.Multiline = true;
            txt_Notice.Name = "txt_Notice";
            txt_Notice.Size = new Size(344, 78);
            txt_Notice.TabIndex = 1;
            txt_Notice.TextChanged += txt_Notice_TextChanged;
            // 
            // btn_Submit
            // 
            btn_Submit.BackColor = Color.Orange;
            btn_Submit.FlatStyle = FlatStyle.Popup;
            btn_Submit.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_Submit.Location = new Point(142, 452);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(130, 68);
            btn_Submit.TabIndex = 2;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = false;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.Orange;
            btn_Cancel.FlatStyle = FlatStyle.Popup;
            btn_Cancel.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_Cancel.Location = new Point(379, 452);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(126, 68);
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += button2_Click;
            // 
            // lbl_Informa
            // 
            lbl_Informa.AutoSize = true;
            lbl_Informa.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Informa.ForeColor = Color.SaddleBrown;
            lbl_Informa.Location = new Point(250, 21);
            lbl_Informa.Name = "lbl_Informa";
            lbl_Informa.Size = new Size(136, 31);
            lbl_Informa.TabIndex = 4;
            lbl_Informa.Text = "Information";
            lbl_Informa.Click += lbl_Informa_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(239, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(208, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lblFullName.ForeColor = Color.SaddleBrown;
            lblFullName.Location = new Point(129, 70);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(85, 17);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(164, 122);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 11;
            label2.Text = "Email:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 25);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oVERVIEWToolStripMenuItem, sTATToolStripMenuItem, aBOUTUSToolStripMenuItem, lOGOUTToolStripMenuItem, lOGOUTToolStripMenuItem1, rECEIPTToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(64, 21);
            mENUToolStripMenuItem.Text = "MENU";
            mENUToolStripMenuItem.Click += mENUToolStripMenuItem_Click;
            // 
            // oVERVIEWToolStripMenuItem
            // 
            oVERVIEWToolStripMenuItem.Name = "oVERVIEWToolStripMenuItem";
            oVERVIEWToolStripMenuItem.Size = new Size(162, 22);
            oVERVIEWToolStripMenuItem.Text = "OVERVIEW";
            oVERVIEWToolStripMenuItem.Click += oVERVIEWToolStripMenuItem_Click;
            // 
            // sTATToolStripMenuItem
            // 
            sTATToolStripMenuItem.Name = "sTATToolStripMenuItem";
            sTATToolStripMenuItem.Size = new Size(162, 22);
            sTATToolStripMenuItem.Text = "STATUS";
            sTATToolStripMenuItem.Click += sTATToolStripMenuItem_Click;
            // 
            // aBOUTUSToolStripMenuItem
            // 
            aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            aBOUTUSToolStripMenuItem.Size = new Size(162, 22);
            aBOUTUSToolStripMenuItem.Text = "ANALYTICS";
            aBOUTUSToolStripMenuItem.Click += aBOUTUSToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(162, 22);
            lOGOUTToolStripMenuItem.Text = "ABOUT US";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem1
            // 
            lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            lOGOUTToolStripMenuItem1.Size = new Size(162, 22);
            lOGOUTToolStripMenuItem1.Text = "LOG OUT";
            lOGOUTToolStripMenuItem1.Click += lOGOUTToolStripMenuItem1_Click;
            // 
            // rECEIPTToolStripMenuItem
            // 
            rECEIPTToolStripMenuItem.Name = "rECEIPTToolStripMenuItem";
            rECEIPTToolStripMenuItem.Size = new Size(162, 22);
            rECEIPTToolStripMenuItem.Text = "RECEIPT";
            rECEIPTToolStripMenuItem.Click += rECEIPTToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            button1.Location = new Point(250, 357);
            button1.Name = "button1";
            button1.Size = new Size(152, 42);
            button1.TabIndex = 14;
            button1.Text = "Send Attachment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblAttachmentStatus
            // 
            lblAttachmentStatus.AutoSize = true;
            lblAttachmentStatus.Font = new Font("Arial Rounded MT Bold", 11.25F);
            lblAttachmentStatus.Location = new Point(262, 311);
            lblAttachmentStatus.Name = "lblAttachmentStatus";
            lblAttachmentStatus.Size = new Size(133, 17);
            lblAttachmentStatus.TabIndex = 15;
            lblAttachmentStatus.Text = "No File Attached.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(lbl_Informa);
            panel1.Controls.Add(btn_Cancel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblAttachmentStatus);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(btn_Submit);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Notice);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(416, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 572);
            panel1.TabIndex = 16;
            // 
            // SendaNotice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SendaNotice";
            Text = "Notice";
            Load += Form6_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Notice;
        private Button btn_Submit;
        private Button btn_Cancel;
        private Label lbl_Informa;
        private Label label3;
        private TextBox txtStudid;
        private TextBox txtFullName;
        private TextBox txtSemester;
        private TextBox txtEmail;
        private Label lblFullName;
        private Label label2;
        private Label lblCourse;
        private TextBox txtYear;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem oVERVIEWToolStripMenuItem;
        private ToolStripMenuItem sTATToolStripMenuItem;
        private ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private Button button1;
        private Label lblAttachmentStatus;
        private ToolStripMenuItem rECEIPTToolStripMenuItem;
        private Panel panel1;
    }
}