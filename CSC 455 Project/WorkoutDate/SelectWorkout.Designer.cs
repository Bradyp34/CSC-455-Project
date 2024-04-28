namespace CSC_455_Project.WorkoutDate
{
    partial class SelectWorkout
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
		private void InitializeComponent () {
			listBox1 = new ListBox();
			label1 = new Label();
			Select = new Button();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 25;
			listBox1.Location = new Point(17, 40);
			listBox1.Margin = new Padding(4, 5, 4, 5);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(314, 379);
			listBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(127, 10);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(89, 25);
			label1.TabIndex = 1;
			label1.Text = "Workouts";
			// 
			// Select
			// 
			Select.Location = new Point(111, 452);
			Select.Margin = new Padding(4, 5, 4, 5);
			Select.Name = "Select";
			Select.Size = new Size(107, 38);
			Select.TabIndex = 2;
			Select.Text = "Select";
			Select.UseVisualStyleBackColor = true;
			Select.Click += button1_Click;
			// 
			// SelectWorkout
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(350, 545);
			Controls.Add(Select);
			Controls.Add(label1);
			Controls.Add(listBox1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "SelectWorkout";
			Text = "Form1";
			Load += SelectWorkout_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox1;
        private Label label1;
        private Button Select;
    }
}