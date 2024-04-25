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
                checkedListBox1.Items.Add(item);
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
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 277);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 12;
            label3.Text = "Exercise Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 11;
            label2.Text = "Muscle Groups";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(173, 295);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 9;
            button1.Text = "Create Exercise";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(114, 40);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(116, 220);
            checkedListBox1.TabIndex = 8;
            // 
            // NewExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 348);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Name = "NewExercise";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private CheckedListBox checkedListBox1;
    }
}