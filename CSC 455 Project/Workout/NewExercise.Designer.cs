namespace CSC_455_Project
{
    partial class NewExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Exercise exercise;

        public NewExercise(Exercise exercise)
        {
            InitializeComponent();
            this.exercise = exercise;
            // Add Muscle Groups to options
            foreach (var item in Enum.GetNames(typeof(Muscles))) 
            {
                var l = checkedListBox1.Items.Add(item);
                
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                Enum.TryParse<Muscles>(checkedListBox1.Items[i].ToString(), out Muscles muscle);

                // Check Muscles that we already set
                if (exercise.musclesHit.Contains(muscle))
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
                
            }

            SetName.Text = exercise.name;
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
		private void InitializeComponent () {
			label2 = new Label();
			button1 = new Button();
			checkedListBox1 = new CheckedListBox();
			SetCount = new NumericUpDown();
			RepCount = new NumericUpDown();
			label1 = new Label();
			label3 = new Label();
			SetName = new TextBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)SetCount).BeginInit();
			((System.ComponentModel.ISupportInitialize)RepCount).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(163, 27);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(130, 25);
			label2.TabIndex = 11;
			label2.Text = "Muscle Groups";
			// 
			// button1
			// 
			button1.Location = new Point(330, 535);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(151, 38);
			button1.TabIndex = 9;
			button1.Text = "Create Exercise";
			button1.UseVisualStyleBackColor = true;
			button1.Click += CreateExercise;
			// 
			// checkedListBox1
			// 
			checkedListBox1.CheckOnClick = true;
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Location = new Point(163, 67);
			checkedListBox1.Margin = new Padding(4, 5, 4, 5);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(164, 340);
			checkedListBox1.TabIndex = 8;
			// 
			// SetCount
			// 
			SetCount.Location = new Point(17, 470);
			SetCount.Margin = new Padding(4, 5, 4, 5);
			SetCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			SetCount.Name = "SetCount";
			SetCount.Size = new Size(141, 31);
			SetCount.TabIndex = 12;
			SetCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
			// 
			// RepCount
			// 
			RepCount.Location = new Point(346, 470);
			RepCount.Margin = new Padding(4, 5, 4, 5);
			RepCount.Name = "RepCount";
			RepCount.Size = new Size(136, 31);
			RepCount.TabIndex = 13;
			RepCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 440);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(45, 25);
			label1.TabIndex = 14;
			label1.Text = "Sets";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(346, 440);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(50, 25);
			label3.TabIndex = 15;
			label3.Text = "Reps";
			// 
			// SetName
			// 
			SetName.Location = new Point(17, 535);
			SetName.Margin = new Padding(4, 5, 4, 5);
			SetName.Name = "SetName";
			SetName.Size = new Size(287, 31);
			SetName.TabIndex = 16;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(17, 513);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(125, 25);
			label4.TabIndex = 17;
			label4.Text = "Exercise Name";
			// 
			// NewExercise
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(499, 593);
			Controls.Add(label4);
			Controls.Add(SetName);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(RepCount);
			Controls.Add(SetCount);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(checkedListBox1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "NewExercise";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)SetCount).EndInit();
			((System.ComponentModel.ISupportInitialize)RepCount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown SetCount;
        private NumericUpDown RepCount;
        private Label label1;
        private Label label3;
        private TextBox SetName;
        private Label label4;
    }
}