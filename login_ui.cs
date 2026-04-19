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

        public login_ui()
        {
            InitializeComponent();
            passwordTextbox.UseSystemPasswordChar = true;
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
                new dashboard_ui().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password you enter is incorrect, try again");
                usernameTextbox.Clear();
                passwordTextbox.Clear();
                usernameTextbox.Focus();
            }
        }
          
        
    }
}

