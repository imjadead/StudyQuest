using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_leaderboard : Form
    {
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

        public sidebar_leaderboard()
        {
            _instance = this;
            InitializeComponent();

            sidebar_task.EXPChanged += () =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                    this.Invoke(() => LoadLeaderboard());
            };

            LoadLeaderboard();
        }

        public void LoadLeaderboard()
        {
            var fullBoard = new List<(string Username, int Level, int XP)>(GameSession.OtherPlayers)
            {
                (GameSession.Username, GameSession.Level, GameSession.TotalXP)
            };

            fullBoard = fullBoard.OrderByDescending(p => p.XP).ToList();

            label2.Text = $"Week of {GetWeekStartDate()}";

            int myRank = GameSession.GetCurrentRank();
            label11.Text = $"You are #{myRank} this week! Study Hard!";

            FillPodium(fullBoard);
            FillRows(fullBoard);
        }

        private void FillPodium(List<(string Username, int Level, int XP)> board)
        {
            if (board.Count > 0)
            {
                player1Username.Text = board[0].Username;
                player1LvlNum.Text = $"Lvl. {board[0].Level}";
                player1CurrentXP.Text = $"{board[0].XP} XP";
                player1Username.ForeColor = board[0].Username == GameSession.Username
                    ? System.Drawing.Color.Gold
                    : System.Drawing.Color.White;
            }

            if (board.Count > 1)
            {
                player2Username.Text = board[1].Username;
                player2LvlNum.Text = $"Lvl. {board[1].Level}";
                player2CurrentXP.Text = $"{board[1].XP} XP";
                player2Username.ForeColor = board[1].Username == GameSession.Username
                    ? System.Drawing.Color.Gold
                    : System.Drawing.Color.White;
            }

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

        private string GetWeekStartDate()
        {
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            return today.AddDays(-diff).ToString("MMM dd, yyyy");
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void rankCount_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void player1RankCount_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }

        private void sidebar_leaderboard_Load(object sender, EventArgs e)
        {

        }
    }
}