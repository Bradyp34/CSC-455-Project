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
                Enum.TryParse<Muscles>(item, out Muscles muscle);

                
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
        private void InitializeComponent()
        {
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
            label2.Location = new Point(114, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 11;
            label2.Text = "Muscle Groups";
            // 
            // button1
            // 
            button1.Location = new Point(231, 321);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 9;
            button1.Text = "Create Exercise";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateExercise;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(114, 40);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(116, 220);
            checkedListBox1.TabIndex = 8;
            // 
            // SetCount
            // 
            SetCount.Location = new Point(12, 282);
            SetCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SetCount.Name = "SetCount";
            SetCount.Size = new Size(99, 23);
            SetCount.TabIndex = 12;
            SetCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // RepCount
            // 
            RepCount.Location = new Point(242, 282);
            RepCount.Name = "RepCount";
            RepCount.Size = new Size(95, 23);
            RepCount.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 264);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 14;
            label1.Text = "Sets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 264);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 15;
            label3.Text = "Reps";
            // 
            // SetName
            // 
            SetName.Location = new Point(12, 321);
            SetName.Name = "SetName";
            SetName.Size = new Size(202, 23);
            SetName.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 308);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 17;
            label4.Text = "Exercise Name";
            // 
            // NewExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 356);
            Controls.Add(label4);
            Controls.Add(SetName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(RepCount);
            Controls.Add(SetCount);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
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