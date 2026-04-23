using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class login_ui : Form
    {
        private string defaultUsername = "admin";
        private string defaultPassword = "1234";

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
        }

        private void InitializeTogglePasswordButton()
        {
            togglePasswordBtn.Text = "👁 Show";
            togglePasswordBtn.AutoSize = true;
            togglePasswordBtn.FlatStyle = FlatStyle.Flat;
            togglePasswordBtn.FlatAppearance.BorderSize = 0;
            togglePasswordBtn.BackColor = Color.Transparent;
            togglePasswordBtn.ForeColor = Color.White;
            togglePasswordBtn.Font = new Font("Segoe UI", 8f);
            togglePasswordBtn.Cursor = Cursors.Hand;

            togglePasswordBtn.Location = new Point(
                passwordTextbox.Right - togglePasswordBtn.Width - 5,
                passwordTextbox.Bottom + 5
            );

            togglePasswordBtn.Click += TogglePasswordBtn_Click;
            this.Controls.Add(togglePasswordBtn);
        }

        private void TogglePasswordBtn_Click(object? sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            passwordTextbox.UseSystemPasswordChar = !isPasswordVisible;
            togglePasswordBtn.Text = isPasswordVisible ? "🙈 Hide" : "👁 Show";
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

            MessageBox.Show($"Too many failed attempts. Please wait {lockoutSeconds} seconds before trying again.",
                "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void studyQuestLogo_Click(object sender, EventArgs e)
        {
            // leave empty for now
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == defaultUsername && passwordTextbox.Text == defaultPassword)
            {
                failedAttempts = 0;

                isPasswordVisible = false;
                passwordTextbox.UseSystemPasswordChar = true;
                togglePasswordBtn.Text = "👁 Show";

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

                    isPasswordVisible = false;
                    passwordTextbox.UseSystemPasswordChar = true;
                    togglePasswordBtn.Text = "👁 Show";

                    StartLockout();
                }
                else
                {
                    MessageBox.Show($"Incorrect username or password. {attemptsLeft} attempt(s) remaining.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextbox.Clear();
                    passwordTextbox.Clear();
                    usernameTextbox.Focus();
                }
            }
        }
    }
}