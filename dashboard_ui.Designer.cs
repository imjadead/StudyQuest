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
            percentCount = new TextBox();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            nameTextbox = new TextBox();
            userPicture = new PictureBox();
            sidebar = new Panel();
            dashboardButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(percentCount);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(userPicture);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 164);
            panel1.TabIndex = 0;
            // 
            // percentCount
            // 
            percentCount.BackColor = Color.FromArgb(17, 28, 46);
            percentCount.BorderStyle = BorderStyle.None;
            percentCount.Font = new Font("Urbanist", 10F);
            percentCount.ForeColor = Color.White;
            percentCount.Location = new Point(208, 123);
            percentCount.Name = "percentCount";
            percentCount.Size = new Size(43, 20);
            percentCount.TabIndex = 3;
            percentCount.Text = "50%";
            percentCount.TextChanged += textBox2_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.DarkSeaGreen;
            progressBar1.Location = new Point(21, 129);
            progressBar1.MarqueeAnimationSpeed = 150;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(174, 10);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 50;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(17, 28, 46);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Urbanist", 8F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(92, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "Lvl. 10";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // nameTextbox
            // 
            nameTextbox.BackColor = Color.FromArgb(17, 28, 46);
            nameTextbox.BorderStyle = BorderStyle.None;
            nameTextbox.Font = new Font("Urbanist", 11F);
            nameTextbox.ForeColor = Color.White;
            nameTextbox.Location = new Point(92, 39);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(125, 22);
            nameTextbox.TabIndex = 1;
            nameTextbox.Text = "User's name";
            nameTextbox.TextChanged += nameTextbox_TextChanged;
            // 
            // userPicture
            // 
            userPicture.Image = (Image)resources.GetObject("userPicture.Image");
            userPicture.Location = new Point(12, 33);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(74, 72);
            userPicture.SizeMode = PictureBoxSizeMode.Zoom;
            userPicture.TabIndex = 1;
            userPicture.TabStop = false;
            userPicture.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(17, 28, 46);
            sidebar.Controls.Add(button5);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button1);
            sidebar.Controls.Add(dashboardButton);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Font = new Font("Urbanist", 10F);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(256, 744);
            sidebar.TabIndex = 0;
            sidebar.Paint += sidebar_Paint;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(17, 28, 46);
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Urbanist", 12F);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Location = new Point(26, 195);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(191, 41);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 28, 46);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Urbanist", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 278);
            button1.Name = "button1";
            button1.Size = new Size(191, 41);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            //button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(17, 28, 46);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Urbanist", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(26, 357);
            button2.Name = "button2";
            button2.Size = new Size(191, 41);
            button2.TabIndex = 3;
            button2.Text = "Dashboard";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            //button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(17, 28, 46);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Urbanist", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(26, 442);
            button3.Name = "button3";
            button3.Size = new Size(191, 41);
            button3.TabIndex = 4;
            button3.Text = "Dashboard";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            //button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(17, 28, 46);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Urbanist", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(26, 529);
            button4.Name = "button4";
            button4.Size = new Size(191, 41);
            button4.TabIndex = 5;
            button4.Text = "Dashboard";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(17, 28, 46);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Urbanist", 12F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(81, 681);
            button5.Name = "button5";
            button5.Size = new Size(125, 42);
            button5.TabIndex = 6;
            button5.Text = "Dashboard";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dashboard_ui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1255, 744);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard_ui";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form1";
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
        private TextBox textBox1;
        private TextBox nameTextbox;
        private PictureBox userPicture;
        private Panel sidebar;
        private Button dashboardButton;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}