using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5
{
    public partial class ThankYouSubmission : Form
    {
        private System.Windows.Forms.Timer countdownTimer;
        private int secondsLeft = 5;

        public ThankYouSubmission()
        {
            InitializeComponent();

            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; 
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void ThankYouSubmission_Load(object sender, EventArgs e)
        {
          
            lblCountdown.Text = $"Redirecting in {secondsLeft} seconds...";
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;

            if (secondsLeft <= 0)
            {
                countdownTimer.Stop();

      
                AddRequest addRequest = new AddRequest();
                addRequest.Show();


                this.Close();
            }
            else
            {
                lblCountdown.Text = $"Redirecting in {secondsLeft} seconds...";
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            AddRequest addRequest = new AddRequest();
            addRequest.Show();
            this.Close();
        }
    }
}
