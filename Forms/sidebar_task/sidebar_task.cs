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

            // Classify difficulty by days remaining until deadline
            string difficulty = ClassifyByDeadline(deadline);

            // EXP reward per flowchart:
            //   Easy   → +20 exp
            //   Medium → +30 exp
            //   Hard   → +50 exp
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
        // STEP 2 — Is "Task Complete!" clicked?
        //   No  → display "YOU HAVENT COMPLETED THE TASK YET"
        //   Yes → Mark Task as "Completed" → check difficulty → add EXP
        // Double-click any list box item
        // =====================================================================
        private void TaskListBox_DoubleClick(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem == null) return;

            // Already-completed / missed items are stored as plain strings
            if (listBox.SelectedItem is string)
            {
                // Flowchart No branch: "YOU HAVENT COMPLETED THE TASK YET"
                MessageBox.Show("YOU HAVENT COMPLETED THE TASK YET",
                                "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = (TaskItem)listBox.SelectedItem;

            // ── No branch: task is missed (deadline passed, not completed) ────
            if (task.IsMissed)
            {
                MessageBox.Show("YOU HAVENT COMPLETED THE TASK YET\n\n" +
                                $"\"{task.Title}\" deadline has already passed.",
                                "Missed Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── No branch: already completed ──────────────────────────────────
            if (task.IsCompleted)
            {
                MessageBox.Show("YOU HAVENT COMPLETED THE TASK YET",
                                "Already Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ── Yes branch: Mark Task as "Completed" ──────────────────────────
            task.IsCompleted = true;

            // ── Is task "Easy"? Yes → Add +20 exp ────────────────────────────
            // ── Is task "Medium"? Yes → Add +30 exp ──────────────────────────
            // ── Is task "Hard"? Yes → Add +50 exp ────────────────────────────
            int expGain = task.Difficulty switch
            {
                "Easy" => 20,
                "Medium" => 30,
                "Hard" => 50,
                _ => 0
            };

            // ── Apply EXP formula from flowchart ──────────────────────────────
            ApplyEXP(expGain);

            // Replace the TaskItem in the list box with a completion string
            int idx = listBox.Items.IndexOf(task);
            listBox.Items[idx] =
                $"✓  {task.Title}  [{task.Deadline:MM/dd/yyyy}]  (+{expGain} EXP)";

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
        // EXP FORMULA:
        //   1. exp = exp + amount  (no upper limit on EXP)
        //   2. exp >= (currentLevel + 1) * 100?
        //        Yes → currentLevel + 1 → loop back (stops at Level 100)
        //        No  → continue
        // =====================================================================
        private const int MaxLevel = 100;

        private static void ApplyEXP(int amount)
        {
            CurrentEXP += amount;   // EXP has no cap — accumulates freely

            // ── Level-up loop — stops at Level 100 ───────────────────────────
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
            // No branch → continue (EXP keeps accumulating even at max level)

            EXPChanged?.Invoke();
        }

        // =====================================================================
        // EXP PENALTY (missed task — top-left of flowchart: apply exp penalty -10)
        // =====================================================================
        private static void ApplyEXPPenalty(int penalty = 10)
        {
            CurrentEXP = Math.Max(0, CurrentEXP - penalty);
            EXPChanged?.Invoke();
        }

        // =====================================================================
        // DEADLINE CHECKER — fires every 60 s
        // Flowchart (top-left):
        //   missed → apply exp penalty (-10) → sort users by exp (descending)
        // =====================================================================
        private void InitDeadlineTimer()
        {
            _deadlineTimer = new System.Windows.Forms.Timer { Interval = 60_000 };
            _deadlineTimer.Tick += DeadlineTimer_Tick;
            _deadlineTimer.Start();
            DeadlineTimer_Tick(this, EventArgs.Empty); // run immediately on load
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
                    ApplyEXPPenalty(10);   // flowchart: apply exp penalty (-10)
                    anyChange = true;
                }
            }

            if (anyChange)
            {
                RefreshAllListBoxes();
                RefreshCounters();
                SortLeaderboard();         // flowchart: sort users by exp (descending)
            }
        }

        // =====================================================================
        // REFRESH LIST BOXES
        // Re-classifies difficulty as deadlines get closer each day
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

                // Re-classify — a task that was Easy yesterday may be Medium today
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
        // COUNTERS (top panels)
        // =====================================================================
        private void RefreshCounters()
        {
            // Update static counters so dashboard can read them live
            TotalCount = _allTasks.Count;
            CompletedCount = _allTasks.FindAll(t => t.IsCompleted).Count;
            MissedCount = _allTasks.FindAll(t => t.IsMissed && !t.IsCompleted).Count;

            // Update this form's labels
            numTaskDone.Text = TotalCount.ToString();
            numTaskCompleted.Text = CompletedCount.ToString();
            numTaskMissed.Text = MissedCount.ToString();

            // Notify dashboard to refresh
            EXPChanged?.Invoke();
        }

        // =====================================================================
        // LEADERBOARD SORT HOOK
        // Flowchart: "sort users by exp (descending)"
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