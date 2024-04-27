namespace CSC_455_Project
{
    partial class DateWorkouts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WorkoutDay dateWorkout;

        // Allow for Date to be passed in on creation
        public DateWorkouts(WorkoutDay date)
        {
            InitializeComponent();
            this.dateWorkout = date;
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
        private void InitializeComponent()
        {
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
            listBox1.Location = new Point(152, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 229);
            listBox1.TabIndex = 1;
            // 
            // AddWorkout
            // 
            AddWorkout.Location = new Point(152, 331);
            AddWorkout.Name = "AddWorkout";
            AddWorkout.Size = new Size(88, 23);
            AddWorkout.TabIndex = 2;
            AddWorkout.Text = "Add Workout";
            AddWorkout.UseVisualStyleBackColor = true;
            // 
            // AddExercise
            // 
            AddExercise.Location = new Point(263, 331);
            AddExercise.Name = "AddExercise";
            AddExercise.Size = new Size(84, 23);
            AddExercise.TabIndex = 3;
            AddExercise.Text = "Add Exercise";
            AddExercise.UseVisualStyleBackColor = true;
            AddExercise.Click += this.AddExercise_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(272, 285);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(152, 285);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 5;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // DateWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 422);
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
    }
}