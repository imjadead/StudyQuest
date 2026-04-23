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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            player2Picture = new PictureBox();
            player2RankCount = new Label();
            player2Username = new Label();
            player2CurrentXP = new Label();
            player2LvlNum = new Label();
            panel2 = new Panel();
            player1LvlNum = new Label();
            player1CurrentXP = new Label();
            player1Username = new Label();
            player1RankCount = new Label();
            player1Picture = new PictureBox();
            panel3 = new Panel();
            player3LvlNum = new Label();
            player3CurrentXP = new Label();
            player3Username = new Label();
            player3RankCount = new Label();
            player3Picture = new PictureBox();
            label11 = new Label();
            panel4 = new Panel();
            player4RankInfo = new Label();
            panel5 = new Panel();
            player5RankInfo = new Label();
            panel6 = new Panel();
            player6RankInfo = new Label();
            player4RankCount = new Label();
            player5RankCount = new Label();
            player6RankCount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player2Picture).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player1Picture).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player3Picture).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urbanist", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(295, 39);
            label1.TabIndex = 0;
            label1.Text = "Weekly Leaderboard";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Urbanist", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 70);
            label2.Name = "label2";
            label2.Size = new Size(225, 22);
            label2.TabIndex = 1;
            label2.Text = "Week of {current week date}";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(player2LvlNum);
            panel1.Controls.Add(player2CurrentXP);
            panel1.Controls.Add(player2Username);
            panel1.Controls.Add(player2RankCount);
            panel1.Controls.Add(player2Picture);
            panel1.Location = new Point(78, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 287);
            panel1.TabIndex = 2;
            // 
            // player2Picture
            // 
            player2Picture.Location = new Point(45, 29);
            player2Picture.Name = "player2Picture";
            player2Picture.Size = new Size(123, 106);
            player2Picture.TabIndex = 0;
            player2Picture.TabStop = false;
            player2Picture.Click += pictureBox1_Click;
            // 
            // player2RankCount
            // 
            player2RankCount.AutoSize = true;
            player2RankCount.Font = new Font("Urbanist", 18F);
            player2RankCount.ForeColor = Color.White;
            player2RankCount.Location = new Point(87, 138);
            player2RankCount.Name = "player2RankCount";
            player2RankCount.Size = new Size(33, 39);
            player2RankCount.TabIndex = 1;
            player2RankCount.Text = "2";
            player2RankCount.Click += rankCount_Click;
            // 
            // player2Username
            // 
            player2Username.AutoSize = true;
            player2Username.Font = new Font("Urbanist", 12F);
            player2Username.ForeColor = Color.White;
            player2Username.Location = new Point(45, 174);
            player2Username.Name = "player2Username";
            player2Username.Size = new Size(117, 26);
            player2Username.TabIndex = 2;
            player2Username.Text = "{username}";
            // 
            // player2CurrentXP
            // 
            player2CurrentXP.AutoSize = true;
            player2CurrentXP.Font = new Font("Urbanist", 10F);
            player2CurrentXP.ForeColor = Color.White;
            player2CurrentXP.Location = new Point(100, 220);
            player2CurrentXP.Name = "player2CurrentXP";
            player2CurrentXP.Size = new Size(101, 22);
            player2CurrentXP.TabIndex = 3;
            player2CurrentXP.Text = "{CurrentXP}";
            // 
            // player2LvlNum
            // 
            player2LvlNum.AutoSize = true;
            player2LvlNum.Font = new Font("Urbanist", 10F);
            player2LvlNum.ForeColor = Color.White;
            player2LvlNum.Location = new Point(19, 220);
            player2LvlNum.Name = "player2LvlNum";
            player2LvlNum.Size = new Size(75, 22);
            player2LvlNum.TabIndex = 4;
            player2LvlNum.Text = "{Lvl. no }";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(player1LvlNum);
            panel2.Controls.Add(player1CurrentXP);
            panel2.Controls.Add(player1Username);
            panel2.Controls.Add(player1RankCount);
            panel2.Controls.Add(player1Picture);
            panel2.Location = new Point(380, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 342);
            panel2.TabIndex = 3;
            // 
            // player1LvlNum
            // 
            player1LvlNum.AutoSize = true;
            player1LvlNum.Font = new Font("Urbanist", 10F);
            player1LvlNum.ForeColor = Color.White;
            player1LvlNum.Location = new Point(37, 243);
            player1LvlNum.Name = "player1LvlNum";
            player1LvlNum.Size = new Size(75, 22);
            player1LvlNum.TabIndex = 4;
            player1LvlNum.Text = "{Lvl. no }";
            // 
            // player1CurrentXP
            // 
            player1CurrentXP.AutoSize = true;
            player1CurrentXP.Font = new Font("Urbanist", 10F);
            player1CurrentXP.ForeColor = Color.White;
            player1CurrentXP.Location = new Point(118, 243);
            player1CurrentXP.Name = "player1CurrentXP";
            player1CurrentXP.Size = new Size(101, 22);
            player1CurrentXP.TabIndex = 3;
            player1CurrentXP.Text = "{CurrentXP}";
            // 
            // player1Username
            // 
            player1Username.AutoSize = true;
            player1Username.Font = new Font("Urbanist", 12F);
            player1Username.ForeColor = Color.White;
            player1Username.Location = new Point(60, 203);
            player1Username.Name = "player1Username";
            player1Username.Size = new Size(117, 26);
            player1Username.TabIndex = 2;
            player1Username.Text = "{username}";
            // 
            // player1RankCount
            // 
            player1RankCount.AutoSize = true;
            player1RankCount.Font = new Font("Urbanist", 20F);
            player1RankCount.ForeColor = Color.White;
            player1RankCount.Location = new Point(107, 164);
            player1RankCount.Name = "player1RankCount";
            player1RankCount.Size = new Size(28, 44);
            player1RankCount.TabIndex = 1;
            player1RankCount.Text = "1";
            player1RankCount.Click += player1RankCount_Click;
            // 
            // player1Picture
            // 
            player1Picture.Location = new Point(60, 55);
            player1Picture.Name = "player1Picture";
            player1Picture.Size = new Size(123, 106);
            player1Picture.TabIndex = 0;
            player1Picture.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(player3LvlNum);
            panel3.Controls.Add(player3CurrentXP);
            panel3.Controls.Add(player3Username);
            panel3.Controls.Add(player3RankCount);
            panel3.Controls.Add(player3Picture);
            panel3.Location = new Point(715, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 241);
            panel3.TabIndex = 4;
            // 
            // player3LvlNum
            // 
            player3LvlNum.AutoSize = true;
            player3LvlNum.Font = new Font("Urbanist", 10F);
            player3LvlNum.ForeColor = Color.White;
            player3LvlNum.Location = new Point(13, 193);
            player3LvlNum.Name = "player3LvlNum";
            player3LvlNum.Size = new Size(75, 22);
            player3LvlNum.TabIndex = 4;
            player3LvlNum.Text = "{Lvl. no }";
            // 
            // player3CurrentXP
            // 
            player3CurrentXP.AutoSize = true;
            player3CurrentXP.Font = new Font("Urbanist", 10F);
            player3CurrentXP.ForeColor = Color.White;
            player3CurrentXP.Location = new Point(94, 193);
            player3CurrentXP.Name = "player3CurrentXP";
            player3CurrentXP.Size = new Size(101, 22);
            player3CurrentXP.TabIndex = 3;
            player3CurrentXP.Text = "{CurrentXP}";
            // 
            // player3Username
            // 
            player3Username.AutoSize = true;
            player3Username.Font = new Font("Urbanist", 12F);
            player3Username.ForeColor = Color.White;
            player3Username.Location = new Point(42, 167);
            player3Username.Name = "player3Username";
            player3Username.Size = new Size(117, 26);
            player3Username.TabIndex = 2;
            player3Username.Text = "{username}";
            // 
            // player3RankCount
            // 
            player3RankCount.AutoSize = true;
            player3RankCount.Font = new Font("Urbanist", 16F);
            player3RankCount.ForeColor = Color.White;
            player3RankCount.Location = new Point(94, 134);
            player3RankCount.Name = "player3RankCount";
            player3RankCount.Size = new Size(28, 36);
            player3RankCount.TabIndex = 1;
            player3RankCount.Text = "3";
            // 
            // player3Picture
            // 
            player3Picture.Location = new Point(42, 22);
            player3Picture.Name = "player3Picture";
            player3Picture.Size = new Size(123, 106);
            player3Picture.TabIndex = 0;
            player3Picture.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Urbanist", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(604, 44);
            label11.Name = "label11";
            label11.Size = new Size(357, 24);
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
            // player4RankInfo
            // 
            player4RankInfo.AutoSize = true;
            player4RankInfo.Font = new Font("Urbanist", 12F);
            player4RankInfo.ForeColor = Color.White;
            player4RankInfo.Location = new Point(45, 13);
            player4RankInfo.Name = "player4RankInfo";
            player4RankInfo.Size = new Size(335, 26);
            player4RankInfo.TabIndex = 3;
            player4RankInfo.Text = "{username} --- {player4TotalXP} XP";
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
            // player5RankInfo
            // 
            player5RankInfo.AutoSize = true;
            player5RankInfo.Font = new Font("Urbanist", 12F);
            player5RankInfo.ForeColor = Color.White;
            player5RankInfo.Location = new Point(45, 13);
            player5RankInfo.Name = "player5RankInfo";
            player5RankInfo.Size = new Size(335, 26);
            player5RankInfo.TabIndex = 3;
            player5RankInfo.Text = "{username} --- {player4TotalXP} XP";
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
            // player6RankInfo
            // 
            player6RankInfo.AutoSize = true;
            player6RankInfo.Font = new Font("Urbanist", 12F);
            player6RankInfo.ForeColor = Color.White;
            player6RankInfo.Location = new Point(45, 13);
            player6RankInfo.Name = "player6RankInfo";
            player6RankInfo.Size = new Size(335, 26);
            player6RankInfo.TabIndex = 3;
            player6RankInfo.Text = "{username} --- {player4TotalXP} XP";
            // 
            // player4RankCount
            // 
            player4RankCount.AutoSize = true;
            player4RankCount.Font = new Font("Urbanist", 14F);
            player4RankCount.ForeColor = Color.White;
            player4RankCount.Location = new Point(13, 10);
            player4RankCount.Name = "player4RankCount";
            player4RankCount.Size = new Size(27, 31);
            player4RankCount.TabIndex = 5;
            player4RankCount.Text = "4";
            player4RankCount.Click += label14_Click;
            // 
            // player5RankCount
            // 
            player5RankCount.AutoSize = true;
            player5RankCount.Font = new Font("Urbanist", 14F);
            player5RankCount.ForeColor = Color.White;
            player5RankCount.Location = new Point(15, 10);
            player5RankCount.Name = "player5RankCount";
            player5RankCount.Size = new Size(27, 31);
            player5RankCount.TabIndex = 6;
            player5RankCount.Text = "5";
            // 
            // player6RankCount
            // 
            player6RankCount.AutoSize = true;
            player6RankCount.Font = new Font("Urbanist", 14F);
            player6RankCount.ForeColor = Color.White;
            player6RankCount.Location = new Point(13, 10);
            player6RankCount.Name = "player6RankCount";
            player6RankCount.Size = new Size(27, 31);
            player6RankCount.TabIndex = 6;
            player6RankCount.Text = "6";
            // 
            // sidebar_leaderboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1011, 744);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sidebar_leaderboard";
            Text = "sidebar_leaderboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player2Picture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player1Picture).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player3Picture).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label player2RankCount;
        private PictureBox player2Picture;
        private Label player2LvlNum;
        private Label player2CurrentXP;
        private Label player2Username;
        private Panel panel2;
        private Label player1LvlNum;
        private Label player1CurrentXP;
        private Label player1Username;
        private Label player1RankCount;
        private PictureBox player1Picture;
        private Panel panel3;
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
    }
}