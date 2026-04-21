using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudyQuest
{
    public partial class dashboard_ui : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );




        public dashboard_ui()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = dashboardButton.Height;
            pnlNav.Top = dashboardButton.Top;
            pnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = dashboardButton.Height;
            pnlNav.Top = dashboardButton.Top;
            pnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(15, 23, 42);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = logoutButton.Height;
            pnlNav.Top = logoutButton.Top;
            logoutButton.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = avatarButton.Height;
            pnlNav.Top = avatarButton.Top;
            avatarButton.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = leaderboardButton.Height;
            pnlNav.Top = leaderboardButton.Top;
            leaderboardButton.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void badgesButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = badgesButton.Height;
            pnlNav.Top = badgesButton.Top;
            badgesButton.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = taskButton.Height;
            pnlNav.Top = taskButton.Top;
            taskButton.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_ui_Load(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Leave(object sender, EventArgs e)
        {
            dashboardButton.BackColor = Color.FromArgb(17, 28, 46);
        }

        private void taskButton_Leave(object sender, EventArgs e)
        {
            taskButton.BackColor = Color.FromArgb(17, 28, 46);
        }

        private void leaderboardButton_Leave(object sender, EventArgs e)
        {
            leaderboardButton.BackColor = Color.FromArgb(17, 28, 46);
        }

        private void badgesButton_Leave(object sender, EventArgs e)
        {
            badgesButton.BackColor = Color.FromArgb(17, 28, 46);
        }

        private void avatarButton_Leave(object sender, EventArgs e)
        {
            avatarButton.BackColor = Color.FromArgb(17, 28, 46);
        }

        private void logoutButton_Leave(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.FromArgb(17, 28, 46);
        }
    }
}
