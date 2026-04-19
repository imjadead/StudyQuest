using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class login_ui : Form
    {
        private const string correctUsername = "user";
        private const string correctPassword = "1234";

        public login_ui()
        {
            InitializeComponent();
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.TextChanged += usernameTextbox_TextChanged;
            loginButton.Enabled = false;
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
            loginButton.Enabled = !string.IsNullOrWhiteSpace(usernameTextbox.Text)
                                && !string.IsNullOrWhiteSpace(passwordTextbox.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text.Trim();
            string password = usernameTextbox.Text.Trim();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
        }

         if (username == correctUsername && password == correctPassword)
            {
                MessageBox.Show("Login successful! Welcome, " + username + "!", "Welcome",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                passwordTextbox.Clear();
                passwordTextbox.Focus();
            }
        }
    }
}

