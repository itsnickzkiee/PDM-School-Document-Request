
namespace Group5
{
    partial class PendingStatus
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
            dataGridPending = new DataGridView();
            btn_EDIT = new Button();
            btn_Exit = new Button();
            cmbCourseFilter = new ComboBox();
            cmbYearFilter = new ComboBox();
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            oVERVIEWToolStripMenuItem = new ToolStripMenuItem();
            sENDANOTICEToolStripMenuItem = new ToolStripMenuItem();
            rCEIPTToolStripMenuItem = new ToolStripMenuItem();
            aNALYTICSToolStripMenuItem = new ToolStripMenuItem();
            aBOUTUSToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            txt_SearchName = new TextBox();
            btn_Update = new Button();
            btn_Remove = new Button();
            btn_Archive = new Button();
            btn_Move = new Button();
            lblNoRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPending).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPending
            // 
            dataGridPending.AllowUserToAddRows = false;
            dataGridPending.AllowUserToDeleteRows = false;
            dataGridPending.BackgroundColor = Color.Wheat;
            dataGridPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPending.Location = new Point(51, 87);
            dataGridPending.MultiSelect = false;
            dataGridPending.Name = "dataGridPending";
            dataGridPending.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridPending.Size = new Size(1183, 558);
            dataGridPending.TabIndex = 0;
            dataGridPending.CellContentClick += dataGridPending_CellContentClick;
            dataGridPending.SelectionChanged += dataGridPending_SelectionChanged;
            // 
            // btn_EDIT
            // 
            btn_EDIT.BackColor = Color.Orange;
            btn_EDIT.FlatStyle = FlatStyle.Popup;
            btn_EDIT.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_EDIT.Location = new Point(724, 49);
            btn_EDIT.Name = "btn_EDIT";
            btn_EDIT.Size = new Size(101, 32);
            btn_EDIT.TabIndex = 4;
            btn_EDIT.Text = "EDIT";
            btn_EDIT.UseVisualStyleBackColor = false;
            btn_EDIT.Click += btn_EDIT_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(892, 651);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(114, 52);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // cmbCourseFilter
            // 
            cmbCourseFilter.Font = new Font("Arial Rounded MT Bold", 11.25F);
            cmbCourseFilter.FormattingEnabled = true;
            cmbCourseFilter.Location = new Point(370, 58);
            cmbCourseFilter.Name = "cmbCourseFilter";
            cmbCourseFilter.Size = new Size(142, 25);
            cmbCourseFilter.TabIndex = 9;
            cmbCourseFilter.Text = "Filter by Course";
            cmbCourseFilter.SelectedIndexChanged += cmbCourseFilter_SelectedIndexChanged;
            // 
            // cmbYearFilter
            // 
            cmbYearFilter.Font = new Font("Arial Rounded MT Bold", 11.25F);
            cmbYearFilter.FormattingEnabled = true;
            cmbYearFilter.Location = new Point(518, 58);
            cmbYearFilter.Name = "cmbYearFilter";
            cmbYearFilter.Size = new Size(132, 25);
            cmbYearFilter.TabIndex = 10;
            cmbYearFilter.Text = "Filter by Year";
            cmbYearFilter.SelectedIndexChanged += cmvYearFilter_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 25);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oVERVIEWToolStripMenuItem, sENDANOTICEToolStripMenuItem, aNALYTICSToolStripMenuItem, aBOUTUSToolStripMenuItem, lOGOUTToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(64, 21);
            mENUToolStripMenuItem.Text = "MENU";
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
            sENDANOTICEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rCEIPTToolStripMenuItem });
            sENDANOTICEToolStripMenuItem.Name = "sENDANOTICEToolStripMenuItem";
            sENDANOTICEToolStripMenuItem.Size = new Size(195, 22);
            sENDANOTICEToolStripMenuItem.Text = "SEND A NOTICE";
            sENDANOTICEToolStripMenuItem.Click += sENDANOTICEToolStripMenuItem_Click;
            // 
            // rCEIPTToolStripMenuItem
            // 
            rCEIPTToolStripMenuItem.Name = "rCEIPTToolStripMenuItem";
            rCEIPTToolStripMenuItem.Size = new Size(142, 22);
            rCEIPTToolStripMenuItem.Text = "RECEIPT";
            rCEIPTToolStripMenuItem.Click += rCEIPTToolStripMenuItem_Click;
            // 
            // aNALYTICSToolStripMenuItem
            // 
            aNALYTICSToolStripMenuItem.Name = "aNALYTICSToolStripMenuItem";
            aNALYTICSToolStripMenuItem.Size = new Size(195, 22);
            aNALYTICSToolStripMenuItem.Text = "ANALYTICS";
            aNALYTICSToolStripMenuItem.Click += aNALYTICSToolStripMenuItem_Click;
            // 
            // aBOUTUSToolStripMenuItem
            // 
            aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            aBOUTUSToolStripMenuItem.Size = new Size(195, 22);
            aBOUTUSToolStripMenuItem.Text = "ABOUT US";
            aBOUTUSToolStripMenuItem.Click += aBOUTUSToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(195, 22);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // txt_SearchName
            // 
            txt_SearchName.Location = new Point(51, 58);
            txt_SearchName.Name = "txt_SearchName";
            txt_SearchName.Size = new Size(313, 23);
            txt_SearchName.TabIndex = 12;
            txt_SearchName.TextChanged += txt_SearchName_TextChanged;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Orange;
            btn_Update.FlatStyle = FlatStyle.Popup;
            btn_Update.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_Update.Location = new Point(831, 49);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(101, 32);
            btn_Update.TabIndex = 13;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.Orange;
            btn_Remove.FlatStyle = FlatStyle.Popup;
            btn_Remove.Font = new Font("Arial Rounded MT Bold", 11.25F);
            btn_Remove.Location = new Point(938, 49);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(101, 32);
            btn_Remove.TabIndex = 14;
            btn_Remove.Text = "REMOVE";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Archive
            // 
            btn_Archive.Location = new Point(1055, 49);
            btn_Archive.Name = "btn_Archive";
            btn_Archive.Size = new Size(109, 32);
            btn_Archive.TabIndex = 15;
            btn_Archive.Text = "ARCHIVE";
            btn_Archive.UseVisualStyleBackColor = true;
            btn_Archive.Click += btn_Archive_Click;
            // 
            // btn_Move
            // 
            btn_Move.Location = new Point(1034, 651);
            btn_Move.Name = "btn_Move";
            btn_Move.Size = new Size(175, 52);
            btn_Move.TabIndex = 16;
            btn_Move.Text = "Move to Archive";
            btn_Move.UseVisualStyleBackColor = true;
            btn_Move.Click += btn_Move_Click;
            // 
            // lblNoRecords
            // 
            lblNoRecords.AutoSize = true;
            lblNoRecords.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoRecords.Location = new Point(641, 260);
            lblNoRecords.Name = "lblNoRecords";
            lblNoRecords.Size = new Size(0, 28);
            lblNoRecords.TabIndex = 17;
            lblNoRecords.Visible = false;
            // 
            // PendingStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblNoRecords);
            Controls.Add(btn_Move);
            Controls.Add(btn_Archive);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Update);
            Controls.Add(txt_SearchName);
            Controls.Add(cmbYearFilter);
            Controls.Add(cmbCourseFilter);
            Controls.Add(btn_Exit);
            Controls.Add(btn_EDIT);
            Controls.Add(dataGridPending);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PendingStatus";
            Text = "Pending Stats";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPending).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cmbYearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private DataGridView dataGridPending;
        private DataGridViewTextBoxColumn colReceiveInfo;
        private DataGridViewCheckBoxColumn colMarkedDone;
        private DataGridViewTextBoxColumn colReceiveStatus;
        private Button btn_EDIT;
        private Button btn_Exit;
        private ComboBox cmbCourseFilter;
        private ComboBox cmbYearFilter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem oVERVIEWToolStripMenuItem;
        private ToolStripMenuItem sENDANOTICEToolStripMenuItem;
        private ToolStripMenuItem aNALYTICSToolStripMenuItem;
        private ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private TextBox txt_SearchName;
        private Button btn_Update;
        private Button btn_Remove;
        private Button btn_Archive;
        private Button btn_Move;
        private ToolStripMenuItem rCEIPTToolStripMenuItem;
        private Label lblNoRecords;
    }
}