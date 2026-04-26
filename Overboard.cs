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
    public partial class Overboard : Form
    {
        public Overboard()
        {
            InitializeComponent();
        }

        private void sTATUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingStatus form5 = new PendingStatus();
            form5.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void sENDANOTICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            string connStr = "server=127.0.0.1; user=root; database=sample; password=";
            SendaNotice form6 = new SendaNotice(connStr);
            form6.Show();

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Logout?", "Log out Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                AdminLogin form7 = new AdminLogin();
                form7.Show();
            }
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void aNALYTICSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analytics form9 = new Analytics();
            form9.Show();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rECEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
            this.Hide();
        }
    }
}
