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
        private HashSet<Muscles> musclesHit;

        // Allow for Date to be passed in on creation
        public DateWorkouts(WorkoutDay date, HashSet<Workout> workouts)
        {
            InitializeComponent();
            this.dateWorkout = date;
            this.workouts = workouts;
            dateLabel.Text = date.day.ToShortDateString();
            musclesHit = new HashSet<Muscles>();
            RefreshList();
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
            listBox1 = new ListBox();
            AddWorkout = new Button();
            AddExercise = new Button();
            Delete = new Button();
            Edit = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(235, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(38, 15);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(78, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 229);
            listBox1.TabIndex = 1;
            // 
            // AddWorkout
            // 
            AddWorkout.Location = new Point(78, 330);
            AddWorkout.Name = "AddWorkout";
            AddWorkout.Size = new Size(88, 23);
            AddWorkout.TabIndex = 2;
            AddWorkout.Text = "Add Workout";
            AddWorkout.UseVisualStyleBackColor = true;
            AddWorkout.Click += AddWorkout_Click;
            // 
            // AddExercise
            // 
            AddExercise.Location = new Point(189, 330);
            AddExercise.Name = "AddExercise";
            AddExercise.Size = new Size(84, 23);
            AddExercise.TabIndex = 3;
            AddExercise.Text = "Add Exercise";
            AddExercise.UseVisualStyleBackColor = true;
            AddExercise.Click += AddExercise_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(198, 284);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(78, 284);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 5;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(333, 80);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(133, 169);
            listBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 49);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Muscles Hit";
            // 
            // DateWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 422);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(AddExercise);
            Controls.Add(AddWorkout);
            Controls.Add(listBox1);
            Controls.Add(dateLabel);
            Name = "DateWorkouts";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
        private ListBox listBox1;
        private Button AddWorkout;
        private Button AddExercise;
        private Button Delete;
        private Button Edit;
        private ListBox listBox2;
        private Label label1;
    }
}