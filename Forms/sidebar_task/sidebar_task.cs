using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_task : Form
    {
        // =====================================================================
        // SINGLETON
        // =====================================================================
        private static sidebar_task? _instance;
        public static sidebar_task Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new sidebar_task();
                return _instance;
            }
        }

        // =====================================================================
        // TASK MODEL
        // =====================================================================
        private class TaskItem
        {
            public string Title { get; set; } = string.Empty;
            public string Details { get; set; } = string.Empty;
            public DateTime Deadline { get; set; }
            public string Difficulty { get; set; } = string.Empty; // "Easy"|"Medium"|"Hard"
            public bool IsCompleted { get; set; }
            public bool IsMissed { get; set; }
            public int ExpReward { get; set; }

            public override string ToString() =>
                $"{Title}  [{Deadline:MM/dd/yyyy}]  +{ExpReward} EXP";
        }

        // =====================================================================
        // SHARED APP STATE
        // =====================================================================
        public static int CurrentEXP { get; private set; } = 0;
        public static int CurrentLevel { get; private set; } = 1;
        public static event Action? EXPChanged;

        // ── Live counters readable by dashboard ───────────────────────────────
        public static int CompletedCount { get; private set; } = 0;
        public static int MissedCount { get; private set; } = 0;
        public static int TotalCount { get; private set; } = 0;

        // =====================================================================
        // FIELDS
        // =====================================================================
        private readonly List<TaskItem> _allTasks = new();
        private System.Windows.Forms.Timer _deadlineTimer = null!;

        // =====================================================================
        // CONSTRUCTOR — private (singleton)
        // =====================================================================
        private sidebar_task()
        {
            InitializeComponent();
            InitDeadlineTimer();
            RefreshCounters();
        }

        // =====================================================================
        // HIDE instead of CLOSE — preserves task data on navigation
        // =====================================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown)
            {
                base.OnFormClosing(e);
                return;
            }
            e.Cancel = true;
            this.Hide();
        }

        // =====================================================================
        // STEP 1 — Input task details → Add task to list
        // button1 Click
        // =====================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string details = textBox2.Text.Trim();
            DateTime deadline = dateTimePicker1.Value.Date;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a task title.", "Missing Title",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deadline < DateTime.Today)
            {
                MessageBox.Show("Deadline cannot be in the past.", "Invalid Date",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string difficulty = ClassifyByDeadline(deadline);

            int expReward = difficulty switch
            {
                "Easy" => 20,
                "Medium" => 30,
                "Hard" => 50,
                _ => 0
            };

            var task = new TaskItem
            {
                Title = title,
                Details = details,
                Deadline = deadline,
                Difficulty = difficulty,
                ExpReward = expReward,
                IsCompleted = false,
                IsMissed = false
            };

            _allTasks.Add(task);
            AddToListBox(task);

            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Today;

            RefreshCounters();
        }

        // =====================================================================
        // CLASSIFY by deadline
        //   > 3 days  → Easy
        //   1–3 days  → Medium
        //   ≤ 0 days  → Hard
        // =====================================================================
        private static string ClassifyByDeadline(DateTime deadline)
        {
            int daysLeft = (deadline.Date - DateTime.Today).Days;
            if (daysLeft > 3) return "Easy";
            if (daysLeft >= 1) return "Medium";
            return "Hard";
        }

        private void AddToListBox(TaskItem task)
        {
            switch (task.Difficulty)
            {
                case "Easy": EasyTaskListBox.Items.Add(task); break;
                case "Medium": MediumTaskListBox.Items.Add(task); break;
                case "Hard": HardTaskListBox.Items.Add(task); break;
            }
        }

        // =====================================================================
        // HELPER — get the currently selected TaskItem across all three listboxes
        // Returns (listbox, task) or (null, null) if nothing is selected
        // =====================================================================
        private (ListBox? box, TaskItem? task) GetSelectedTask()
        {
            foreach (var lb in new[] { EasyTaskListBox, MediumTaskListBox, HardTaskListBox })
            {
                if (lb.SelectedItem is TaskItem t)
                    return (lb, t);
            }
            return (null, null);
        }

        // =====================================================================
        // COMPLETE BUTTON — unlockButton Click
        // Select a task first, then click "Task Complete"
        // =====================================================================
        private void unlockButton_Click(object sender, EventArgs e)
        {
            var (listBox, task) = GetSelectedTask();

            if (listBox == null || task == null)
            {
                MessageBox.Show("Please select a task first.", "No Task Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (task.IsMissed)
            {
                MessageBox.Show(
                    $"YOU HAVEN'T COMPLETED THE TASK YET\n\n" +
                    $"\"{task.Title}\" deadline has already passed.",
                    "Missed Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (task.IsCompleted)
            {
                MessageBox.Show($"\"{task.Title}\" is already completed! ✓",
                                "Already Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ── Mark as completed ─────────────────────────────────────────────
            task.IsCompleted = true;

            int expGain = task.Difficulty switch
            {
                "Easy" => 20,
                "Medium" => 30,
                "Hard" => 50,
                _ => 0
            };

            ApplyEXP(expGain);

            // Replace TaskItem in the listbox with a completion indicator string
            int idx = listBox.Items.IndexOf(task);
            listBox.Items[idx] =
                $"✓  {task.Title}  [{task.Deadline:MM/dd/yyyy}]  (+{expGain} EXP)";

            // Deselect so the ✓ indicator is clearly visible
            listBox.ClearSelected();

            RefreshCounters();

            MessageBox.Show(
                $"Task \"{task.Title}\" completed!\n" +
                $"+{expGain} EXP earned.\n\n" +
                $"Total EXP : {CurrentEXP}\n" +
                $"Level     : {CurrentLevel}",
                "Task Complete! 🎉",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =====================================================================
        // DELETE BUTTON — button2 Click
        // Select a task (pending OR completed string) then click "Delete Task"
        // =====================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            var (listBox, task) = GetSelectedTask();

            if (listBox == null || task == null)
            {
                // Check if a completed / missed string entry is selected
                ListBox? strBox = null;
                int strIdx = -1;

                foreach (var lb in new[] { EasyTaskListBox, MediumTaskListBox, HardTaskListBox })
                {
                    if (lb.SelectedItem is string)
                    {
                        strBox = lb;
                        strIdx = lb.SelectedIndex;
                        break;
                    }
                }

                if (strBox == null)
                {
                    MessageBox.Show("Please select a task to delete.", "No Task Selected",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selected = (string)strBox.Items[strIdx];

                var confirm = MessageBox.Show(
                    $"Delete this task?\n\n{selected}",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                // Remove matching TaskItem from master list
                var match = _allTasks.Find(t =>
                    selected.Contains(t.Title) &&
                    selected.Contains(t.Deadline.ToString("MM/dd/yyyy")));

                if (match != null) _allTasks.Remove(match);
                strBox.Items.RemoveAt(strIdx);
                RefreshCounters();
                return;
            }

            // Pending task selected
            var confirmPending = MessageBox.Show(
                $"Delete \"{task.Title}\"?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmPending != DialogResult.Yes) return;

            _allTasks.Remove(task);
            listBox.Items.Remove(task);
            RefreshCounters();
        }

        // =====================================================================
        // DOUBLE-CLICK — shows task details (completing is now via button)
        // =====================================================================
        private void TaskListBox_DoubleClick(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem == null) return;

            if (listBox.SelectedItem is string s)
            {
                MessageBox.Show(s, "Task Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var task = (TaskItem)listBox.SelectedItem;
            MessageBox.Show(
                $"Title     : {task.Title}\n" +
                $"Details   : {task.Details}\n" +
                $"Deadline  : {task.Deadline:MM/dd/yyyy}\n" +
                $"Difficulty: {task.Difficulty}  (+{task.ExpReward} EXP)\n" +
                $"Status    : {(task.IsMissed ? "⚠ Missed" : "Pending")}",
                "Task Details",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =====================================================================
        // EXP FORMULA
        // =====================================================================
        private const int MaxLevel = 100;

        private static void ApplyEXP(int amount)
        {
            CurrentEXP += amount;

            while (CurrentLevel < MaxLevel &&
                   CurrentEXP >= (CurrentLevel + 1) * 100)
            {
                CurrentLevel++;

                if (CurrentLevel == MaxLevel)
                {
                    MessageBox.Show(
                        "🏆  MAX LEVEL REACHED!\nYou are now Level 100 — the highest rank!",
                        "Max Level!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"🎉  LEVEL UP!\nYou are now Level {CurrentLevel}!",
                        "Level Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            EXPChanged?.Invoke();
        }

        // =====================================================================
        // EXP PENALTY (missed task)
        // =====================================================================
        private static void ApplyEXPPenalty(int penalty = 10)
        {
            CurrentEXP = Math.Max(0, CurrentEXP - penalty);
            EXPChanged?.Invoke();
        }

        // =====================================================================
        // DEADLINE CHECKER — fires every 60 s
        // =====================================================================
        private void InitDeadlineTimer()
        {
            _deadlineTimer = new System.Windows.Forms.Timer { Interval = 60_000 };
            _deadlineTimer.Tick += DeadlineTimer_Tick;
            _deadlineTimer.Start();
            DeadlineTimer_Tick(this, EventArgs.Empty);
        }

        private void DeadlineTimer_Tick(object? sender, EventArgs e)
        {
            bool anyChange = false;

            foreach (var task in _allTasks)
            {
                if (task.IsCompleted || task.IsMissed) continue;

                if (DateTime.Today > task.Deadline.Date)
                {
                    task.IsMissed = true;
                    ApplyEXPPenalty(10);
                    anyChange = true;
                }
            }

            if (anyChange)
            {
                RefreshAllListBoxes();
                RefreshCounters();
                SortLeaderboard();
            }
        }

        // =====================================================================
        // REFRESH LIST BOXES
        // =====================================================================
        private void RefreshAllListBoxes()
        {
            EasyTaskListBox.Items.Clear();
            MediumTaskListBox.Items.Clear();
            HardTaskListBox.Items.Clear();

            foreach (var task in _allTasks)
            {
                if (task.IsCompleted)
                {
                    ListBox target = task.Difficulty switch
                    {
                        "Easy" => EasyTaskListBox,
                        "Medium" => MediumTaskListBox,
                        _ => HardTaskListBox
                    };
                    target.Items.Add(
                        $"✓  {task.Title}  [{task.Deadline:MM/dd/yyyy}]  (+{task.ExpReward} EXP)");
                    continue;
                }

                if (task.IsMissed)
                {
                    HardTaskListBox.Items.Add(
                        $"⚠ MISSED: {task.Title}  [{task.Deadline:MM/dd/yyyy}]");
                    continue;
                }

                string newDiff = ClassifyByDeadline(task.Deadline);
                if (newDiff != task.Difficulty)
                {
                    task.Difficulty = newDiff;
                    task.ExpReward = newDiff switch
                    {
                        "Easy" => 20,
                        "Medium" => 30,
                        "Hard" => 50,
                        _ => task.ExpReward
                    };
                }

                AddToListBox(task);
            }
        }

        // =====================================================================
        // COUNTERS
        // =====================================================================
        private void RefreshCounters()
        {
            TotalCount = _allTasks.Count;
            CompletedCount = _allTasks.FindAll(t => t.IsCompleted).Count;
            MissedCount = _allTasks.FindAll(t => t.IsMissed && !t.IsCompleted).Count;

            numTaskDone.Text = TotalCount.ToString();
            numTaskCompleted.Text = CompletedCount.ToString();
            numTaskMissed.Text = MissedCount.ToString();

            EXPChanged?.Invoke();
        }

        // =====================================================================
        // LEADERBOARD SORT HOOK
        // =====================================================================
        private static void SortLeaderboard()
        {
            // TODO: call LeaderboardForm.Instance?.SortByEXP();
        }

        public static (int exp, int level) GetPlayerStats() => (CurrentEXP, CurrentLevel);

        // ── Designer stubs ────────────────────────────────────────────────────
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}