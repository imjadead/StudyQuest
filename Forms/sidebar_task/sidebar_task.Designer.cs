namespace StudyQuest
{
    partial class sidebar_task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sidebar_task));
            label1 = new Label();
            panel2 = new Panel();
            numTaskDone = new Label();
            noOfTasktext = new Label();
            panel4 = new Panel();
            numTaskCompleted = new Label();
            completedTaskText = new Label();
            panel5 = new Panel();
            numTaskMissed = new Label();
            missedtaskText = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            taskListBox = new ListBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urbanist", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 21);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 39);
            label1.TabIndex = 0;
            label1.Text = "My tasks";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(numTaskDone);
            panel2.Controls.Add(noOfTasktext);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(26, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 82);
            panel2.TabIndex = 20;
            // 
            // numTaskDone
            // 
            numTaskDone.AutoSize = true;
            numTaskDone.Font = new Font("Urbanist", 25F);
            numTaskDone.Location = new Point(143, 6);
            numTaskDone.Name = "numTaskDone";
            numTaskDone.Size = new Size(47, 55);
            numTaskDone.TabIndex = 1;
            numTaskDone.Text = "0";
            // 
            // noOfTasktext
            // 
            noOfTasktext.AutoSize = true;
            noOfTasktext.Font = new Font("Urbanist", 10F);
            noOfTasktext.Location = new Point(3, 6);
            noOfTasktext.Name = "noOfTasktext";
            noOfTasktext.Size = new Size(94, 22);
            noOfTasktext.TabIndex = 0;
            noOfTasktext.Text = "No. of Task";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(numTaskCompleted);
            panel4.Controls.Add(completedTaskText);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(26, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 82);
            panel4.TabIndex = 24;
            // 
            // numTaskCompleted
            // 
            numTaskCompleted.AutoSize = true;
            numTaskCompleted.Font = new Font("Urbanist", 25F);
            numTaskCompleted.Location = new Point(143, 6);
            numTaskCompleted.Name = "numTaskCompleted";
            numTaskCompleted.Size = new Size(47, 55);
            numTaskCompleted.TabIndex = 1;
            numTaskCompleted.Text = "0";
            // 
            // completedTaskText
            // 
            completedTaskText.AutoSize = true;
            completedTaskText.Font = new Font("Urbanist", 10F);
            completedTaskText.Location = new Point(3, 6);
            completedTaskText.Name = "completedTaskText";
            completedTaskText.Size = new Size(134, 22);
            completedTaskText.TabIndex = 0;
            completedTaskText.Text = "Completed Task";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(numTaskMissed);
            panel5.Controls.Add(missedtaskText);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(26, 267);
            panel5.Name = "panel5";
            panel5.Size = new Size(237, 82);
            panel5.TabIndex = 25;
            // 
            // numTaskMissed
            // 
            numTaskMissed.AutoSize = true;
            numTaskMissed.Font = new Font("Urbanist", 25F);
            numTaskMissed.Location = new Point(143, 6);
            numTaskMissed.Name = "numTaskMissed";
            numTaskMissed.Size = new Size(49, 55);
            numTaskMissed.TabIndex = 1;
            numTaskMissed.Text = "0";
            // 
            // missedtaskText
            // 
            missedtaskText.AutoSize = true;
            missedtaskText.Font = new Font("Urbanist", 10F);
            missedtaskText.Location = new Point(3, 6);
            missedtaskText.Name = "missedtaskText";
            missedtaskText.Size = new Size(101, 22);
            missedtaskText.TabIndex = 0;
            missedtaskText.Text = "Missed Task";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(361, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 273);
            panel1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Urbanist", 11F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(471, 198);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 6;
            button1.Text = "Add Task";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Urbanist", 10F);
            label4.Location = new Point(18, 154);
            label4.Name = "label4";
            label4.Size = new Size(117, 22);
            label4.TabIndex = 5;
            label4.Text = "Task Deadline:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Urbanist", 10F);
            label3.Location = new Point(18, 104);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 4;
            label3.Text = "Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Urbanist", 10F);
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(45, 22);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 23, 42);
            textBox2.Font = new Font("Urbanist", 12F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(140, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(456, 31);
            textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Font = new Font("Urbanist", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(140, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 29);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 23, 42);
            textBox1.Font = new Font("Urbanist", 12F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(140, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 31);
            textBox1.TabIndex = 0;
            // 
            // taskListBox
            // 
            taskListBox.BackColor = Color.FromArgb(17, 28, 46);
            taskListBox.BorderStyle = BorderStyle.FixedSingle;
            taskListBox.Font = new Font("Urbanist", 12F);
            taskListBox.ForeColor = Color.White;
            taskListBox.FormattingEnabled = true;
            taskListBox.Location = new Point(26, 379);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(953, 340);
            taskListBox.TabIndex = 27;
            // 
            // sidebar_task
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1011, 744);
            Controls.Add(taskListBox);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label1);
            Font = new Font("Urbanist", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "sidebar_task";
            Text = "sidebar_task";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label numTaskDone;
        private Label noOfTasktext;
        private Panel panel4;
        private Label numTaskCompleted;
        private Label completedTaskText;
        private Panel panel5;
        private Label numTaskMissed;
        private Label missedtaskText;
        private Panel panel1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private ListBox taskListBox;
    }
}
