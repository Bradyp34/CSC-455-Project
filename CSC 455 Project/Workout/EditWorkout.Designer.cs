using System.Windows.Forms;

namespace CSC_455_Project
{
    partial class EditWorkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public string workoutName;
        private Workout workout;
        public EditWorkout(Workout workout)
        {
            this.workout = workout;
            InitializeComponent();
            this.workoutName = workout.name;
            workoutLabel.Text = workoutName;

			PopulateExercisesList();
        }


        private void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (var item in workout.exercises)
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
			workoutLabel = new Label();
			listBox1 = new ListBox();
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			DeleteButton = new Button();
			label2 = new Label();
			NameInput = new TextBox();
			SuspendLayout();
			// 
			// workoutLabel
			// 
			workoutLabel.AutoSize = true;
			workoutLabel.Location = new Point(203, 15);
			workoutLabel.Margin = new Padding(4, 0, 4, 0);
			workoutLabel.Name = "workoutLabel";
			workoutLabel.Size = new Size(59, 25);
			workoutLabel.TabIndex = 0;
			workoutLabel.Text = "label1";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 25;
			listBox1.Location = new Point(37, 85);
			listBox1.Margin = new Padding(4, 5, 4, 5);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(361, 404);
			listBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(37, 55);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(81, 25);
			label1.TabIndex = 2;
			label1.Text = "Exercises";
			// 
			// button1
			// 
			button1.Location = new Point(249, 640);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(151, 38);
			button1.TabIndex = 4;
			button1.Text = "Create Exercise";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(37, 550);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(143, 38);
			button2.TabIndex = 5;
			button2.Text = "Edit Exercise";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// DeleteButton
			// 
			DeleteButton.Location = new Point(293, 550);
			DeleteButton.Margin = new Padding(4, 5, 4, 5);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(107, 38);
			DeleteButton.TabIndex = 8;
			DeleteButton.Text = "Delete";
			DeleteButton.UseVisualStyleBackColor = true;
			DeleteButton.Click += DeleteButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(37, 610);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(125, 25);
			label2.TabIndex = 7;
			label2.Text = "Exercise Name";
			// 
			// NameInput
			// 
			NameInput.Location = new Point(37, 640);
			NameInput.Margin = new Padding(4, 5, 4, 5);
			NameInput.Name = "NameInput";
			NameInput.Size = new Size(180, 31);
			NameInput.TabIndex = 6;
			// 
			// EditWorkout
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(493, 720);
			Controls.Add(DeleteButton);
			Controls.Add(label2);
			Controls.Add(NameInput);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(listBox1);
			Controls.Add(workoutLabel);
			Margin = new Padding(4, 5, 4, 5);
			Name = "EditWorkout";
			Text = "Form1";
			Load += EditWorkout_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label workoutLabel;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button DeleteButton;
        private Label label2;
        private TextBox NameInput;
		public ListBox listBox1;
	}
}