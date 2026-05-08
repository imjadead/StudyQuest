using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace StudyQuest
{
    public partial class login_ui : Form
    {
        private string defaultUsername = ConfigurationManager.AppSettings["DefaultUsername"] ?? "";
        private string defaultPassword = ConfigurationManager.AppSettings["DefaultPassword"] ?? "";

        private int failedAttempts = 0;
        private const int maxAttempts = 3;
        private const int lockoutSeconds = 30;
        private System.Windows.Forms.Timer? lockoutTimer;
        private int remainingSeconds;

        private bool isPasswordVisible = false;
        private Button togglePasswordBtn = new Button();

        public login_ui()
        {
            InitializeComponent();
            passwordTextbox.UseSystemPasswordChar = true;
            InitializeLockoutTimer();
            InitializeTogglePasswordButton();
            this.Load += Login_ui_Load;
        }

        private void Login_ui_Load(object? sender, EventArgs e)
        {
            passwordTextbox.Width = 292;

            togglePasswordBtn.Location = new Point(
                passwordTextbox.Right - togglePasswordBtn.Width - 2,
                passwordTextbox.Top + (passwordTextbox.Height - togglePasswordBtn.Height) / 2
            );

            togglePasswordBtn.BringToFront();
        }

        private void InitializeTogglePasswordButton()
        {
            togglePasswordBtn.Text = "👁";
            togglePasswordBtn.Size = new Size(30, 29);
            togglePasswordBtn.FlatStyle = FlatStyle.Flat;
            togglePasswordBtn.FlatAppearance.BorderSize = 0;
            togglePasswordBtn.BackColor = Color.FromArgb(15, 23, 42);
            togglePasswordBtn.ForeColor = Color.White;
            togglePasswordBtn.Font = new Font("Segoe UI", 10f);
            togglePasswordBtn.Cursor = Cursors.Hand;
            togglePasswordBtn.TabStop = false;

            togglePasswordBtn.Click += TogglePasswordBtn_Click;
            this.Controls.Add(togglePasswordBtn);
        }

        private void TogglePasswordBtn_Click(object? sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            passwordTextbox.UseSystemPasswordChar = !isPasswordVisible;
            togglePasswordBtn.Text = isPasswordVisible ? "🙈" : "👁";
        }

        // Designer event handlers (stubs) referenced by the Designer file.
        // These are intentionally minimal to satisfy the event wiring from the .Designer.cs file.
        private void usernameTextbox_TextChanged(object? sender, EventArgs e)
        {
            // No-op or add validation logic here if needed
        }

        private void panel1_Paint_1(object? sender, PaintEventArgs e)
        {
            // No custom painting required currently.
        }

        private void studyQuestLogo_Click(object? sender, EventArgs e)
        {
            // Logo click currently does nothing. Keep stub to avoid designer error.
        }

        private void InitializeLockoutTimer()
        {
            lockoutTimer = new System.Windows.Forms.Timer();
            lockoutTimer.Interval = 1000;
            lockoutTimer.Tick += LockoutTimer_Tick;
        }

        private void LockoutTimer_Tick(object? sender, EventArgs e)
        {
            remainingSeconds--;
            loginButton.Text = $"Wait {remainingSeconds}s...";

            if (remainingSeconds <= 0)
            {
                lockoutTimer!.Stop();
                failedAttempts = 0;
                loginButton.Enabled = true;
                loginButton.Text = "Login";
                usernameTextbox.Enabled = true;
                passwordTextbox.Enabled = true;
                togglePasswordBtn.Enabled = true;
                usernameTextbox.Focus();
            }
        }

        private void StartLockout()
        {
            remainingSeconds = lockoutSeconds;
            loginButton.Enabled = false;
            loginButton.Text = $"Wait {remainingSeconds}s...";
            usernameTextbox.Enabled = false;
            passwordTextbox.Enabled = false;
            togglePasswordBtn.Enabled = false;

            lockoutTimer!.Start();

            MessageBox.Show($"Too many failed attempts. Please wait {lockoutSeconds} seconds.",
                "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(defaultUsername) || string.IsNullOrEmpty(defaultPassword))
            {
                MessageBox.Show("Config not set properly (App.config missing values).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usernameTextbox.Text == defaultUsername &&
                passwordTextbox.Text == defaultPassword)
            {
                failedAttempts = 0;

                isPasswordVisible = false;
                passwordTextbox.UseSystemPasswordChar = true;
                togglePasswordBtn.Text = "👁";

                new dashboard_ui().Show();
                this.Hide();
            }
            else
            {
                failedAttempts++;
                int attemptsLeft = maxAttempts - failedAttempts;

                if (failedAttempts >= maxAttempts)
                {
                    usernameTextbox.Clear();
                    passwordTextbox.Clear();
                    StartLockout();
                }
                else
                {
                    MessageBox.Show($"Incorrect login. {attemptsLeft} attempt(s) left.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    usernameTextbox.Clear();
                    passwordTextbox.Clear();
                    usernameTextbox.Focus();


                }
            }
        }
    }
}