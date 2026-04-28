namespace StudyQuest
{
    partial class sidebar_task
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sidebar_task));
            label1 = new Label();
            numTaskDone = new Label();
            noOfTasktext = new Label();
            numTaskCompleted = new Label();
            completedTaskText = new Label();
            numTaskMissed = new Label();
            missedtaskText = new Label();
            EasyTaskListBox = new ListBox();
            MediumTaskListBox = new ListBox();
            HardTaskListBox = new ListBox();
            lblEasyHeader = new Label();
            lblMediumHeader = new Label();
            lblHardHeader = new Label();
            unlockButton = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixelify Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 20);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 0;
            label1.Text = "My Tasks";
            label1.Click += label1_Click;
            // 
            // numTaskDone
            // 
            numTaskDone.AutoSize = true;
            numTaskDone.BackColor = Color.FromArgb(5, 11, 38);
            numTaskDone.Font = new Font("Pixelify Sans", 26F);
            numTaskDone.Location = new Point(177, 77);
            numTaskDone.Name = "numTaskDone";
            numTaskDone.Size = new Size(49, 54);
            numTaskDone.TabIndex = 1;
            numTaskDone.Text = "0";
            // 
            // noOfTasktext
            // 
            noOfTasktext.AutoSize = true;
            noOfTasktext.BackColor = Color.FromArgb(5, 11, 38);
            noOfTasktext.Font = new Font("Pixelify Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noOfTasktext.Location = new Point(47, 77);
            noOfTasktext.Name = "noOfTasktext";
            noOfTasktext.Size = new Size(99, 21);
            noOfTasktext.TabIndex = 0;
            noOfTasktext.Text = "No. of Task";
            noOfTasktext.Click += noOfTasktext_Click;
            // 
            // numTaskCompleted
            // 
            numTaskCompleted.AutoSize = true;
            numTaskCompleted.BackColor = Color.FromArgb(5, 11, 38);
            numTaskCompleted.Font = new Font("Pixelify Sans", 26F);
            numTaskCompleted.Location = new Point(177, 173);
            numTaskCompleted.Name = "numTaskCompleted";
            numTaskCompleted.Size = new Size(49, 54);
            numTaskCompleted.TabIndex = 1;
            numTaskCompleted.Text = "0";
            // 
            // completedTaskText
            // 
            completedTaskText.AutoSize = true;
            completedTaskText.BackColor = Color.FromArgb(5, 11, 38);
            completedTaskText.Font = new Font("Pixelify Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedTaskText.Location = new Point(43, 173);
            completedTaskText.Name = "completedTaskText";
            completedTaskText.Size = new Size(140, 21);
            completedTaskText.TabIndex = 0;
            completedTaskText.Text = "Completed Task";
            // 
            // numTaskMissed
            // 
            numTaskMissed.AutoSize = true;
            numTaskMissed.BackColor = Color.FromArgb(5, 11, 38);
            numTaskMissed.Font = new Font("Pixelify Sans", 26F);
            numTaskMissed.Location = new Point(177, 267);
            numTaskMissed.Name = "numTaskMissed";
            numTaskMissed.Size = new Size(49, 54);
            numTaskMissed.TabIndex = 1;
            numTaskMissed.Text = "0";
            // 
            // missedtaskText
            // 
            missedtaskText.AutoSize = true;
            missedtaskText.BackColor = Color.FromArgb(5, 11, 38);
            missedtaskText.Font = new Font("Pixelify Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missedtaskText.Location = new Point(47, 276);
            missedtaskText.Name = "missedtaskText";
            missedtaskText.Size = new Size(109, 21);
            missedtaskText.TabIndex = 0;
            missedtaskText.Text = "Missed Task";
            // 
            // EasyTaskListBox
            // 
            EasyTaskListBox.BackColor = Color.FromArgb(5, 11, 38);
            EasyTaskListBox.BorderStyle = BorderStyle.None;
            EasyTaskListBox.Font = new Font("Pixelify Sans", 12F);
            EasyTaskListBox.ForeColor = Color.White;
            EasyTaskListBox.FormattingEnabled = true;
            EasyTaskListBox.Location = new Point(32, 369);
            EasyTaskListBox.Name = "EasyTaskListBox";
            EasyTaskListBox.Size = new Size(291, 264);
            EasyTaskListBox.TabIndex = 27;
            EasyTaskListBox.DoubleClick += TaskListBox_DoubleClick;
            // 
            // MediumTaskListBox
            // 
            MediumTaskListBox.BackColor = Color.FromArgb(5, 11, 38);
            MediumTaskListBox.BorderStyle = BorderStyle.None;
            MediumTaskListBox.Font = new Font("Pixelify Sans", 12F);
            MediumTaskListBox.ForeColor = Color.White;
            MediumTaskListBox.FormattingEnabled = true;
            MediumTaskListBox.Location = new Point(362, 369);
            MediumTaskListBox.Name = "MediumTaskListBox";
            MediumTaskListBox.Size = new Size(291, 264);
            MediumTaskListBox.TabIndex = 28;
            MediumTaskListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            MediumTaskListBox.DoubleClick += TaskListBox_DoubleClick;
            // 
            // HardTaskListBox
            // 
            HardTaskListBox.BackColor = Color.FromArgb(5, 11, 38);
            HardTaskListBox.BorderStyle = BorderStyle.None;
            HardTaskListBox.Font = new Font("Pixelify Sans", 12F);
            HardTaskListBox.ForeColor = Color.White;
            HardTaskListBox.FormattingEnabled = true;
            HardTaskListBox.Location = new Point(689, 369);
            HardTaskListBox.Name = "HardTaskListBox";
            HardTaskListBox.Size = new Size(291, 264);
            HardTaskListBox.TabIndex = 29;
            HardTaskListBox.DoubleClick += TaskListBox_DoubleClick;
            // 
            // lblEasyHeader
            // 
            lblEasyHeader.Font = new Font("Pixelify Sans SemiBold", 11F, FontStyle.Bold);
            lblEasyHeader.ForeColor = Color.FromArgb(52, 211, 153);
            lblEasyHeader.Location = new Point(32, 648);
            lblEasyHeader.Name = "lblEasyHeader";
            lblEasyHeader.Size = new Size(291, 25);
            lblEasyHeader.TabIndex = 30;
            lblEasyHeader.Text = "\U0001f7e2  Easy  (5+ days)";
            lblEasyHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMediumHeader
            // 
            lblMediumHeader.Font = new Font("Pixelify Sans SemiBold", 11F, FontStyle.Bold);
            lblMediumHeader.ForeColor = Color.FromArgb(251, 191, 36);
            lblMediumHeader.Location = new Point(362, 648);
            lblMediumHeader.Name = "lblMediumHeader";
            lblMediumHeader.Size = new Size(291, 25);
            lblMediumHeader.TabIndex = 31;
            lblMediumHeader.Text = "\U0001f7e1  Medium  (4-5 days)";
            lblMediumHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHardHeader
            // 
            lblHardHeader.Font = new Font("Pixelify Sans SemiBold", 11F, FontStyle.Bold);
            lblHardHeader.ForeColor = Color.FromArgb(248, 113, 113);
            lblHardHeader.Location = new Point(689, 648);
            lblHardHeader.Name = "lblHardHeader";
            lblHardHeader.Size = new Size(291, 25);
            lblHardHeader.TabIndex = 32;
            lblHardHeader.Text = "🔴  Hard  (1-3 days)";
            lblHardHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unlockButton
            // 
            unlockButton.FlatStyle = FlatStyle.Flat;
            unlockButton.Font = new Font("Pixelify Sans", 10.7999992F);
            unlockButton.ForeColor = Color.White;
            unlockButton.ImageAlign = ContentAlignment.MiddleLeft;
            unlockButton.Location = new Point(800, 686);
            unlockButton.Name = "unlockButton";
            unlockButton.Size = new Size(159, 43);
            unlockButton.TabIndex = 33;
            unlockButton.Text = "Task Complete";
            unlockButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            unlockButton.UseVisualStyleBackColor = true;
            unlockButton.Click += unlockButton_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Pixelify Sans", 10.7999992F);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(596, 686);
            button2.Name = "button2";
            button2.Size = new Size(159, 43);
            button2.TabIndex = 34;
            button2.Text = "Delete Task";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(237, 82);
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 82);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 82);
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(362, 68);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(618, 273);
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(5, 11, 38);
            label3.Font = new Font("Pixelify Sans", 11F);
            label3.Location = new Point(383, 164);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 4;
            label3.Text = "Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(5, 11, 38);
            label2.Font = new Font("Pixelify Sans", 11F);
            label2.Location = new Point(383, 104);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(5, 11, 38);
            textBox2.Font = new Font("Pixelify Sans", 11F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(520, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(439, 29);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(5, 11, 38);
            label4.Font = new Font("Pixelify Sans", 11F);
            label4.Location = new Point(383, 214);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 5;
            label4.Text = "Task Deadline:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Font = new Font("Pixelify Sans", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(554, 209);
            dateTimePicker1.MinDate = new DateTime(2026, 4, 24, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 29);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(5, 11, 38);
            textBox1.Font = new Font("Pixelify Sans", 11F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(520, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 29);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(5, 11, 38);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Pixelify Sans", 11F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(811, 259);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 6;
            button1.Text = "Add Task";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(22, 359);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(311, 286);
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(353, 359);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(311, 286);
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(5, 11, 38);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(680, 359);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(311, 286);
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            // 
            // sidebar_task
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1011, 744);
            Controls.Add(button1);
            Controls.Add(numTaskMissed);
            Controls.Add(label4);
            Controls.Add(missedtaskText);
            Controls.Add(label3);
            Controls.Add(numTaskCompleted);
            Controls.Add(label2);
            Controls.Add(numTaskDone);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(completedTaskText);
            Controls.Add(textBox1);
            Controls.Add(noOfTasktext);
            Controls.Add(button2);
            Controls.Add(unlockButton);
            Controls.Add(lblHardHeader);
            Controls.Add(lblMediumHeader);
            Controls.Add(lblEasyHeader);
            Controls.Add(HardTaskListBox);
            Controls.Add(MediumTaskListBox);
            Controls.Add(EasyTaskListBox);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Font = new Font("Urbanist", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "sidebar_task";
            Text = "sidebar_task";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ── Control declarations ───────────────────────────────────────────────
        private Label label1;
        private Label numTaskDone;
        private Label noOfTasktext;
        private Label numTaskCompleted;
        private Label completedTaskText;
        private Label numTaskMissed;
        private Label missedtaskText;
        private ListBox EasyTaskListBox;
        private ListBox MediumTaskListBox;
        private ListBox HardTaskListBox;
        private Label lblEasyHeader;
        private Label lblMediumHeader;
        private Label lblHardHeader;
        private Button unlockButton;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}