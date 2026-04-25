using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_leaderboard : Form
    {
        // =====================================================================
        // SINGLETON
        // =====================================================================
        private static sidebar_leaderboard? _instance;
        public static sidebar_leaderboard? Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    return null;
                return _instance;
            }
        }

        // =====================================================================
        // CONSTRUCTOR
        // =====================================================================
        public sidebar_leaderboard()
        {
            _instance = this;
            InitializeComponent();

            // ── Listen for XP changes from task form ──
            sidebar_task.EXPChanged += () =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                    this.Invoke(() => LoadLeaderboard());
            };

            LoadLeaderboard();
        }

        // =====================================================================
        // LOAD / REFRESH LEADERBOARD
        // =====================================================================
        public void LoadLeaderboard()
        {
            // Build full board using SHARED list from GameSession
            var fullBoard = new List<(string Username, int Level, int XP)>(GameSession.OtherPlayers)
            {
                (GameSession.Username, GameSession.Level, GameSession.TotalXP)
            };

            // Sort by XP descending
            fullBoard = fullBoard.OrderByDescending(p => p.XP).ToList();

            // Current week date
            label2.Text = $"Week of {GetWeekStartDate()}";

            // Rank using shared GameSession method
            int myRank = GameSession.GetCurrentRank();
            label11.Text = $"You are #{myRank} this week! Study Hard!";

            FillPodium(fullBoard);
            FillRows(fullBoard);
        }

        // =====================================================================
        // FILL TOP 3 PODIUM
        // =====================================================================
        private void FillPodium(List<(string Username, int Level, int XP)> board)
        {
            // 1st place
            if (board.Count > 0)
            {
                player1Username.Text = board[0].Username;
                player1LvlNum.Text = $"Lvl. {board[0].Level}";
                player1CurrentXP.Text = $"{board[0].XP} XP";
                player1Username.ForeColor = board[0].Username == GameSession.Username
                    ? System.Drawing.Color.Gold
                    : System.Drawing.Color.White;
            }

            // 2nd place
            if (board.Count > 1)
            {
                player2Username.Text = board[1].Username;
                player2LvlNum.Text = $"Lvl. {board[1].Level}";
                player2CurrentXP.Text = $"{board[1].XP} XP";
                player2Username.ForeColor = board[1].Username == GameSession.Username
                    ? System.Drawing.Color.Gold
                    : System.Drawing.Color.White;
            }

            // 3rd place
            if (board.Count > 2)
            {
                player3Username.Text = board[2].Username;
                player3LvlNum.Text = $"Lvl. {board[2].Level}";
                player3CurrentXP.Text = $"{board[2].XP} XP";
                player3Username.ForeColor = board[2].Username == GameSession.Username
                    ? System.Drawing.Color.Gold
                    : System.Drawing.Color.White;
            }
        }

        // =====================================================================
        // FILL ROWS 4-6
        // =====================================================================
        private void FillRows(List<(string Username, int Level, int XP)> board)
        {
            var rowLabels = new[] { player4RankInfo, player5RankInfo, player6RankInfo };

            for (int i = 3; i < 6 && i < board.Count; i++)
            {
                var player = board[i];
                rowLabels[i - 3].Text = $"{player.Username}  Lvl.{player.Level} --- {player.XP} XP";
                rowLabels[i - 3].ForeColor = player.Username == GameSession.Username
                    ? System.Drawing.Color.Gold
                    : System.Drawing.Color.White;
            }
        }

        // =====================================================================
        // WEEK DATE HELPER
        // =====================================================================
        private string GetWeekStartDate()
        {
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            return today.AddDays(-diff).ToString("MMM dd, yyyy");
        }

        // ── Designer stubs ────────────────────────────────────────────────────
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void rankCount_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void player1RankCount_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
    }
}