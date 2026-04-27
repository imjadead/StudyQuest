using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_dashboard : Form
    {
        private string username = "admin";
        private int streakDays = 0;
        private DateTime lastLoginDate = DateTime.Today.AddDays(-1);

        // ── Pull EXP and task counts directly from sidebar_task ──────────────
        private int TotalXP => sidebar_task.CurrentEXP;
        private int CurrentLevel => sidebar_task.CurrentLevel;
        private int TasksDone => sidebar_task.CompletedCount;
        private int TasksMissed => sidebar_task.MissedCount;
        private int TasksTotal => sidebar_task.TotalCount;

        public sidebar_dashboard()
        {
            InitializeComponent();
        }

        private void sidebar_dashboard_Load(object sender, EventArgs e)
        {
            sidebar_task.EXPChanged += OnEXPChanged;

            UpdateStreak();
            RefreshUI();
            HighlightTodayLabel();
        }

        // ── Called every time a task is completed or missed ───────────────────
        private void OnEXPChanged()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(OnEXPChanged));
            else
                RefreshUI();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sidebar_task.EXPChanged -= OnEXPChanged;
            base.OnFormClosing(e);
        }

        // =====================================================================
        // STREAK
        // =====================================================================
        private void UpdateStreak()
        {
            DateTime today = DateTime.Today;
            int daysSince = (today - lastLoginDate.Date).Days;

            if (daysSince == 1) streakDays++;
            else if (daysSince > 1) streakDays = 1;

            lastLoginDate = today;
        }

        // =====================================================================
        // REFRESH UI
        // =====================================================================
        private void RefreshUI()
        {
            // ── Sync to GameSession FIRST so rank calc uses latest XP ─────────
            GameSession.TotalXP = TotalXP;
            GameSession.Level = CurrentLevel;
            GameSession.Username = username;

            if (greetingsUser != null)
                greetingsUser.Text = $"Good day, {username}!";

            if (numTotalXP != null)
                numTotalXP.Text = $"{TotalXP} XP";

            if (numTaskDone != null)
                numTaskDone.Text = TasksDone.ToString();

            // ── Rank — uses SAME GameSession method as leaderboard ────────────
            if (numRank != null)
                numRank.Text = GameSession.GetOrdinal(GameSession.GetCurrentRank());

            if (numDayStreak != null)
                numDayStreak.Text = streakDays.ToString();
        }

        // =====================================================================
        // HIGHLIGHT TODAY
        // =====================================================================
        private void HighlightTodayLabel()
        {
            Label[] days = { label1, label2, label3, label4, label6, label5, label7 };
            int todayIndex = ((int)DateTime.Today.DayOfWeek + 6) % 7;
            Color normal = Color.FromArgb(192, 255, 255);
            Color highlight = Color.FromArgb(100, 200, 255);

            foreach (Label l in days)
                if (l != null) l.BackColor = normal;

            if (days[todayIndex] != null)
                days[todayIndex].BackColor = highlight;
        }

        // =====================================================================
        // STUBS
        // =====================================================================
        private void mustDOListBox_DoubleClick(object sender, EventArgs e) { }
        private void myTaskListBox_DoubleClick(object sender, EventArgs e) { }
        private void mustDOListBox_KeyDown(object sender, KeyEventArgs e) { }
        private void myTaskListBox_KeyDown(object sender, KeyEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label8_Click_1(object sender, EventArgs e) { }
        private void label8_Click_2(object sender, EventArgs e) { }
        private void label8_Click_3(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }

        private void numRank_Click(object sender, EventArgs e)
        {

        }

        private void numTotalXP_Click(object sender, EventArgs e)
        {

        }
    }
}