using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Group5
{
    public partial class AdminLogin : Form
    {
        private int loginAttempts = 0;
        private const int maxAttempts = 3;
        private int lockoutSeconds = 60;
        private int remainingLockoutSeconds;
        private System.Windows.Forms.Timer lockoutTimer;
        private Guna2WinProgressIndicator loader;

        public AdminLogin()
        {
            InitializeComponent();

       
            InitializeLoading();

            lockoutTimer = new System.Windows.Forms.Timer(); 
            lockoutTimer.Interval = 1000;
            lockoutTimer.Tick += LockoutTimer_Tick; 
            lblLockoutCountdown.Visible = false;
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

        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            remainingLockoutSeconds--;
            if (remainingLockoutSeconds > 0)
            {
                lblLockoutCountdown.Text = $"Locked out: {remainingLockoutSeconds} seconds";
            }
            else
            {
                lockoutTimer.Stop();
                loginAttempts = 0;
                lblLockoutCountdown.Visible = false;
                MessageBox.Show("You can try logging in again.", "Lockout Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_BACK_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest();
            addRequest.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            txt_USERNAME.Clear();
            txt_PASSWORD.Clear();
        }

        private void chk_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_PASSWORD.UseSystemPasswordChar = !chk_ShowPass.Checked;
        }

  
        private async void btn_LOGIN_Click(object sender, EventArgs e)
        {
            if (lockoutTimer.Enabled)
            {
                MessageBox.Show("Please wait for the lockout to finish.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txt_USERNAME.Text.Trim();
            string password = txt_PASSWORD.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Email and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mysqlCon = "server=127.0.0.1; user=root; database=sample; password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            loginAttempts = 0;
                            lblLockoutCountdown.Visible = false;

                         
                            loader.Visible = true;
                            loader.Start();

                            await Task.Run(() => System.Threading.Thread.Sleep(2000));

                            loader.Stop();
                            loader.Visible = false;

                            MessageBox.Show("Login successful!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Overboard form8 = new Overboard();
                            form8.Show();
                            this.Hide();
                        }
                        else
                        {
                            loginAttempts++;
                            if (loginAttempts >= maxAttempts)
                            {
                                remainingLockoutSeconds = lockoutSeconds;
                                lblLockoutCountdown.Visible = true;
                                lblLockoutCountdown.Text = $"Locked out: {remainingLockoutSeconds} seconds";
                                lockoutTimer.Start();
                                MessageBox.Show($"Maximum attempts reached. Please wait {lockoutSeconds} seconds.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid username or password. {maxAttempts - loginAttempts} attempt(s) left.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
    }
}
