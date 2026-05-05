using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_avatar : Form
    {
        private enum AvatarItem { Egg, Girl, Boy, Banana }

        private AvatarItem _selectedItem = AvatarItem.Egg;
        private AvatarItem _equippedItem = AvatarItem.Egg;

        private bool _girlUnlocked = false;
        private bool _boyUnlocked = false;
        private bool _bananaUnlocked = false;

        private const int GirlPrice = 200;
        private const int BoyPrice = 200;
        private const int BananaPrice = 300;

        // 🔥 Broadcasts the applied avatar image to dashboard
        public static event Action<Image>? AvatarApplied;

        public sidebar_avatar()
        {
            InitializeComponent();

            this.Load += sidebar_avatar_Load;

            pictureBox3.Click += (s, e) => SelectItem(AvatarItem.Egg);
            pictureBox1.Click += (s, e) => SelectItem(AvatarItem.Girl);
            pictureBox2.Click += (s, e) => SelectItem(AvatarItem.Boy);
            pictureBox4.Click += (s, e) => SelectItem(AvatarItem.Banana);

            pictureBox3.Cursor = Cursors.Hand;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;

            applyButton.Click += applyButton_Click;
        }

        private void sidebar_avatar_Load(object sender, EventArgs e)
        {
            sidebar_task.EXPChanged += OnEXPChanged;
            RefreshXP();
            UpdateItemBorders();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sidebar_task.EXPChanged -= OnEXPChanged;
            base.OnFormClosing(e);
        }

        private void OnEXPChanged()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(OnEXPChanged));
            else
                RefreshXP();
        }

        private void RefreshXP()
        {
            numTotalXP.Text = $"{sidebar_task.CurrentEXP} XP";
        }

        private void SelectItem(AvatarItem item)
        {
            _selectedItem = item;
            UpdateItemBorders();

            bool isUnlocked = item switch
            {
                AvatarItem.Egg => true,
                AvatarItem.Girl => _girlUnlocked,
                AvatarItem.Boy => _boyUnlocked,
                AvatarItem.Banana => _bananaUnlocked,
                _ => false
            };

            int price = item switch
            {
                AvatarItem.Girl => GirlPrice,
                AvatarItem.Boy => BoyPrice,
                AvatarItem.Banana => BananaPrice,
                _ => 0
            };

            string itemName = item switch
            {
                AvatarItem.Egg => " Egg",
                AvatarItem.Girl => " Girl",
                AvatarItem.Boy => " Boy",
                AvatarItem.Banana => " Banana",
                _ => ""
            };

            if (item == AvatarItem.Egg)
            {
                unlockButton.Text = "Apply Avatar";
                unlockButton.Enabled = true;
                MessageBox.Show($"{itemName} — Free (Default)",
                                "Item Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (isUnlocked)
            {
                unlockButton.Text = "Apply Avatar";
                unlockButton.Enabled = true;
                MessageBox.Show($"{itemName} — Already Unlocked! ✓\nClick Apply Avatar to use it.",
                                "Item Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                unlockButton.Text = $"Unlock {price} XP";
                unlockButton.Enabled = true;
                MessageBox.Show(
                    $"{itemName}\n\n" +
                    $"Price     : {price} XP\n" +
                    $"Your XP   : {sidebar_task.CurrentEXP} XP\n" +
                    $"Status    :  Locked\n\n" +
                    $"Click 'Unlock Item' to purchase!",
                    "Item Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentXP = sidebar_task.CurrentEXP;

            bool isUnlocked = _selectedItem switch
            {
                AvatarItem.Egg => true,
                AvatarItem.Girl => _girlUnlocked,
                AvatarItem.Boy => _boyUnlocked,
                AvatarItem.Banana => _bananaUnlocked,
                _ => false
            };

            if (isUnlocked)
            {
                ApplyAvatar(_selectedItem);
                return;
            }

            int price = _selectedItem switch
            {
                AvatarItem.Girl => GirlPrice,
                AvatarItem.Boy => BoyPrice,
                AvatarItem.Banana => BananaPrice,
                _ => 0
            };

            if (currentXP < price)
            {
                MessageBox.Show(
                    $"Not enough XP!\n\n" +
                    $"You need  : {price} XP\n" +
                    $"You have  : {currentXP} XP\n" +
                    $"Still need: {price - currentXP} more XP",
                    "Insufficient XP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Unlock this avatar for {price} XP?\n\n" +
                $"Your XP after: {currentXP - price} XP",
                "Confirm Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            sidebar_task.SpendEXP(price);
            RefreshXP();

            switch (_selectedItem)
            {
                case AvatarItem.Girl: _girlUnlocked = true; break;
                case AvatarItem.Boy: _boyUnlocked = true; break;
                case AvatarItem.Banana: _bananaUnlocked = true; break;
            }

            UpdateItemBorders();
            unlockButton.Text = "Apply Avatar";

            MessageBox.Show(
                $"Avatar unlocked! 🎉\n" +
                $"-{price} XP spent\n" +
                $"Remaining XP: {sidebar_task.CurrentEXP} XP",
                "Unlocked!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ApplyAvatar(_selectedItem);
        }

        private void ApplyAvatar(AvatarItem item)
        {
            _equippedItem = item;

            Image? avatarImage = item switch
            {
                AvatarItem.Egg => pictureBox3.Image,
                AvatarItem.Girl => pictureBox1.Image,
                AvatarItem.Boy => pictureBox2.Image,
                AvatarItem.Banana => pictureBox4.Image,
                _ => null
            };

            // Update preview inside avatar panel
            pictureBox26.Image = avatarImage;
            pictureBox26.SizeMode = PictureBoxSizeMode.CenterImage;

            // 🔥 Send to dashboard_ui to update userPicture
            if (avatarImage != null)
                AvatarApplied?.Invoke(avatarImage);

            UpdateItemBorders();

            MessageBox.Show("Avatar applied! ✓",
                            "Avatar Changed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            bool isUnlocked = _selectedItem switch
            {
                AvatarItem.Egg => true,
                AvatarItem.Girl => _girlUnlocked,
                AvatarItem.Boy => _boyUnlocked,
                AvatarItem.Banana => _bananaUnlocked,
                _ => false
            };

            if (!isUnlocked)
            {
                MessageBox.Show(
                    "You haven't unlocked this avatar yet!\nClick 'Unlock Item' first.",
                    "Not Unlocked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ApplyAvatar(_selectedItem);
        }

        private void UpdateItemBorders()
        {
            pictureBox3.BackColor = Color.FromArgb(17, 28, 46);
            pictureBox1.BackColor = Color.FromArgb(17, 28, 46);
            pictureBox2.BackColor = Color.FromArgb(17, 28, 46);
            pictureBox4.BackColor = Color.FromArgb(17, 28, 46);

            PictureBox selected = _selectedItem switch
            {
                AvatarItem.Girl => pictureBox1,
                AvatarItem.Boy => pictureBox2,
                AvatarItem.Banana => pictureBox4,
                _ => pictureBox3
            };
            selected.BackColor = Color.FromArgb(80, 70, 0);

            PictureBox equipped = _equippedItem switch
            {
                AvatarItem.Girl => pictureBox1,
                AvatarItem.Boy => pictureBox2,
                AvatarItem.Banana => pictureBox4,
                _ => pictureBox3
            };
            equipped.BackColor = Color.FromArgb(20, 80, 40);

            pictureBox1.Cursor = Cursors.Hand;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void avatarPanel_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox26_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}