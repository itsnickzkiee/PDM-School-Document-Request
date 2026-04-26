namespace Group5
{
    partial class AboutUs
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
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            oVERVIEWToolStripMenuItem = new ToolStripMenuItem();
            sENDToolStripMenuItem = new ToolStripMenuItem();
            sENDANOTICEToolStripMenuItem = new ToolStripMenuItem();
            rECEIPTToolStripMenuItem = new ToolStripMenuItem();
            aNALYTICSToolStripMenuItem = new ToolStripMenuItem();
            aBOUTUSToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 152);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "About us";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oVERVIEWToolStripMenuItem, sENDToolStripMenuItem, sENDANOTICEToolStripMenuItem, aNALYTICSToolStripMenuItem, aBOUTUSToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(64, 21);
            mENUToolStripMenuItem.Text = "MENU";
            // 
            // oVERVIEWToolStripMenuItem
            // 
            oVERVIEWToolStripMenuItem.Name = "oVERVIEWToolStripMenuItem";
            oVERVIEWToolStripMenuItem.Size = new Size(157, 22);
            oVERVIEWToolStripMenuItem.Text = "OVERVIEW";
            oVERVIEWToolStripMenuItem.Click += oVERVIEWToolStripMenuItem_Click;
            // 
            // sENDToolStripMenuItem
            // 
            sENDToolStripMenuItem.Name = "sENDToolStripMenuItem";
            sENDToolStripMenuItem.Size = new Size(157, 22);
            sENDToolStripMenuItem.Text = "STATUS";
            sENDToolStripMenuItem.Click += sENDToolStripMenuItem_Click;
            // 
            // sENDANOTICEToolStripMenuItem
            // 
            sENDANOTICEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rECEIPTToolStripMenuItem });
            sENDANOTICEToolStripMenuItem.Name = "sENDANOTICEToolStripMenuItem";
            sENDANOTICEToolStripMenuItem.Size = new Size(157, 22);
            sENDANOTICEToolStripMenuItem.Text = "SEND A NOTICE";
            sENDANOTICEToolStripMenuItem.Click += sENDANOTICEToolStripMenuItem_Click;
            // 
            // rECEIPTToolStripMenuItem
            // 
            rECEIPTToolStripMenuItem.Name = "rECEIPTToolStripMenuItem";
            rECEIPTToolStripMenuItem.Size = new Size(117, 22);
            rECEIPTToolStripMenuItem.Text = "RECEIPT";
            rECEIPTToolStripMenuItem.Click += rECEIPTToolStripMenuItem_Click;
            // 
            // aNALYTICSToolStripMenuItem
            // 
            aNALYTICSToolStripMenuItem.Name = "aNALYTICSToolStripMenuItem";
            aNALYTICSToolStripMenuItem.Size = new Size(157, 22);
            aNALYTICSToolStripMenuItem.Text = "ANALYTICS";
            aNALYTICSToolStripMenuItem.Click += aNALYTICSToolStripMenuItem_Click;
            // 
            // aBOUTUSToolStripMenuItem
            // 
            aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            aBOUTUSToolStripMenuItem.Size = new Size(157, 22);
            aBOUTUSToolStripMenuItem.Text = "LOG OUT";
            aBOUTUSToolStripMenuItem.Click += aBOUTUSToolStripMenuItem_Click;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AboutUs";
            Text = "About Us";
            Load += Form10_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem oVERVIEWToolStripMenuItem;
        private ToolStripMenuItem sENDToolStripMenuItem;
        private ToolStripMenuItem sENDANOTICEToolStripMenuItem;
        private ToolStripMenuItem aNALYTICSToolStripMenuItem;
        private ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private ToolStripMenuItem rECEIPTToolStripMenuItem;
    }
}