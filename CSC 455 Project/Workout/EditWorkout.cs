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
			Exercise exercise = new Exercise(NameInput.Text);
			workout.addExercise(exercise);

			ShowNewExerciseDialog(exercise);
			PopulateExercisesList();
		}

		public void button2_Click (object sender, EventArgs e) {
			if (workout != null && workout.exercises != null && listBox1 != null && listBox1.SelectedItem != null) {
				var selectedItem = listBox1.SelectedItem;
				var selectedExercise = SearchForExercise(new HashSet<Exercise>(workout.exercises), selectedItem.ToString());
				if (selectedExercise != null) {
					ShowNewExerciseDialog(selectedExercise);
					PopulateExercisesList();
				}
			}
		}

		public void DeleteButton_Click (object sender, EventArgs e) {
			var selectedItem = listBox1.SelectedItem;
			if (selectedItem != null) {
				string exerciseName = selectedItem.ToString();
				if (!string.IsNullOrEmpty(exerciseName)) {
					RemoveExercise(new HashSet<Exercise>(workout.exercises), exerciseName);
					PopulateExercisesList();
				}
			}
		}

		private void ShowNewExerciseDialog (Exercise exercise) {
			var box = new NewExercise(exercise);
			box.ShowDialog();
		}
	}
}
