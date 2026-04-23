namespace StudyQuest
{
    partial class login_ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_ui));
            studyQuestLogo = new PictureBox();
            panel1 = new Panel();
            loginButton = new Button();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)studyQuestLogo).BeginInit();
            SuspendLayout();
            // 
            // studyQuestLogo
            // 
            studyQuestLogo.Image = (Image)resources.GetObject("studyQuestLogo.Image");
            studyQuestLogo.Location = new Point(168, 92);
            studyQuestLogo.Margin = new Padding(3, 2, 3, 2);
            studyQuestLogo.Name = "studyQuestLogo";
            studyQuestLogo.Size = new Size(767, 146);
            studyQuestLogo.TabIndex = 2;
            studyQuestLogo.TabStop = false;
            studyQuestLogo.Click += studyQuestLogo_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(401, 316);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 2);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint_1;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Microsoft Sans Serif", 11F);
            loginButton.Location = new Point(492, 409);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(148, 27);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            // 
            // usernameTextbox
            // 
            usernameTextbox.BackColor = Color.FromArgb(15, 23, 42);
            usernameTextbox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextbox.Font = new Font("Microsoft Sans Serif", 11F);
            usernameTextbox.ForeColor = Color.White;
            usernameTextbox.Location = new Point(435, 291);
            usernameTextbox.Margin = new Padding(3, 2, 3, 2);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Username";
            usernameTextbox.Size = new Size(256, 24);
            usernameTextbox.TabIndex = 5;
            usernameTextbox.TextAlign = HorizontalAlignment.Center;
            usernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BackColor = Color.FromArgb(15, 23, 42);
            passwordTextbox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextbox.Font = new Font("Microsoft Sans Serif", 11F);
            passwordTextbox.ForeColor = Color.White;
            passwordTextbox.Location = new Point(435, 340);
            passwordTextbox.Margin = new Padding(3, 2, 3, 2);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Password";
            passwordTextbox.Size = new Size(256, 24);
            passwordTextbox.TabIndex = 7;
            passwordTextbox.TextAlign = HorizontalAlignment.Center;
            passwordTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // panel2
            // 
            panel2.Location = new Point(401, 365);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 2);
            panel2.TabIndex = 6;
            // 
            // login_ui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1098, 558);
            Controls.Add(passwordTextbox);
            Controls.Add(panel2);
            Controls.Add(usernameTextbox);
            Controls.Add(loginButton);
            Controls.Add(panel1);
            Controls.Add(studyQuestLogo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "login_ui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studyQuestLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox studyQuestLogo;
        private Panel panel1;
        private Button loginButton;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Panel panel2;
    }
}