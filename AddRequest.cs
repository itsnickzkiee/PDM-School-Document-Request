using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Group5
{
    public partial class AddRequest : Form
    {
        int numA, numB, correctAnswer;
        private Guna2WinProgressIndicator loader;


        int glowAlpha = 0;
        bool glowIncreasing = true;

        System.Windows.Forms.Timer timerGlow = new System.Windows.Forms.Timer();





        public AddRequest()
        {
            InitializeComponent();
            InitializeLoading();
        }


        private void InitializeLoading()
        {
            loader = new Guna2WinProgressIndicator
            {
                Size = new Size(100, 100),
                Location = new Point((this.ClientSize.Width - 100) / 2,
                                     (this.ClientSize.Height - 100) / 2),
                Visible = false,
                ProgressColor = Color.Yellow,
                BackColor = Color.Transparent
            };

            this.Controls.Add(loader);
            loader.BringToFront();
        }


        private void AddRequest_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();

            guna2TrackBar1.Value = 1;


            guna2TrackBar1.Enabled = false;



            guna2TrackBar1.FillColor = Color.Yellow;
            guna2TrackBar1.ThumbColor = Color.Yellow;

            guna2TrackBar1.Invalidate();
            guna2TrackBar1.Update();
            timerGlow.Interval = 30;
            timerGlow.Tick += timerGlow_Tick;



            int yearNow = DateTime.Now.Year;
            int yearNext = yearNow + 1;

            lbl_SchoolYear.Text = $"{yearNow} - {yearNext}";

        }

        private void timerGlow_Tick(object sender, EventArgs e)
        {
            if (glowIncreasing)
                glowAlpha += 5;
            else
                glowAlpha -= 5;

            if (glowAlpha >= 200) glowIncreasing = false;
            if (glowAlpha <= 30) glowIncreasing = true;

            btn_Req.FlatStyle = FlatStyle.Flat;
            btn_Req.FlatAppearance.BorderSize = 0;
            btn_Req.BackColor = Color.FromArgb(glowAlpha, 0, 120, 255); // blue glow
        }

        private void btnRequest_MouseHover(object sender, EventArgs e)
        {
            timerGlow.Start();
        }

        private void btnRequest_MouseLeave(object sender, EventArgs e)
        {
            timerGlow.Stop();
            btn_Req.BackColor = Color.FromArgb(40, 40, 40); // normal color
        }

        private void GenerateCaptcha()
        {
            Random rand = new Random();
            numA = rand.Next(1, 10);
            numB = rand.Next(1, 10);
            correctAnswer = numA + numB;

            lblCaptcha.Text = $"Solve: {numA} + {numB} = ?";
            txtCaptchaAnswer.Clear();
        }


        private async void btn_Req_Click(object sender, EventArgs e)
        {

            if (!chkNotRobot.Checked)
            {
                MessageBox.Show("Please check 'I'm not a robot' first.");
                return;
            }


            if (!int.TryParse(txtCaptchaAnswer.Text.Trim(), out int userAnswer))
            {
                MessageBox.Show("Please enter a valid number.");
                txtCaptchaAnswer.Focus();
                return;
            }


            if (userAnswer != correctAnswer)
            {
                MessageBox.Show("Incorrect CAPTCHA. A new one will be generated.");
                GenerateCaptcha();
                return;
            }


            MessageBox.Show("Verification successful! Submitting your request...");

            loader.Visible = true;
            loader.Start();

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000);
            });

            loader.Stop();
            loader.Visible = false;


            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (loader != null)
            {
                loader.Location = new Point((this.ClientSize.Width - loader.Width) / 2,
                                            (this.ClientSize.Height - loader.Height) / 2);
            }
        }


        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin form7 = new AdminLogin();
            form7.Show();
            this.Hide();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void chkNotRobot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void lblCaptcha_Click(object sender, EventArgs e)
        {

        }

        private void txtCaptchaAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
