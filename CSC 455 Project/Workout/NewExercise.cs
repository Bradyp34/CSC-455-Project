﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_455_Project
{
    public partial class NewExercise : Form
    {
        public NewExercise()
        {
            InitializeComponent();
        }

        private void CreateExercise(object sender, EventArgs e)
        {
            exercise.name = SetName.Text;
            var sets = Convert.ToInt32(SetCount.Value);
            var reps = Convert.ToInt32(RepCount.Value);
            if (sets >= 1 && reps >= 1) 
            {
                exercise.sets = sets;
                exercise.reps = reps;
            }
            foreach (var item in checkedListBox1.CheckedItems) 
            {
                Enum.TryParse<Muscles>(item.ToString(),out Muscles muscle);
                exercise.musclesHit.Add(muscle);
            }

            Close();
        }

    }
}