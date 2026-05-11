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

        public static event Action<Image>? AvatarApplied;
        public static sidebar_avatar? AvatarFormInstance { get; private set; }

        public Image? GetEggImage() => pictureBox3.Image;
        public Image? GetGirlImage() => pictureBox1.Image;
        public Image? GetBoyImage() => pictureBox2.Image;
        public Image? GetBananaImage() => pictureBox4.Image;

        public sidebar_avatar()
        {
            AvatarFormInstance = this;
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
            LoadFromDatabase();
            RefreshXP();
            UpdateItemBorders();
            UpdateUnlockButton();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            AvatarFormInstance = null;
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

        private void LoadFromDatabase()
        {
            var data = AvatarDatabase.Load();

            _girlUnlocked = data.GirlUnlocked;
            _boyUnlocked = data.BoyUnlocked;
            _bananaUnlocked = data.BananaUnlocked;

            textBox1.Text = data.AvatarName ?? "";

            _equippedItem = data.EquippedAvatar switch
            {
                "Girl" => AvatarItem.Girl,
                "Boy" => AvatarItem.Boy,
                "Banana" => AvatarItem.Banana,
                _ => AvatarItem.Egg
            };

            _selectedItem = _equippedItem;

            Image? avatarImage = _equippedItem switch
            {
                AvatarItem.Girl => pictureBox1.Image,
                AvatarItem.Boy => pictureBox2.Image,
                AvatarItem.Banana => pictureBox4.Image,
                _ => pictureBox3.Image
            };

            if (avatarImage != null)
            {
                pictureBox26.Image = avatarImage;
                pictureBox26.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void SaveToDatabase()
        {
            var data = new AvatarData
            {
                EquippedAvatar = _equippedItem.ToString(),
                GirlUnlocked = _girlUnlocked,
                BoyUnlocked = _boyUnlocked,
                BananaUnlocked = _bananaUnlocked,
                AvatarName = textBox1.Text
            };

            AvatarDatabase.Save(data);
        }

        private void RefreshXP()
        {
            numTotalXP.Text = $"{sidebar_task.CurrentEXP} XP";
        }

        private void UpdateUnlockButton()
        {
            bool isUnlocked = _selectedItem switch
            {
                AvatarItem.Egg => true,
                AvatarItem.Girl => _girlUnlocked,
                AvatarItem.Boy => _boyUnlocked,
                AvatarItem.Banana => _bananaUnlocked,
                _ => false
            };

            int price = _selectedItem switch
            {
                AvatarItem.Girl => GirlPrice,
                AvatarItem.Boy => BoyPrice,
                AvatarItem.Banana => BananaPrice,
                _ => 0
            };

            if (_selectedItem == AvatarItem.Egg || isUnlocked)
            {
                unlockButton.Visible = false;
                unlockButton.Enabled = false;
            }
            else
            {
                unlockButton.Visible = true;
                unlockButton.Enabled = true;
                unlockButton.Text = $"Unlock {price} XP";
            }
        }

        private void SelectItem(AvatarItem item)
        {
            _selectedItem = item;
            UpdateItemBorders();
            UpdateUnlockButton();

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
                MessageBox.Show($"{itemName} — Free (Default)\nClick Apply Avatar to use it.",
                                "Item Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (isUnlocked)
            {
                MessageBox.Show($"{itemName} — Already Unlocked! ✓\nClick Apply Avatar to use it.",
                                "Item Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"{itemName}\n\n" +
                    $"Price     : {price} XP\n" +
                    $"Your XP   : {sidebar_task.CurrentEXP} XP\n" +
                    $"Status    :  Locked\n\n" +
                    $"Click 'Unlock {price} XP' to purchase!",
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

            UpdateUnlockButton();
            UpdateItemBorders();
            SaveToDatabase();

            MessageBox.Show(
                $"Avatar unlocked! \n" +
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

            pictureBox26.Image = avatarImage;
            pictureBox26.SizeMode = PictureBoxSizeMode.Zoom;

            if (avatarImage != null)
                AvatarApplied?.Invoke(avatarImage);

            UpdateItemBorders();
            SaveToDatabase();

            MessageBox.Show("Avatar applied! ",
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
            pictureBox3.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox1.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox2.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox4.BackColor = Color.FromArgb(5, 11, 38);

            PictureBox selected = _selectedItem switch
            {
                AvatarItem.Girl => pictureBox1,
                AvatarItem.Boy => pictureBox2,
                AvatarItem.Banana => pictureBox4,
                _ => pictureBox3
            };
            selected.BackColor = Color.FromArgb(0, 183, 239);

            PictureBox equipped = _equippedItem switch
            {
                AvatarItem.Girl => pictureBox1,
                AvatarItem.Boy => pictureBox2,
                AvatarItem.Banana => pictureBox4,
                _ => pictureBox3
            };
            equipped.BackColor = Color.FromArgb(160, 130, 250);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void avatarPanel_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox26_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveToDatabase();
        }
        private void pictureBox27_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox28_Click(object sender, EventArgs e) { }
    }
}