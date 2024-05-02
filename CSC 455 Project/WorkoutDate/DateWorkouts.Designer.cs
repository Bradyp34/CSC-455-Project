namespace CSC_455_Project
{
    partial class DateWorkouts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WorkoutDay dateWorkout;
        public HashSet<Workout> workouts;

        // Allow for Date to be passed in on creation
        public DateWorkouts(WorkoutDay date, HashSet<Workout> workouts)
        {
            InitializeComponent();
            this.dateWorkout = date;
            this.workouts = workouts;
            dateLabel.Text = date.day.ToShortDateString();
            foreach (var item in date.exercises)
            {
                listBox1.Items.Add(item.name);
            }
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
			dateLabel = new Label();
			listBox1 = new ListBox();
			AddWorkout = new Button();
			AddExercise = new Button();
			Delete = new Button();
			Edit = new Button();
			SuspendLayout();
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(336, 15);
			dateLabel.Margin = new Padding(4, 0, 4, 0);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(59, 25);
			dateLabel.TabIndex = 0;
			dateLabel.Text = "label1";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 25;
			listBox1.Location = new Point(217, 83);
			listBox1.Margin = new Padding(4, 5, 4, 5);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(277, 379);
			listBox1.TabIndex = 1;
			// 
			// AddWorkout
			// 
			AddWorkout.Location = new Point(217, 552);
			AddWorkout.Margin = new Padding(4, 5, 4, 5);
			AddWorkout.Name = "AddWorkout";
			AddWorkout.Size = new Size(126, 38);
			AddWorkout.TabIndex = 2;
			AddWorkout.Text = "Add Workout";
			AddWorkout.UseVisualStyleBackColor = true;
			AddWorkout.Click += AddWorkout_Click;
			// 
			// AddExercise
			// 
			AddExercise.Location = new Point(376, 552);
			AddExercise.Margin = new Padding(4, 5, 4, 5);
			AddExercise.Name = "AddExercise";
			AddExercise.Size = new Size(120, 38);
			AddExercise.TabIndex = 3;
			AddExercise.Text = "Add Exercise";
			AddExercise.UseVisualStyleBackColor = true;
			AddExercise.Click += AddExercise_Click;
			// 
			// Delete
			// 
			Delete.Location = new Point(389, 475);
			Delete.Margin = new Padding(4, 5, 4, 5);
			Delete.Name = "Delete";
			Delete.Size = new Size(107, 38);
			Delete.TabIndex = 4;
			Delete.Text = "Delete";
			Delete.UseVisualStyleBackColor = true;
			Delete.Click += Delete_Click;
			// 
			// Edit
			// 
			Edit.Location = new Point(217, 475);
			Edit.Margin = new Padding(4, 5, 4, 5);
			Edit.Name = "Edit";
			Edit.Size = new Size(107, 38);
			Edit.TabIndex = 5;
			Edit.Text = "Edit";
			Edit.UseVisualStyleBackColor = true;
			Edit.Click += Edit_Click;
			// 
			// DateWorkouts
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(733, 703);
			Controls.Add(Edit);
			Controls.Add(Delete);
			Controls.Add(AddExercise);
			Controls.Add(AddWorkout);
			Controls.Add(listBox1);
			Controls.Add(dateLabel);
			Margin = new Padding(4, 5, 4, 5);
			Name = "DateWorkouts";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label dateLabel;
        private Button AddWorkout;
        private Button AddExercise;
        private Button Delete;
        private Button Edit;
		public ListBox listBox1;
	}
}