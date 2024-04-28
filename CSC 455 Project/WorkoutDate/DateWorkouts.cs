using CSC_455_Project.WorkoutDate;
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
                Exercise exercise = Functions.SearchForExercise(dateWorkout.exercises, listBox1.SelectedItem.ToString());
                if (exercise != null)
                {
                    var box = new NewExercise(exercise);
                    box.ShowDialog();
                    if (exercise.name != "")
                    {
                        dateWorkout.exercises.Add(exercise);
                        RefreshList();
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
                Functions.RemoveExercise(dateWorkout.exercises, selectedItem.ToString());
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

        private void AddWorkout_Click(object sender, EventArgs e)
        {
            HashSet<Exercise> exerciseList = new HashSet<Exercise>();
            var box = new SelectWorkout(workouts,exerciseList);
            box.ShowDialog();
            dateWorkout.exercises.UnionWith(exerciseList);
            RefreshList();

        }
    }
}
