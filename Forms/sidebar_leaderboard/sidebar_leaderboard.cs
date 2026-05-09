using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_leaderboard : Form
    {
        private static sidebar_leaderboard? _instance;
        private Image? _myAvatarImage = null;

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

            sidebar_avatar.AvatarApplied += OnAvatarApplied;

            LoadSavedAvatar();

            LoadLeaderboard();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sidebar_avatar.AvatarApplied -= OnAvatarApplied;
            base.OnFormClosing(e);
        }

        private void LoadSavedAvatar()
        {
            try
            {
                var data = AvatarDatabase.Load();

                sidebar_avatar? avatarForm = null;
                bool ownedInstance = false;

                if (sidebar_avatar.AvatarFormInstance != null &&
                    !sidebar_avatar.AvatarFormInstance.IsDisposed)
                {
                    avatarForm = sidebar_avatar.AvatarFormInstance;
                }
                else
                {
                    avatarForm = new sidebar_avatar();
                    ownedInstance = true;
                }

                _myAvatarImage = data.EquippedAvatar switch
                {
                    "Girl" => avatarForm.GetGirlImage(),
                    "Boy" => avatarForm.GetBoyImage(),
                    "Banana" => avatarForm.GetBananaImage(),
                    _ => avatarForm.GetEggImage()
                };

                if (ownedInstance)
                    avatarForm.Dispose();
            }
            catch
            {
                // leave _myAvatarImage as null if anything fails
            }
        }

        private void OnAvatarApplied(Image avatarImage)
        {
            if (this.InvokeRequired)
                this.Invoke(() => OnAvatarApplied(avatarImage));
            else
            {
                _myAvatarImage = avatarImage;
                LoadLeaderboard();
            }
        }

        public void LoadLeaderboard()
        {
            var fullBoard = new List<(string Username, int Level, int XP)>(GameSession.OtherPlayers)
            {
                (GameSession.Username, GameSession.Level, sidebar_task.TotalEarnedEXP)
            };

            fullBoard = fullBoard.OrderByDescending(p => p.XP).ToList();

            label2.Text = $"Week of {GetWeekStartDate()}";

            int myRank = fullBoard.FindIndex(p => p.Username == GameSession.Username) + 1;
            label11.Text = $"You are #{myRank} this week! Study Hard!";

            FillPodium(fullBoard);
            FillRows(fullBoard);
        }

        private void FillPodium(List<(string Username, int Level, int XP)> board)
        {
            // --- Rank 1 ---
            if (board.Count > 0)
            {
                var p = board[0];
                player1Username.Text = p.Username;
                player1LvlNum.Text = $"Lvl. {p.Level}";
                player1CurrentXP.Text = $"{p.XP} XP";
                player1Username.ForeColor = p.Username == GameSession.Username
                    ? Color.Gold : Color.White;

                if (p.Username == GameSession.Username && _myAvatarImage != null)
                {
                    player1Picture.Image = _myAvatarImage;
                    player1Picture.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            // --- Rank 2 ---
            if (board.Count > 1)
            {
                var p = board[1];
                player2Username.Text = p.Username;
                player2LvlNum.Text = $"Lvl. {p.Level}";
                player2CurrentXP.Text = $"{p.XP} XP";
                player2Username.ForeColor = p.Username == GameSession.Username
                    ? Color.Gold : Color.White;

                if (p.Username == GameSession.Username && _myAvatarImage != null)
                {
                    player2Picture.Image = _myAvatarImage;
                    player2Picture.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            // --- Rank 3 ---
            if (board.Count > 2)
            {
                var p = board[2];
                player3Username.Text = p.Username;
                player3LvlNum.Text = $"Lvl. {p.Level}";
                player3CurrentXP.Text = $"{p.XP} XP";
                player3Username.ForeColor = p.Username == GameSession.Username
                    ? Color.Gold : Color.White;

                if (p.Username == GameSession.Username && _myAvatarImage != null)
                {
                    player3Picture.Image = _myAvatarImage;
                    player3Picture.SizeMode = PictureBoxSizeMode.Zoom;
                }
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
                    ? Color.Gold : Color.White;
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
        private void sidebar_leaderboard_Load(object sender, EventArgs e) { }
        private void player3Username_Click(object sender, EventArgs e) { }
    }
}