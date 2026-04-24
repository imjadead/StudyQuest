using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private List<(string Name, int XP)> leaderboard = new List<(string, int)>
        {
            ("Alice",  5200),
            ("Bob",    3800),
            ("Carol",  3100),
            ("Dave",   2500),
            ("admin",  0),
        };

        public sidebar_dashboard()
        {
            InitializeComponent();
        }

        private void sidebar_dashboard_Load(object sender, EventArgs e)
        {
            // Subscribe to EXP changes from sidebar_task
            sidebar_task.EXPChanged += OnEXPChanged;

            UpdateStreak();
            UpdateRank();
            RefreshUI();
            HighlightTodayLabel();
        }

        // ── Called every time a task is completed or missed ───────────────────
        private void OnEXPChanged()
        {
            // Marshal to UI thread if needed
            if (this.InvokeRequired)
                this.Invoke(new Action(OnEXPChanged));
            else
            {
                UpdateRank();
                RefreshUI();
            }
        }

        // ── Unsubscribe when dashboard is hidden / closed ─────────────────────
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
        // RANK  — uses live EXP from sidebar_task
        // =====================================================================
        private string rank = "1st";

        private void UpdateRank()
        {
            // Update admin's XP in the leaderboard list
            for (int i = 0; i < leaderboard.Count; i++)
            {
                if (leaderboard[i].Name == username)
                {
                    leaderboard[i] = (username, TotalXP);
                    break;
                }
            }

            leaderboard.Sort((a, b) => b.XP.CompareTo(a.XP));

            int position = leaderboard.FindIndex(p => p.Name == username) + 1;
            rank = GetOrdinal(position);
        }

        private string GetOrdinal(int position)
        {
            if (position % 100 >= 11 && position % 100 <= 13)
                return $"{position}th";

            return (position % 10) switch
            {
                1 => $"{position}st",
                2 => $"{position}nd",
                3 => $"{position}rd",
                _ => $"{position}th"
            };
        }

        // =====================================================================
        // REFRESH UI — binds all labels to live sidebar_task data
        // =====================================================================
        private void RefreshUI()
        {
            if (greetingsUser != null)
                greetingsUser.Text = $"Good day, {username}!";

            // ── EXP & Level ───────────────────────────────────────────────────
            if (numTotalXP != null)
                numTotalXP.Text = $"{TotalXP} XP";

            // Show Level next to XP if you have a label for it
            // e.g. numLevel.Text = $"Level {CurrentLevel}";

            // ── Task counters from sidebar_task ───────────────────────────────
            if (numTaskDone != null)
                numTaskDone.Text = TasksDone.ToString();

            // ── Rank ──────────────────────────────────────────────────────────
            if (numRank != null)
                numRank.Text = rank;

            // ── Streak ────────────────────────────────────────────────────────
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
        // STUBS (keep to satisfy designer)
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
    }
}