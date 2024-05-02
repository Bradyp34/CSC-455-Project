using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSC_455_Project.Exercise;
using static CSC_455_Project.Functions;

namespace CSC_455_Project {
	public partial class EditWorkout : Form {
		public void PopulateExercisesList () {
			listBox1.Items.Clear();
			foreach (Exercise exercise in workout.exercises) {
				listBox1.Items.Add(exercise.name);
			}
		}

		public void button1_Click (object sender, EventArgs e) {
			Functions.AddExerciseToWorkout(workout, NameInput.Text, listBox1);
			PopulateExercisesList();
		}

		public void button2_Click (object sender, EventArgs e) {
			Functions.EditExerciseInWorkout(workout, listBox1);
			PopulateExercisesList();
		}

		public void DeleteButton_Click (object sender, EventArgs e) {
			Functions.RemoveExerciseFromWorkout(workout, listBox1);
			PopulateExercisesList();
		}
	}
}
