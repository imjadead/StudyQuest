using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_dashboard : Form
    {
        private string username = "admin";
        private int totalXP_value = 0;
        private int tasksDone = 0;
        private string rank = "1st";
        private int streakDays = 0;
        private DateTime lastLoginDate;

        private List<string> mustDoTasks = new List<string>();
        private List<string> myTasks = new List<string>();


        private List<(string Name, int XP)> leaderboard = new List<(string, int)>
        {
            ("Alice",   5200),
            ("Bob",     3800),
            ("Carol",   3100),
            ("Dave",    2500),
            ("admin", 0),
        };

        public sidebar_dashboard()
        {
            InitializeComponent();
        }

        private void sidebar_dashboard_Load(object sender, EventArgs e)
        {
            UpdateStreak();
            UpdateRank();
            RefreshUI();
            HighlightTodayLabel();
        }

        private void UpdateStreak()
        {
            DateTime today = DateTime.Today;
            int daysSince = (today - lastLoginDate.Date).Days;

            if (daysSince == 1) streakDays++;
            else if (daysSince > 1) streakDays = 1;

            lastLoginDate = today;
        }

        private void UpdateRank()
        {

            for (int i = 0; i < leaderboard.Count; i++)
            {
                if (leaderboard[i].Name == username)
                {
                    leaderboard[i] = (username, totalXP_value);
                    break;
                }
            }

            // 2) Sort by XP descending
            leaderboard.Sort((a, b) => b.XP.CompareTo(a.XP));

            // 3) Find current user's position
            int position = leaderboard.FindIndex(p => p.Name == username) + 1;

            // 4) Set rank as ordinal number only
            rank = GetOrdinal(position);
        }

        private string GetOrdinal(int position)
        {
            // Handle 11th, 12th, 13th edge cases
            if (position % 100 >= 11 && position % 100 <= 13)
                return $"{position}th";

            switch (position % 10)
            {
                case 1: return $"{position}st";
                case 2: return $"{position}nd";
                case 3: return $"{position}rd";
                default: return $"{position}th";
            }
        }

        private void RefreshUI()
        {
            greetingsUser.Text = $"Good day {username}!";
            numTotalXP.Text = $"{totalXP_value} XP";
            numTaskDone.Text = tasksDone.ToString();
            numRank.Text = rank;
            numDayStreak.Text = streakDays.ToString();

            mustDOListBox.Items.Clear();
            foreach (string t in mustDoTasks) mustDOListBox.Items.Add(t);

            myTaskListBox.Items.Clear();
            foreach (string t in myTasks) myTaskListBox.Items.Add(t);
        }

        private void HighlightTodayLabel()
        {
            Label[] days = { label1, label2, label3, label4, label6, label5, label7 };
            int todayIndex = ((int)DateTime.Today.DayOfWeek + 6) % 7;

            Color normal = Color.FromArgb(192, 255, 255);
            Color highlight = Color.FromArgb(100, 200, 255);

            foreach (Label l in days)
                l.BackColor = normal;

            days[todayIndex].BackColor = highlight;
        }

        private void mustDOListBox_DoubleClick(object sender, EventArgs e)
        {
            CompleteTask(mustDOListBox, mustDoTasks, xpReward: 50);
        }

        private void myTaskListBox_DoubleClick(object sender, EventArgs e)
        {
            CompleteTask(myTaskListBox, myTasks, xpReward: 20);
        }

        private void CompleteTask(ListBox listBox, List<string> taskList, int xpReward)
        {
            if (listBox.SelectedIndex < 0) return;

            taskList.RemoveAt(listBox.SelectedIndex);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            totalXP_value += xpReward;
            tasksDone++;
            UpdateRank();
            RefreshUI();
        }

        private void mustDOListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveTask(mustDOListBox, mustDoTasks);
        }

        private void myTaskListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveTask(myTaskListBox, myTasks);
        }

        private void RemoveTask(ListBox listBox, List<string> taskList)
        {
            if (listBox.SelectedIndex < 0) return;
            taskList.RemoveAt(listBox.SelectedIndex);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            RefreshUI();
        }

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