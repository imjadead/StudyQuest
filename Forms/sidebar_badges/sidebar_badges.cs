using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_badges : Form
    {
        // =====================================================================
        // BADGE DEFINITIONS
        // Panel     | Badge Name              | Condition
        // panel3    | First Task? yey!        | CompletedCount >= 1
        // panel1    | Consistency             | streakDays >= 7
        // panel2    | I'm On Fire!            | streakDays >= 50
        // panel4    | Can't Stop Me~          | streakDays >= 100
        // panel8    | Just Starting...        | CurrentEXP >= 100
        // panel7    | Do I Know Everything?   | CurrentEXP >= 10000
        // panel6    | Master? That's Me.      | CurrentLevel >= 30
        // panel5    | Legendary!!!            | CurrentLevel >= 60
        // =====================================================================

        private int unlockedCount = 0;

        public sidebar_badges()
        {
            InitializeComponent();
            sidebar_task.EXPChanged += OnEXPChanged;
            CheckBadges();
        }

        // =====================================================================
        // CALLED WHEN EXP CHANGES
        // =====================================================================
        private void OnEXPChanged()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(OnEXPChanged));
            else
                CheckBadges();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sidebar_task.EXPChanged -= OnEXPChanged;
            base.OnFormClosing(e);
        }

        // =====================================================================
        // CHECK ALL BADGES
        // =====================================================================
        private void CheckBadges()
        {
            unlockedCount = 0;

            int completedTasks = sidebar_task.CompletedCount;
            int currentEXP = sidebar_task.CurrentEXP;
            int currentLevel = sidebar_task.CurrentLevel;
            int streakDays = GameSession.StreakDays;

            // ── Badge 1: First Task? yey! ─────────────────────────────────────
            ApplyBadge(panel3, completedTasks >= 1);

            // ── Badge 2: Consistency (7 day streak) ───────────────────────────
            ApplyBadge(panel1, streakDays >= 7);

            // ── Badge 3: I'm On Fire! (50 day streak) ─────────────────────────
            ApplyBadge(panel2, streakDays >= 50);

            // ── Badge 4: Can't Stop Me~ (100 day streak) ──────────────────────
            ApplyBadge(panel4, streakDays >= 100);

            // ── Badge 5: Just Starting... (100 XP) ───────────────────────────
            ApplyBadge(panel8, currentEXP >= 100);

            // ── Badge 6: Do I Know Everything Now? (10000 XP) ────────────────
            ApplyBadge(panel7, currentEXP >= 10000);

            // ── Badge 7: Master? That's Me. (Level 30) ────────────────────────
            ApplyBadge(panel6, currentLevel >= 30);

            // ── Badge 8: Legendary!!! (Level 60) ─────────────────────────────
            ApplyBadge(panel5, currentLevel >= 60);

            // ── Update counter label ──────────────────────────────────────────
            label2.Text = $"{unlockedCount} out of 8 Badges Unlocked! " +
                          (unlockedCount == 8 ? "Amazing! 🏆" : "Keep it up!");
        }

        // =====================================================================
        // APPLY BADGE VISUAL
        // Unlocked = gold border + bright text
        // Locked   = dim border + dim text
        // =====================================================================
        private void ApplyBadge(Panel panel, bool unlocked)
        {
            if (unlocked)
            {
                unlockedCount++;

                // ── Gold border ───────────────────────────────────────────────
                panel.BackColor = Color.FromArgb(40, 35, 10);
                panel.BorderStyle = BorderStyle.Fixed3D;

                // ── Brighten all labels inside ────────────────────────────────
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Label lbl)
                        lbl.ForeColor = Color.Gold;

                    if (ctrl is PictureBox pb)
                        pb.BackColor = Color.FromArgb(80, 70, 0);
                }

                // ── Add UNLOCKED stamp if not already there ───────────────────
                bool alreadyStamped = false;
                foreach (Control ctrl in panel.Controls)
                    if (ctrl is Label l && l.Name == "lblUnlocked")
                        alreadyStamped = true;

                if (!alreadyStamped)
                {
                    var stamp = new Label
                    {
                        Name = "lblUnlocked",
                        Text = "✅ UNLOCKED",
                        Font = new Font("Pixelify Sans", 8F, FontStyle.Bold),
                        ForeColor = Color.LimeGreen,
                        BackColor = Color.Transparent,
                        AutoSize = true,
                        Location = new Point(50, 210)
                    };
                    panel.Controls.Add(stamp);
                }
            }
            else
            {
                // ── Locked — dim everything ───────────────────────────────────
                panel.BackColor = Color.FromArgb(15, 23, 42);

                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Label lbl && lbl.Name != "lblUnlocked")
                        lbl.ForeColor = Color.FromArgb(100, 100, 120);

                    if (ctrl is PictureBox pb)
                        pb.BackColor = Color.FromArgb(25, 30, 50);
                }

                // ── Remove UNLOCKED stamp if badge was revoked ────────────────
                Control? toRemove = null;
                foreach (Control ctrl in panel.Controls)
                    if (ctrl is Label l && l.Name == "lblUnlocked")
                        toRemove = ctrl;

                if (toRemove != null)
                    panel.Controls.Remove(toRemove);
            }
        }

        // ── Stubs ─────────────────────────────────────────────────────────────
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void player3Username_Click(object sender, EventArgs e) { }
    }
}