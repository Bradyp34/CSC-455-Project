﻿namespace CSC_455_Project
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
            workoutLabel = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // workoutLabel
            // 
            workoutLabel.AutoSize = true;
            workoutLabel.Location = new Point(374, 9);
            workoutLabel.Name = "workoutLabel";
            workoutLabel.Size = new Size(38, 15);
            workoutLabel.TabIndex = 0;
            workoutLabel.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 244);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Exercises";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(613, 75);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(116, 220);
            checkedListBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(672, 330);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Exercise";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(613, 51);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "Muscle Groups";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 312);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "Exercise Name";
            // 
            // EditWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(workoutLabel);
            Name = "EditWorkout";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label workoutLabel;
        private ListBox listBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}