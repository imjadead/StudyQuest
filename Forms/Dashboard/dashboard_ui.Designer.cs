namespace StudyQuest
{
    partial class dashboard_ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_ui));
            panel1 = new Panel();
            userCurrentLvl = new Label();
            usernameTextbox = new Label();
            percentCount = new TextBox();
            progressBar1 = new ProgressBar();
            userPicture = new PictureBox();
            sidebar = new Panel();
            pnlNav = new Panel();
            logoutButton = new Button();
            avatarButton = new Button();
            badgesButton = new Button();
            leaderboardButton = new Button();
            taskButton = new Button();
            dashboardButton = new Button();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(userCurrentLvl);
            panel1.Controls.Add(usernameTextbox);
            panel1.Controls.Add(percentCount);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(userPicture);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 164);
            panel1.TabIndex = 0;
            // 
            // userCurrentLvl
            // 
            userCurrentLvl.AutoSize = true;
            userCurrentLvl.Font = new Font("Urbanist", 10F);
            userCurrentLvl.ForeColor = Color.White;
            userCurrentLvl.Location = new Point(99, 62);
            userCurrentLvl.Name = "userCurrentLvl";
            userCurrentLvl.Size = new Size(53, 22);
            userCurrentLvl.TabIndex = 2;
            userCurrentLvl.Text = "Lvl. 10";
            // 
            // usernameTextbox
            // 
            usernameTextbox.AutoSize = true;
            usernameTextbox.Font = new Font("Urbanist", 12F);
            usernameTextbox.ForeColor = Color.White;
            usernameTextbox.Location = new Point(97, 36);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(111, 26);
            usernameTextbox.TabIndex = 1;
            usernameTextbox.Text = "User Name";
            // 
            // percentCount
            // 
            percentCount.BackColor = Color.FromArgb(17, 28, 46);
            percentCount.BorderStyle = BorderStyle.None;
            percentCount.Font = new Font("Urbanist", 10F);
            percentCount.ForeColor = Color.White;
            percentCount.Location = new Point(189, 127);
            percentCount.Name = "percentCount";
            percentCount.PlaceholderText = "50%";
            percentCount.Size = new Size(43, 20);
            percentCount.TabIndex = 3;
            percentCount.TextChanged += textBox2_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.DarkSeaGreen;
            progressBar1.Location = new Point(12, 135);
            progressBar1.MarqueeAnimationSpeed = 150;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(171, 10);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 50;
            // 
            // userPicture
            // 
            userPicture.Image = (Image)resources.GetObject("userPicture.Image");
            userPicture.Location = new Point(22, 36);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(69, 64);
            userPicture.SizeMode = PictureBoxSizeMode.Zoom;
            userPicture.TabIndex = 1;
            userPicture.TabStop = false;
            userPicture.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(17, 28, 46);
            sidebar.Controls.Add(pnlNav);
            sidebar.Controls.Add(logoutButton);
            sidebar.Controls.Add(avatarButton);
            sidebar.Controls.Add(badgesButton);
            sidebar.Controls.Add(leaderboardButton);
            sidebar.Controls.Add(taskButton);
            sidebar.Controls.Add(dashboardButton);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Font = new Font("Urbanist", 10F);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(244, 744);
            sidebar.TabIndex = 0;
            sidebar.Paint += sidebar_Paint;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(3, 252);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 7;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(17, 28, 46);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Urbanist", 13F);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(0, 674);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(244, 52);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            logoutButton.Leave += logoutButton_Leave;
            // 
            // avatarButton
            // 
            avatarButton.AllowDrop = true;
            avatarButton.BackColor = Color.FromArgb(17, 28, 46);
            avatarButton.FlatAppearance.BorderSize = 0;
            avatarButton.FlatStyle = FlatStyle.Flat;
            avatarButton.Font = new Font("Urbanist", 13F);
            avatarButton.ForeColor = Color.White;
            avatarButton.Image = (Image)resources.GetObject("avatarButton.Image");
            avatarButton.ImageAlign = ContentAlignment.MiddleLeft;
            avatarButton.Location = new Point(0, 517);
            avatarButton.Name = "avatarButton";
            avatarButton.Size = new Size(244, 52);
            avatarButton.TabIndex = 5;
            avatarButton.Text = "Avatar";
            avatarButton.TextAlign = ContentAlignment.MiddleLeft;
            avatarButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            avatarButton.UseVisualStyleBackColor = false;
            avatarButton.Click += button4_Click;
            avatarButton.Leave += avatarButton_Leave;
            // 
            // badgesButton
            // 
            badgesButton.BackColor = Color.FromArgb(17, 28, 46);
            badgesButton.FlatAppearance.BorderSize = 0;
            badgesButton.FlatStyle = FlatStyle.Flat;
            badgesButton.Font = new Font("Urbanist", 13F);
            badgesButton.ForeColor = Color.White;
            badgesButton.Image = (Image)resources.GetObject("badgesButton.Image");
            badgesButton.ImageAlign = ContentAlignment.MiddleLeft;
            badgesButton.Location = new Point(0, 434);
            badgesButton.Name = "badgesButton";
            badgesButton.Size = new Size(244, 52);
            badgesButton.TabIndex = 4;
            badgesButton.Text = "Badges";
            badgesButton.TextAlign = ContentAlignment.MiddleLeft;
            badgesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            badgesButton.UseVisualStyleBackColor = false;
            badgesButton.Click += badgesButton_Click;
            badgesButton.Leave += badgesButton_Leave;
            // 
            // leaderboardButton
            // 
            leaderboardButton.BackColor = Color.FromArgb(17, 28, 46);
            leaderboardButton.FlatAppearance.BorderSize = 0;
            leaderboardButton.FlatStyle = FlatStyle.Flat;
            leaderboardButton.Font = new Font("Urbanist", 13F);
            leaderboardButton.ForeColor = Color.White;
            leaderboardButton.Image = (Image)resources.GetObject("leaderboardButton.Image");
            leaderboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            leaderboardButton.Location = new Point(0, 350);
            leaderboardButton.Name = "leaderboardButton";
            leaderboardButton.Size = new Size(244, 52);
            leaderboardButton.TabIndex = 3;
            leaderboardButton.Text = "Leaderboard";
            leaderboardButton.TextAlign = ContentAlignment.MiddleLeft;
            leaderboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            leaderboardButton.UseVisualStyleBackColor = false;
            leaderboardButton.Click += leaderboardButton_Click;
            leaderboardButton.Leave += leaderboardButton_Leave;
            // 
            // taskButton
            // 
            taskButton.BackColor = Color.FromArgb(17, 28, 46);
            taskButton.FlatAppearance.BorderSize = 0;
            taskButton.FlatStyle = FlatStyle.Flat;
            taskButton.Font = new Font("Urbanist", 13F);
            taskButton.ForeColor = Color.White;
            taskButton.Image = (Image)resources.GetObject("taskButton.Image");
            taskButton.ImageAlign = ContentAlignment.MiddleLeft;
            taskButton.Location = new Point(0, 268);
            taskButton.Name = "taskButton";
            taskButton.Size = new Size(244, 52);
            taskButton.TabIndex = 2;
            taskButton.Text = "Task";
            taskButton.TextAlign = ContentAlignment.MiddleLeft;
            taskButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            taskButton.UseVisualStyleBackColor = false;
            taskButton.Click += taskButton_Click;
            taskButton.Leave += taskButton_Leave;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(17, 28, 46);
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Urbanist", 13F);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(0, 185);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(244, 52);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            dashboardButton.Leave += dashboardButton_Leave;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(244, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1011, 744);
            pnlFormLoader.TabIndex = 1;
            // 
            // dashboard_ui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1255, 744);
            Controls.Add(pnlFormLoader);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1255, 744);
            Name = "dashboard_ui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += dashboard_ui_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox percentCount;
        private ProgressBar progressBar1;
        private PictureBox userPicture;
        private Panel sidebar;
        private Button dashboardButton;
        private Button logoutButton;
        private Button badgesButton;
        private Button leaderboardButton;
        private Button taskButton;
        private Button avatarButton;
        private Label usernameTextbox;
        private Label userCurrentLvl;
        private Panel pnlNav;
        private Panel pnlFormLoader;
    }
}
