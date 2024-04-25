namespace CSC_455_Project
{
    partial class DateWorkouts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public string date;

        // Allow for Date to be passed in on creation
        public DateWorkouts(string date)
        {
            InitializeComponent();
            this.date = date;
            dateLabel.Text = date;
        }

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
            dateLabel = new Label();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(360, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(38, 15);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "label1";
            // 
            // DateWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateLabel);
            Name = "DateWorkouts";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
    }
}