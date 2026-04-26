namespace Group5
{
    partial class Overboard
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
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            sTATUSToolStripMenuItem = new ToolStripMenuItem();
            sENDANOTICEToolStripMenuItem = new ToolStripMenuItem();
            rECEIPTToolStripMenuItem = new ToolStripMenuItem();
            aNALYTICSToolStripMenuItem = new ToolStripMenuItem();
            aBOUTUSToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sTATUSToolStripMenuItem, sENDANOTICEToolStripMenuItem, aNALYTICSToolStripMenuItem, aBOUTUSToolStripMenuItem, lOGOUTToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(68, 22);
            mENUToolStripMenuItem.Text = "MENU";
            mENUToolStripMenuItem.Click += mENUToolStripMenuItem_Click;
            // 
            // sTATUSToolStripMenuItem
            // 
            sTATUSToolStripMenuItem.Name = "sTATUSToolStripMenuItem";
            sTATUSToolStripMenuItem.Size = new Size(205, 22);
            sTATUSToolStripMenuItem.Text = "STATUS";
            sTATUSToolStripMenuItem.Click += sTATUSToolStripMenuItem_Click;
            // 
            // sENDANOTICEToolStripMenuItem
            // 
            sENDANOTICEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rECEIPTToolStripMenuItem });
            sENDANOTICEToolStripMenuItem.Name = "sENDANOTICEToolStripMenuItem";
            sENDANOTICEToolStripMenuItem.Size = new Size(205, 22);
            sENDANOTICEToolStripMenuItem.Text = "SEND A NOTICE";
            sENDANOTICEToolStripMenuItem.Click += sENDANOTICEToolStripMenuItem_Click;
            // 
            // rECEIPTToolStripMenuItem
            // 
            rECEIPTToolStripMenuItem.Name = "rECEIPTToolStripMenuItem";
            rECEIPTToolStripMenuItem.Size = new Size(180, 22);
            rECEIPTToolStripMenuItem.Text = "RECEIPT";
            rECEIPTToolStripMenuItem.Click += rECEIPTToolStripMenuItem_Click;
            // 
            // aNALYTICSToolStripMenuItem
            // 
            aNALYTICSToolStripMenuItem.Name = "aNALYTICSToolStripMenuItem";
            aNALYTICSToolStripMenuItem.Size = new Size(205, 22);
            aNALYTICSToolStripMenuItem.Text = "ANALYTICS";
            aNALYTICSToolStripMenuItem.Click += aNALYTICSToolStripMenuItem_Click;
            // 
            // aBOUTUSToolStripMenuItem
            // 
            aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            aBOUTUSToolStripMenuItem.Size = new Size(205, 22);
            aBOUTUSToolStripMenuItem.Text = "ABOUT US";
            aBOUTUSToolStripMenuItem.Click += aBOUTUSToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(205, 22);
            lOGOUTToolStripMenuItem.Text = "LOG OUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // Overboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 628);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Overboard";
            Text = "Menu";
            Load += Form8_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem sTATUSToolStripMenuItem;
        private ToolStripMenuItem sENDANOTICEToolStripMenuItem;
        private ToolStripMenuItem aNALYTICSToolStripMenuItem;
        private ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem rECEIPTToolStripMenuItem;
    }
}