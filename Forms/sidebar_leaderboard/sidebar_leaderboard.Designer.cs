namespace StudyQuest
{
    partial class sidebar_leaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sidebar_leaderboard));
            label1 = new Label();
            label2 = new Label();
            player2LvlNum = new Label();
            player2CurrentXP = new Label();
            player2Username = new Label();
            player2RankCount = new Label();
            player2Picture = new PictureBox();
            player1LvlNum = new Label();
            player1CurrentXP = new Label();
            player1Username = new Label();
            player1RankCount = new Label();
            player1Picture = new PictureBox();
            player3LvlNum = new Label();
            player3CurrentXP = new Label();
            player3Username = new Label();
            player3RankCount = new Label();
            player3Picture = new PictureBox();
            label11 = new Label();
            panel4 = new Panel();
            player4RankCount = new Label();
            player4RankInfo = new Label();
            panel5 = new Panel();
            player5RankCount = new Label();
            player5RankInfo = new Label();
            panel6 = new Panel();
            player6RankCount = new Label();
            player6RankInfo = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player2Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3Picture).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixelify Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(318, 37);
            label1.TabIndex = 0;
            label1.Text = "Weekly Leaderboard";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pixelify Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 70);
            label2.Name = "label2";
            label2.Size = new Size(252, 21);
            label2.TabIndex = 1;
            label2.Text = "Week of {current week date}";
            label2.Click += label2_Click;
            // 
            // player2LvlNum
            // 
            player2LvlNum.AutoSize = true;
            player2LvlNum.BackColor = Color.FromArgb(5, 11, 38);
            player2LvlNum.Font = new Font("Pixelify Sans", 11F);
            player2LvlNum.ForeColor = Color.White;
            player2LvlNum.Location = new Point(117, 394);
            player2LvlNum.Name = "player2LvlNum";
            player2LvlNum.Size = new Size(85, 23);
            player2LvlNum.TabIndex = 4;
            player2LvlNum.Text = "{Lvl. no }";
            // 
            // player2CurrentXP
            // 
            player2CurrentXP.AutoSize = true;
            player2CurrentXP.BackColor = Color.FromArgb(5, 11, 38);
            player2CurrentXP.Font = new Font("Pixelify Sans", 11F);
            player2CurrentXP.ForeColor = Color.White;
            player2CurrentXP.Location = new Point(192, 394);
            player2CurrentXP.Name = "player2CurrentXP";
            player2CurrentXP.Size = new Size(126, 23);
            player2CurrentXP.TabIndex = 3;
            player2CurrentXP.Text = "{CurrentXP}";
            // 
            // player2Username
            // 
            player2Username.AutoSize = true;
            player2Username.BackColor = Color.FromArgb(5, 11, 38);
            player2Username.Font = new Font("Pixelify Sans", 14F);
            player2Username.ForeColor = Color.White;
            player2Username.Location = new Point(144, 355);
            player2Username.Name = "player2Username";
            player2Username.Size = new Size(150, 29);
            player2Username.TabIndex = 2;
            player2Username.Text = "{username}";
            player2Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player2RankCount
            // 
            player2RankCount.AutoSize = true;
            player2RankCount.BackColor = Color.FromArgb(5, 11, 38);
            player2RankCount.Font = new Font("Pixelify Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player2RankCount.ForeColor = Color.White;
            player2RankCount.Location = new Point(167, 318);
            player2RankCount.Name = "player2RankCount";
            player2RankCount.Size = new Size(35, 37);
            player2RankCount.TabIndex = 1;
            player2RankCount.Text = "2";
            player2RankCount.Click += rankCount_Click;
            // 
            // player2Picture
            // 
            player2Picture.BackColor = Color.FromArgb(5, 11, 38);
            player2Picture.Image = (Image)resources.GetObject("player2Picture.Image");
            player2Picture.Location = new Point(127, 177);
            player2Picture.Name = "player2Picture";
            player2Picture.Size = new Size(123, 138);
            player2Picture.SizeMode = PictureBoxSizeMode.CenterImage;
            player2Picture.TabIndex = 0;
            player2Picture.TabStop = false;
            player2Picture.Click += pictureBox1_Click;
            // 
            // player1LvlNum
            // 
            player1LvlNum.AutoSize = true;
            player1LvlNum.BackColor = Color.FromArgb(5, 11, 38);
            player1LvlNum.Font = new Font("Pixelify Sans", 12F);
            player1LvlNum.ForeColor = Color.White;
            player1LvlNum.Location = new Point(414, 340);
            player1LvlNum.Name = "player1LvlNum";
            player1LvlNum.Size = new Size(89, 24);
            player1LvlNum.TabIndex = 4;
            player1LvlNum.Text = "{Lvl. no }";
            // 
            // player1CurrentXP
            // 
            player1CurrentXP.AutoSize = true;
            player1CurrentXP.BackColor = Color.FromArgb(5, 11, 38);
            player1CurrentXP.Font = new Font("Pixelify Sans", 12F);
            player1CurrentXP.ForeColor = Color.White;
            player1CurrentXP.Location = new Point(509, 340);
            player1CurrentXP.Name = "player1CurrentXP";
            player1CurrentXP.Size = new Size(135, 24);
            player1CurrentXP.TabIndex = 3;
            player1CurrentXP.Text = "{CurrentXP}";
            // 
            // player1Username
            // 
            player1Username.AutoSize = true;
            player1Username.BackColor = Color.FromArgb(5, 11, 38);
            player1Username.Font = new Font("Pixelify Sans", 15F);
            player1Username.ForeColor = Color.White;
            player1Username.Location = new Point(473, 302);
            player1Username.Name = "player1Username";
            player1Username.Size = new Size(160, 30);
            player1Username.TabIndex = 2;
            player1Username.Text = "{username}";
            player1Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1RankCount
            // 
            player1RankCount.AutoSize = true;
            player1RankCount.BackColor = Color.FromArgb(5, 11, 38);
            player1RankCount.Font = new Font("Pixelify Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player1RankCount.ForeColor = Color.White;
            player1RankCount.Location = new Point(486, 261);
            player1RankCount.Name = "player1RankCount";
            player1RankCount.Size = new Size(32, 41);
            player1RankCount.TabIndex = 1;
            player1RankCount.Text = "1";
            player1RankCount.Click += player1RankCount_Click;
            // 
            // player1Picture
            // 
            player1Picture.BackColor = Color.FromArgb(5, 11, 38);
            player1Picture.Image = (Image)resources.GetObject("player1Picture.Image");
            player1Picture.Location = new Point(430, 139);
            player1Picture.Name = "player1Picture";
            player1Picture.Size = new Size(134, 119);
            player1Picture.SizeMode = PictureBoxSizeMode.CenterImage;
            player1Picture.TabIndex = 0;
            player1Picture.TabStop = false;
            // 
            // player3LvlNum
            // 
            player3LvlNum.AutoSize = true;
            player3LvlNum.BackColor = Color.FromArgb(5, 11, 38);
            player3LvlNum.Font = new Font("Pixelify Sans", 11F);
            player3LvlNum.ForeColor = Color.White;
            player3LvlNum.Location = new Point(747, 406);
            player3LvlNum.Name = "player3LvlNum";
            player3LvlNum.Size = new Size(85, 23);
            player3LvlNum.TabIndex = 4;
            player3LvlNum.Text = "{Lvl. no }";
            // 
            // player3CurrentXP
            // 
            player3CurrentXP.AutoSize = true;
            player3CurrentXP.BackColor = Color.FromArgb(5, 11, 38);
            player3CurrentXP.Font = new Font("Pixelify Sans", 11F);
            player3CurrentXP.ForeColor = Color.White;
            player3CurrentXP.Location = new Point(838, 406);
            player3CurrentXP.Name = "player3CurrentXP";
            player3CurrentXP.Size = new Size(126, 23);
            player3CurrentXP.TabIndex = 3;
            player3CurrentXP.Text = "{CurrentXP}";
            // 
            // player3Username
            // 
            player3Username.AutoSize = true;
            player3Username.BackColor = Color.FromArgb(5, 11, 38);
            player3Username.Font = new Font("Pixelify Sans", 13F);
            player3Username.ForeColor = Color.White;
            player3Username.Location = new Point(790, 380);
            player3Username.Name = "player3Username";
            player3Username.Size = new Size(139, 26);
            player3Username.TabIndex = 2;
            player3Username.Text = "{username}";
            player3Username.TextAlign = ContentAlignment.MiddleCenter;
            player3Username.Click += player3Username_Click;
            // 
            // player3RankCount
            // 
            player3RankCount.AutoSize = true;
            player3RankCount.BackColor = Color.FromArgb(5, 11, 38);
            player3RankCount.Font = new Font("Pixelify Sans", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player3RankCount.ForeColor = Color.White;
            player3RankCount.Location = new Point(812, 351);
            player3RankCount.Name = "player3RankCount";
            player3RankCount.Size = new Size(31, 33);
            player3RankCount.TabIndex = 1;
            player3RankCount.Text = "3";
            // 
            // player3Picture
            // 
            player3Picture.BackColor = Color.FromArgb(5, 11, 38);
            player3Picture.Image = (Image)resources.GetObject("player3Picture.Image");
            player3Picture.Location = new Point(762, 230);
            player3Picture.Name = "player3Picture";
            player3Picture.Size = new Size(123, 118);
            player3Picture.SizeMode = PictureBoxSizeMode.CenterImage;
            player3Picture.TabIndex = 0;
            player3Picture.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Pixelify Sans", 11F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(565, 42);
            label11.Name = "label11";
            label11.Size = new Size(412, 23);
            label11.TabIndex = 5;
            label11.Text = "You are #{numRank} this week! Study Hard! ";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(player4RankCount);
            panel4.Controls.Add(player4RankInfo);
            panel4.Location = new Point(80, 497);
            panel4.Name = "panel4";
            panel4.Size = new Size(849, 49);
            panel4.TabIndex = 6;
            // 
            // player4RankCount
            // 
            player4RankCount.AutoSize = true;
            player4RankCount.Font = new Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player4RankCount.ForeColor = Color.White;
            player4RankCount.Location = new Point(13, 10);
            player4RankCount.Name = "player4RankCount";
            player4RankCount.Size = new Size(25, 28);
            player4RankCount.TabIndex = 5;
            player4RankCount.Text = "4";
            player4RankCount.Click += label14_Click;
            // 
            // player4RankInfo
            // 
            player4RankInfo.AutoSize = true;
            player4RankInfo.Font = new Font("Pixelify Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player4RankInfo.ForeColor = Color.White;
            player4RankInfo.Location = new Point(45, 13);
            player4RankInfo.Name = "player4RankInfo";
            player4RankInfo.Size = new Size(397, 24);
            player4RankInfo.TabIndex = 3;
            player4RankInfo.Text = "{username}{Lvl} --- {player4TotalXP} XP";
            player4RankInfo.Click += label6_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(player5RankCount);
            panel5.Controls.Add(player5RankInfo);
            panel5.Location = new Point(78, 578);
            panel5.Name = "panel5";
            panel5.Size = new Size(849, 49);
            panel5.TabIndex = 7;
            // 
            // player5RankCount
            // 
            player5RankCount.AutoSize = true;
            player5RankCount.Font = new Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player5RankCount.ForeColor = Color.White;
            player5RankCount.Location = new Point(15, 10);
            player5RankCount.Name = "player5RankCount";
            player5RankCount.Size = new Size(25, 28);
            player5RankCount.TabIndex = 6;
            player5RankCount.Text = "5";
            // 
            // player5RankInfo
            // 
            player5RankInfo.AutoSize = true;
            player5RankInfo.Font = new Font("Pixelify Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player5RankInfo.ForeColor = Color.White;
            player5RankInfo.Location = new Point(45, 13);
            player5RankInfo.Name = "player5RankInfo";
            player5RankInfo.Size = new Size(398, 24);
            player5RankInfo.TabIndex = 3;
            player5RankInfo.Text = "{username} {Lvl}--- {player5TotalXP} XP";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(player6RankCount);
            panel6.Controls.Add(player6RankInfo);
            panel6.Location = new Point(80, 657);
            panel6.Name = "panel6";
            panel6.Size = new Size(849, 49);
            panel6.TabIndex = 8;
            // 
            // player6RankCount
            // 
            player6RankCount.AutoSize = true;
            player6RankCount.Font = new Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player6RankCount.ForeColor = Color.White;
            player6RankCount.Location = new Point(13, 10);
            player6RankCount.Name = "player6RankCount";
            player6RankCount.Size = new Size(25, 28);
            player6RankCount.TabIndex = 6;
            player6RankCount.Text = "6";
            // 
            // player6RankInfo
            // 
            player6RankInfo.AutoSize = true;
            player6RankInfo.Font = new Font("Pixelify Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player6RankInfo.ForeColor = Color.White;
            player6RankInfo.Location = new Point(45, 13);
            player6RankInfo.Name = "player6RankInfo";
            player6RankInfo.Size = new Size(398, 24);
            player6RankInfo.TabIndex = 3;
            player6RankInfo.Text = "{username} {Lvl}--- {player6TotalXP} XP";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(379, 107);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(242, 342);
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 287);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(715, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 241);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(167, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(839, 747);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // sidebar_leaderboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1006, 744);
            Controls.Add(player3LvlNum);
            Controls.Add(player3CurrentXP);
            Controls.Add(player2LvlNum);
            Controls.Add(player3Username);
            Controls.Add(player2CurrentXP);
            Controls.Add(player3RankCount);
            Controls.Add(player1LvlNum);
            Controls.Add(player3Picture);
            Controls.Add(player2Username);
            Controls.Add(player1CurrentXP);
            Controls.Add(player2RankCount);
            Controls.Add(panel6);
            Controls.Add(player2Picture);
            Controls.Add(player1Username);
            Controls.Add(panel5);
            Controls.Add(player1RankCount);
            Controls.Add(panel4);
            Controls.Add(player1Picture);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sidebar_leaderboard";
            Text = "sidebar_leaderboard";
            Load += sidebar_leaderboard_Load;
            ((System.ComponentModel.ISupportInitialize)player2Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3Picture).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label player2RankCount;
        private PictureBox player2Picture;
        private Label player2LvlNum;
        private Label player2CurrentXP;
        private Label player2Username;
        private Label player1LvlNum;
        private Label player1CurrentXP;
        private Label player1Username;
        private Label player1RankCount;
        private PictureBox player1Picture;
        private Label player3LvlNum;
        private Label player3CurrentXP;
        private Label player3Username;
        private Label player3RankCount;
        private PictureBox player3Picture;
        private Label label11;
        private Panel panel4;
        private Label player4RankInfo;
        private Label player4RankCount;
        private Panel panel5;
        private Label player5RankInfo;
        private Panel panel6;
        private Label player6RankInfo;
        private Label player5RankCount;
        private Label player6RankCount;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}