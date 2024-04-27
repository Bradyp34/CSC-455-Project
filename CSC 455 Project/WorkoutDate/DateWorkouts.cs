using System;
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
    public partial class DateWorkouts : Form
    {
        private void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (var item in dateWorkout.exercises)
            {
                listBox1.Items.Add(item.name);
            }
        }

            private void Edit_Click(object sender, EventArgs e)
        {
            
            if (listBox1 != null && listBox1.SelectedItem != null)
            {
                Exercise exercise = dateWorkout.exercises.FirstOrDefault(i => i.name == listBox1.SelectedItem.ToString());
                if (exercise != null)
                {
                    var box = new NewExercise(exercise);
                    box.ShowDialog();
                    if (exercise.name != "")
                    {
                        dateWorkout.exercises.Add(exercise);
                        listBox1.Items.Add(exercise.name);
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;


            // Make sure item is selected
            if (selectedItem != null)
            {
                string name = selectedItem.ToString();
                dateWorkout.exercises.Remove(dateWorkout.exercises.FirstOrDefault(x => x.name == name));
            }
        }
        private void AddExercise_Click(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise("");

            var box = new NewExercise(exercise);
            box.ShowDialog();
            if (exercise.name != "")
            {
                dateWorkout.exercises.Add(exercise);
                RefreshList();
            }
        }

        public DateWorkouts()
        {
            
            InitializeComponent();
        }
    }
}
