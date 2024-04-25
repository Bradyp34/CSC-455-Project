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

            // Put Excersises in list
            foreach(var item in workout.exercises)
            {
                listBox1.Items.Add(item.name);
            }
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
        private void InitializeComponent()
        {
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
            workoutLabel.Location = new Point(233, -1);
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
            // button1
            // 
            button1.Location = new Point(174, 384);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Exercise";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 330);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "Edit Exercise";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(205, 330);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 366);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Exercise Name";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(26, 384);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(127, 23);
            NameInput.TabIndex = 6;
            // 
            // EditWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 432);
            Controls.Add(DeleteButton);
            Controls.Add(label2);
            Controls.Add(NameInput);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button DeleteButton;
        private Label label2;
        private TextBox NameInput;
    }
}