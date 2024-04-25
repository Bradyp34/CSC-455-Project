using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
