namespace StudyQuest
{
    partial class sidebar_avatar
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urbanist", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(391, 275);
            label1.Name = "label1";
            label1.Size = new Size(215, 44);
            label1.TabIndex = 0;
            label1.Text = "avatar heree";
            // 
            // sidebar_avatar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(993, 697);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sidebar_avatar";
            Text = "sidebar_avatar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}