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
            pictureBox1 = new PictureBox();
            player2RankCount = new Label();
            player2Username = new Label();
            player2CurrentXP = new Label();
            player2LvlNum = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            player1RankCount = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            label12 = new Label();
            panel6 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(78, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 287);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(player1RankCount);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(380, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 342);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Urbanist", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 243);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 4;
            label3.Text = "{Lvl. no }";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Urbanist", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(118, 243);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 3;
            label4.Text = "{CurrentXP}";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Urbanist", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 203);
            label5.Name = "label5";
            label5.Size = new Size(117, 26);
            label5.TabIndex = 2;
            label5.Text = "{username}";
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
            // pictureBox2
            // 
            pictureBox2.Location = new Point(60, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 106);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(715, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 234);
            panel3.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Urbanist", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(15, 183);
            label7.Name = "label7";
            label7.Size = new Size(75, 22);
            label7.TabIndex = 4;
            label7.Text = "{Lvl. no }";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Urbanist", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(96, 183);
            label8.Name = "label8";
            label8.Size = new Size(101, 22);
            label8.TabIndex = 3;
            label8.Text = "{CurrentXP}";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Urbanist", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(44, 157);
            label9.Name = "label9";
            label9.Size = new Size(117, 26);
            label9.TabIndex = 2;
            label9.Text = "{username}";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Urbanist", 16F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(96, 124);
            label10.Name = "label10";
            label10.Size = new Size(28, 36);
            label10.TabIndex = 1;
            label10.Text = "3";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(44, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(123, 106);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
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
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(80, 497);
            panel4.Name = "panel4";
            panel4.Size = new Size(849, 49);
            panel4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Urbanist", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 13);
            label6.Name = "label6";
            label6.Size = new Size(335, 26);
            label6.TabIndex = 3;
            label6.Text = "{username} --- {player4TotalXP} XP";
            label6.Click += label6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(78, 578);
            panel5.Name = "panel5";
            panel5.Size = new Size(849, 49);
            panel5.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Urbanist", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(45, 13);
            label12.Name = "label12";
            label12.Size = new Size(335, 26);
            label12.TabIndex = 3;
            label12.Text = "{username} --- {player4TotalXP} XP";
            // 
            // panel6
            // 
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(80, 657);
            panel6.Name = "panel6";
            panel6.Size = new Size(849, 49);
            panel6.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Urbanist", 12F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(45, 13);
            label13.Name = "label13";
            label13.Size = new Size(335, 26);
            label13.TabIndex = 3;
            label13.Text = "{username} --- {player4TotalXP} XP";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Urbanist", 14F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(13, 10);
            label14.Name = "label14";
            label14.Size = new Size(27, 31);
            label14.TabIndex = 5;
            label14.Text = "4";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Urbanist", 14F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(15, 10);
            label15.Name = "label15";
            label15.Size = new Size(27, 31);
            label15.TabIndex = 6;
            label15.Text = "5";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Urbanist", 14F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(13, 10);
            label16.Name = "label16";
            label16.Size = new Size(27, 31);
            label16.TabIndex = 6;
            label16.Text = "6";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private Label player2LvlNum;
        private Label player2CurrentXP;
        private Label player2Username;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label player1RankCount;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox3;
        private Label label11;
        private Panel panel4;
        private Label label6;
        private Label label14;
        private Panel panel5;
        private Label label12;
        private Panel panel6;
        private Label label13;
        private Label label15;
        private Label label16;
    }
}