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
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        // ── Keep a single embedded instance for each sidebar panel ────────────
        //private sidebar_task? _taskPanel;
        private sidebar_dashboard? _dashPanel;
        private sidebar_leaderboard? _leaderPanel;
        private sidebar_badges? _badgesPanel;
        private sidebar_avatar? _avatarPanel;

        public dashboard_ui()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNav.Height = dashboardButton.Height;
            pnlNav.Top = dashboardButton.Top;
            pnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(15, 23, 42);

            ShowPanel(ref _dashPanel, () => new sidebar_dashboard());
        }

        // =====================================================================
        // GENERIC PANEL SWITCHER
        // Reuses the existing panel if already created (keeps state alive).
        // =====================================================================
        private void ShowPanel<T>(ref T? field, Func<T> factory) where T : Form
        {
            this.pnlFormLoader.Controls.Clear();

            if (field == null || field.IsDisposed)
            {
                field = factory();
                field.Dock = DockStyle.Fill;
                field.TopLevel = false;
                field.TopMost = true;
                field.FormBorderStyle = FormBorderStyle.None;
            }

            this.pnlFormLoader.Controls.Add(field);
            field.Show();
        }

        // =====================================================================
        // NAV BUTTONS
        // =====================================================================
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = dashboardButton.Height;
            pnlNav.Top = dashboardButton.Top;
            pnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(15, 23, 42);

            ShowPanel(ref _dashPanel, () => new sidebar_dashboard());
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = taskButton.Height;
            pnlNav.Top = taskButton.Top;
            taskButton.BackColor = Color.FromArgb(15, 23, 42);

            // ── FIX: use the singleton instead of new sidebar_task() ──────────
            this.pnlFormLoader.Controls.Clear();

            var taskForm = sidebar_task.Instance;
            taskForm.Dock = DockStyle.Fill;
            taskForm.TopLevel = false;
            taskForm.TopMost = true;
            taskForm.FormBorderStyle = FormBorderStyle.None;

            this.pnlFormLoader.Controls.Add(taskForm);
            taskForm.Show();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = leaderboardButton.Height;
            pnlNav.Top = leaderboardButton.Top;
            leaderboardButton.BackColor = Color.FromArgb(15, 23, 42);

            ShowPanel(ref _leaderPanel, () => new sidebar_leaderboard());
        }

        private void badgesButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = badgesButton.Height;
            pnlNav.Top = badgesButton.Top;
            badgesButton.BackColor = Color.FromArgb(15, 23, 42);

            ShowPanel(ref _badgesPanel, () => new sidebar_badges());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = avatarButton.Height;
            pnlNav.Top = avatarButton.Top;
            avatarButton.BackColor = Color.FromArgb(15, 23, 42);

            ShowPanel(ref _avatarPanel, () => new sidebar_avatar());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                login_ui loginForm = new login_ui();
                loginForm.Show();
                this.Close();
            }
        }

        // ── Leave (highlight reset) ───────────────────────────────────────────
        private void dashboardButton_Leave(object sender, EventArgs e) => dashboardButton.BackColor = Color.FromArgb(17, 28, 46);
        private void taskButton_Leave(object sender, EventArgs e) => taskButton.BackColor = Color.FromArgb(17, 28, 46);
        private void leaderboardButton_Leave(object sender, EventArgs e) => leaderboardButton.BackColor = Color.FromArgb(17, 28, 46);
        private void badgesButton_Leave(object sender, EventArgs e) => badgesButton.BackColor = Color.FromArgb(17, 28, 46);
        private void avatarButton_Leave(object sender, EventArgs e) => avatarButton.BackColor = Color.FromArgb(17, 28, 46);
        private void logoutButton_Leave(object sender, EventArgs e) => logoutButton.BackColor = Color.FromArgb(17, 28, 46);

        // ── Unused stubs (keep to satisfy designer) ───────────────────────────
        private void button5_Click(object sender, EventArgs e) { pnlNav.Height = logoutButton.Height; pnlNav.Top = logoutButton.Top; logoutButton.BackColor = Color.FromArgb(15, 23, 42); }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void nameTextbox_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged_1(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void sidebar_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dashboard_ui_Load(object sender, EventArgs e) { }
    }
}