namespace Group5
{
    partial class Analytics
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            oVERVIEWToolStripMenuItem = new ToolStripMenuItem();
            sENDANOTICEToolStripMenuItem = new ToolStripMenuItem();
            aBOUTUSToolStripMenuItem = new ToolStripMenuItem();
            rECEIPTToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            lblTotal = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblPending = new Label();
            label = new Label();
            panel3 = new Panel();
            lblCompleted = new Label();
            label4 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_Load = new Button();
            dataGridView1 = new DataGridView();
            numberOfRequestBindingSource = new BindingSource(components);
            dataSetBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            btn_save = new Button();
            cmbYear = new ComboBox();
            cmbChartType = new ComboBox();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfRequestBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(640, 35);
            label1.Name = "label1";
            label1.Size = new Size(172, 40);
            label1.TabIndex = 0;
            label1.Text = "ANALYTICS";
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
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oVERVIEWToolStripMenuItem, sENDANOTICEToolStripMenuItem, aBOUTUSToolStripMenuItem, lOGOUTToolStripMenuItem, lOGOUTToolStripMenuItem1 });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(64, 21);
            mENUToolStripMenuItem.Text = "MENU";
            mENUToolStripMenuItem.Click += mENUToolStripMenuItem_Click;
            // 
            // oVERVIEWToolStripMenuItem
            // 
            oVERVIEWToolStripMenuItem.Name = "oVERVIEWToolStripMenuItem";
            oVERVIEWToolStripMenuItem.Size = new Size(195, 22);
            oVERVIEWToolStripMenuItem.Text = "OVERVIEW";
            oVERVIEWToolStripMenuItem.Click += oVERVIEWToolStripMenuItem_Click;
            // 
            // sENDANOTICEToolStripMenuItem
            // 
            sENDANOTICEToolStripMenuItem.Name = "sENDANOTICEToolStripMenuItem";
            sENDANOTICEToolStripMenuItem.Size = new Size(195, 22);
            sENDANOTICEToolStripMenuItem.Text = "STATUS";
            sENDANOTICEToolStripMenuItem.Click += sENDANOTICEToolStripMenuItem_Click;
            // 
            // aBOUTUSToolStripMenuItem
            // 
            aBOUTUSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rECEIPTToolStripMenuItem });
            aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            aBOUTUSToolStripMenuItem.Size = new Size(195, 22);
            aBOUTUSToolStripMenuItem.Text = "SEND A NOTICE";
            aBOUTUSToolStripMenuItem.Click += aBOUTUSToolStripMenuItem_Click;
            // 
            // rECEIPTToolStripMenuItem
            // 
            rECEIPTToolStripMenuItem.Name = "rECEIPTToolStripMenuItem";
            rECEIPTToolStripMenuItem.Size = new Size(142, 22);
            rECEIPTToolStripMenuItem.Text = "RECEIPT";
            rECEIPTToolStripMenuItem.Click += rECEIPTToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(195, 22);
            lOGOUTToolStripMenuItem.Text = "ABOUT US";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem1
            // 
            lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            lOGOUTToolStripMenuItem1.Size = new Size(195, 22);
            lOGOUTToolStripMenuItem1.Text = "LOG OUT";
            lOGOUTToolStripMenuItem1.Click += lOGOUTToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            panel1.Location = new Point(963, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 138);
            panel1.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(55, 68);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 17);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 0;
            label2.Text = "Total: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(lblPending);
            panel2.Controls.Add(label);
            panel2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            panel2.Location = new Point(344, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 138);
            panel2.TabIndex = 3;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(50, 68);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(61, 25);
            lblPending.TabIndex = 4;
            lblPending.Text = "label3";
            lblPending.Click += lblPending_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(7, 17);
            label.Name = "label";
            label.Size = new Size(148, 17);
            label.TabIndex = 1;
            label.Text = "Pending Requests: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(lblCompleted);
            panel3.Controls.Add(label4);
            panel3.Font = new Font("Arial Rounded MT Bold", 11.25F);
            panel3.Location = new Point(642, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 138);
            panel3.TabIndex = 4;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(62, 68);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(61, 25);
            lblCompleted.TabIndex = 4;
            lblCompleted.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(167, 17);
            label4.TabIndex = 1;
            label4.Text = "Completed Requests: ";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.Orange;
            btn_Load.FlatStyle = FlatStyle.Popup;
            btn_Load.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_Load.Location = new Point(1069, 629);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(91, 42);
            btn_Load.TabIndex = 6;
            btn_Load.Text = "LOAD";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.Khaki;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(978, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(356, 289);
            dataGridView1.TabIndex = 7;
            // 
            // numberOfRequestBindingSource
            // 
            numberOfRequestBindingSource.DataMember = "Number of Request";
            numberOfRequestBindingSource.DataSource = dataSetBindingSource;
            // 
            // dataSetBindingSource
            // 
            dataSetBindingSource.DataSource = typeof(DataSet);
            dataSetBindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox1.Location = new Point(44, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Orange;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_save.Location = new Point(1191, 629);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(89, 42);
            btn_save.TabIndex = 9;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click_1;
            // 
            // cmbYear
            // 
            cmbYear.BackColor = Color.Wheat;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(978, 295);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(160, 23);
            cmbYear.TabIndex = 10;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged_1;
            // 
            // cmbChartType
            // 
            cmbChartType.BackColor = Color.Wheat;
            cmbChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChartType.FormattingEnabled = true;
            cmbChartType.Location = new Point(1169, 295);
            cmbChartType.Name = "cmbChartType";
            cmbChartType.Size = new Size(165, 23);
            cmbChartType.TabIndex = 11;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.BackColor = Color.FromArgb(255, 255, 192);
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2ProgressBar1.FillColor = Color.DarkRed;
            guna2ProgressBar1.Location = new Point(233, 472);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ProgressColor = Color.Yellow;
            guna2ProgressBar1.ProgressColor2 = Color.FromArgb(255, 255, 128);
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(425, 30);
            guna2ProgressBar1.TabIndex = 13;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ProgressBar1.Visible = false;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(cmbChartType);
            Controls.Add(cmbYear);
            Controls.Add(btn_save);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Load);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Analytics";
            Text = "Form9";
            Load += Analytics_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfRequestBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem oVERVIEWToolStripMenuItem;
        private ToolStripMenuItem sENDANOTICEToolStripMenuItem;
        private ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private ToolStripMenuItem rECEIPTToolStripMenuItem;
        private Panel panel1;
        private Label lblTotal;
        private Label label2;
        private Panel panel2;
        private Label lblPending;
        private Label label;
        private Panel panel3;
        private Label lblCompleted;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_Load;
        private DataGridView dataGridView1;
        private BindingSource numberOfRequestBindingSource;
        private BindingSource dataSetBindingSource;
        private PictureBox pictureBox1;
        private Button btn_save;
        private ComboBox cmbYear;
        private ComboBox cmbChartType;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}