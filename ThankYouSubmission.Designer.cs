namespace Group5
{
    partial class ThankYouSubmission
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
            lblCountdown = new Label();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bernard MT Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(311, 167);
            label1.Name = "label1";
            label1.Size = new Size(873, 76);
            label1.TabIndex = 0;
            label1.Text = "Thank you for filling up this form!";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.Transparent;
            lblCountdown.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountdown.ForeColor = SystemColors.ActiveCaptionText;
            lblCountdown.Location = new Point(651, 541);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(0, 44);
            lblCountdown.TabIndex = 23;
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.BackColor = Color.Goldenrod;
            guna2TrackBar1.Enabled = false;
            guna2TrackBar1.FillColor = Color.Yellow;
            guna2TrackBar1.Location = new Point(482, 668);
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
            label9.Location = new Point(997, 640);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 33;
            label9.Text = "Finish";
            // 
            // ThankYouSubmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.NavajoWhite;
            BackgroundImage = Properties.Resources._2d000c76_42e3_4560_852b_37c7b6c58d6b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label9);
            Controls.Add(guna2TrackBar1);
            Controls.Add(lblCountdown);
            Controls.Add(label1);
            Name = "ThankYouSubmission";
            Text = "Thanks!";
            Load += ThankYouSubmission_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label lblCountdown;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Label label9;
    }
}