using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSC_455_Project
{
    public partial class EditWorkout : Form
    {

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Exercise exercise = new Exercise(NameInput.Text);
            workout.addExercise(exercise);

            var box = new NewExercise(exercise);
            box.ShowDialog();
            // Refresh List
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercise exercise = Functions.SearchForExercise(workout.exercises, listBox1.SelectedItem.ToString());
            if (exercise != null)
            {
                var box = new NewExercise(exercise);
                box.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;


            // Make sure item is selected
            if (selectedItem != null)
            {
                Functions.RemoveExercise(workout.exercises, selectedItem.ToString());
            }
            RefreshList();
        }
    }
}
