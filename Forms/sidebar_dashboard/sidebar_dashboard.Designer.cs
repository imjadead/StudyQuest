namespace StudyQuest
{
    partial class sidebar_dashboard
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
            greetingsUser = new Label();
            pnlTotalXP = new Panel();
            panel1 = new Panel();
            numTotalXP = new Label();
            totalXPText = new Label();
            label8 = new Label();
            totalXP = new Label();
            mustDOListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dayStreakText = new Label();
            numDayStreak = new Label();
            panel2 = new Panel();
            numTaskDone = new Label();
            taskDonetext = new Label();
            panel3 = new Panel();
            numRank = new Label();
            rankText = new Label();
            richTextBox1 = new RichTextBox();
            pnlTotalXP.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // greetingsUser
            // 
            greetingsUser.AutoSize = true;
            greetingsUser.Font = new Font("Urbanist", 18F);
            greetingsUser.ForeColor = Color.White;
            greetingsUser.Location = new Point(27, 30);
            greetingsUser.Name = "greetingsUser";
            greetingsUser.Size = new Size(318, 39);
            greetingsUser.TabIndex = 0;
            greetingsUser.Text = "Good day {username}!";
            greetingsUser.Click += label1_Click_1;
            // 
            // pnlTotalXP
            // 
            pnlTotalXP.BorderStyle = BorderStyle.Fixed3D;
            pnlTotalXP.Controls.Add(panel1);
            pnlTotalXP.Controls.Add(label8);
            pnlTotalXP.Controls.Add(totalXP);
            pnlTotalXP.Location = new Point(422, 30);
            pnlTotalXP.Name = "pnlTotalXP";
            pnlTotalXP.Size = new Size(217, 40);
            pnlTotalXP.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(numTotalXP);
            panel1.Controls.Add(totalXPText);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 40);
            panel1.TabIndex = 3;
            // 
            // numTotalXP
            // 
            numTotalXP.AutoSize = true;
            numTotalXP.Font = new Font("Urbanist", 12F);
            numTotalXP.Location = new Point(137, 3);
            numTotalXP.Name = "numTotalXP";
            numTotalXP.Size = new Size(73, 26);
            numTotalXP.TabIndex = 1;
            numTotalXP.Text = "1170 XP";
            // 
            // totalXPText
            // 
            totalXPText.AutoSize = true;
            totalXPText.Font = new Font("Urbanist", 10F);
            totalXPText.Location = new Point(3, 6);
            totalXPText.Name = "totalXPText";
            totalXPText.Size = new Size(77, 22);
            totalXPText.TabIndex = 0;
            totalXPText.Text = "Total XP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Urbanist", 12F);
            label8.Location = new Point(137, 3);
            label8.Name = "label8";
            label8.Size = new Size(73, 26);
            label8.TabIndex = 1;
            label8.Text = "1170 XP";
            label8.Click += label8_Click_3;
            // 
            // totalXP
            // 
            totalXP.AutoSize = true;
            totalXP.Font = new Font("Urbanist", 10F);
            totalXP.Location = new Point(3, 6);
            totalXP.Name = "totalXP";
            totalXP.Size = new Size(77, 22);
            totalXP.TabIndex = 0;
            totalXP.Text = "Total XP:";
            totalXP.Click += label8_Click_1;
            // 
            // mustDOListBox
            // 
            mustDOListBox.BackColor = Color.FromArgb(17, 28, 46);
            mustDOListBox.BorderStyle = BorderStyle.FixedSingle;
            mustDOListBox.ForeColor = Color.White;
            mustDOListBox.FormattingEnabled = true;
            mustDOListBox.Location = new Point(48, 324);
            mustDOListBox.Name = "mustDOListBox";
            mustDOListBox.Size = new Size(431, 398);
            mustDOListBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Urbanist", 27F);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(281, 162);
            label1.Name = "label1";
            label1.Size = new Size(92, 61);
            label1.TabIndex = 8;
            label1.Text = "Mo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Urbanist", 27F);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(390, 162);
            label2.Name = "label2";
            label2.Size = new Size(78, 61);
            label2.TabIndex = 9;
            label2.Text = "Tu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Urbanist", 27F);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(485, 162);
            label3.Name = "label3";
            label3.Size = new Size(90, 61);
            label3.TabIndex = 10;
            label3.Text = "We";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Urbanist", 27F);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(591, 162);
            label4.Name = "label4";
            label4.Size = new Size(79, 61);
            label4.TabIndex = 11;
            label4.Text = "Th";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 255);
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Urbanist", 27F);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(766, 162);
            label5.Name = "label5";
            label5.Size = new Size(80, 61);
            label5.TabIndex = 12;
            label5.Text = "Sa";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 255);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Urbanist", 27F);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(686, 162);
            label6.Name = "label6";
            label6.Size = new Size(65, 61);
            label6.TabIndex = 13;
            label6.Text = "Fr";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 255);
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Urbanist", 27F);
            label7.ForeColor = Color.FromArgb(15, 23, 42);
            label7.Location = new Point(863, 162);
            label7.Name = "label7";
            label7.Size = new Size(77, 61);
            label7.TabIndex = 14;
            label7.Text = "Su";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayStreakText
            // 
            dayStreakText.AutoSize = true;
            dayStreakText.Location = new Point(91, 237);
            dayStreakText.Name = "dayStreakText";
            dayStreakText.Size = new Size(142, 36);
            dayStreakText.TabIndex = 15;
            dayStreakText.Text = "day streak";
            dayStreakText.TextAlign = ContentAlignment.MiddleCenter;
            dayStreakText.Click += label8_Click;
            // 
            // numDayStreak
            // 
            numDayStreak.AutoSize = true;
            numDayStreak.Font = new Font("Urbanist", 50F);
            numDayStreak.Location = new Point(91, 113);
            numDayStreak.Name = "numDayStreak";
            numDayStreak.Size = new Size(92, 110);
            numDayStreak.TabIndex = 16;
            numDayStreak.Text = "7";
            numDayStreak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(numTaskDone);
            panel2.Controls.Add(taskDonetext);
            panel2.Location = new Point(659, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 40);
            panel2.TabIndex = 17;
            // 
            // numTaskDone
            // 
            numTaskDone.AutoSize = true;
            numTaskDone.Font = new Font("Urbanist", 12F);
            numTaskDone.Location = new Point(137, 3);
            numTaskDone.Name = "numTaskDone";
            numTaskDone.Size = new Size(34, 26);
            numTaskDone.TabIndex = 1;
            numTaskDone.Text = "25";
            // 
            // taskDonetext
            // 
            taskDonetext.AutoSize = true;
            taskDonetext.Font = new Font("Urbanist", 10F);
            taskDonetext.Location = new Point(3, 6);
            taskDonetext.Name = "taskDonetext";
            taskDonetext.Size = new Size(92, 22);
            taskDonetext.TabIndex = 0;
            taskDonetext.Text = "Task Done:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(numRank);
            panel3.Controls.Add(rankText);
            panel3.Location = new Point(852, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 40);
            panel3.TabIndex = 18;
            // 
            // numRank
            // 
            numRank.AutoSize = true;
            numRank.Font = new Font("Urbanist", 12F);
            numRank.Location = new Point(99, 3);
            numRank.Name = "numRank";
            numRank.Size = new Size(22, 26);
            numRank.TabIndex = 1;
            numRank.Text = "3";
            // 
            // rankText
            // 
            rankText.AutoSize = true;
            rankText.Font = new Font("Urbanist", 10F);
            rankText.Location = new Point(3, 6);
            rankText.Name = "rankText";
            rankText.Size = new Size(49, 22);
            rankText.TabIndex = 0;
            rankText.Text = "Rank:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(17, 28, 46);
            richTextBox1.Font = new Font("Urbanist", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(527, 324);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(431, 398);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "Notes";
            // 
            // sidebar_dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1011, 744);
            Controls.Add(richTextBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(numDayStreak);
            Controls.Add(dayStreakText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mustDOListBox);
            Controls.Add(pnlTotalXP);
            Controls.Add(greetingsUser);
            Font = new Font("Urbanist", 16F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "sidebar_dashboard";
            Text = "sidebar_dashboard";
            TransparencyKey = Color.Transparent;
            Load += sidebar_dashboard_Load;
            pnlTotalXP.ResumeLayout(false);
            pnlTotalXP.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetingsUser;
        private Button button1;
        private Panel pnlTotalXP;
        private ListBox mustDOListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label dayStreakText;
        private Label numDayStreak;
        private Label totalXP;
        private Label label8;
        private Panel panel1;
        private Label numTotalXP;
        private Label totalXPText;
        private Panel panel2;
        private Label numTaskDone;
        private Label taskDonetext;
        private Panel panel3;
        private Label numRank;
        private Label rankText;
        private ListBox myTaskListBox;
        private RichTextBox richTextBox1;
    }
}