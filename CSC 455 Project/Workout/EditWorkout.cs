using System;
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
using static CSC_455_Project.Exercise;

namespace CSC_455_Project {
	public interface IExerciseFunctions {
		Exercise SearchForExercise (List<Exercise> exercises, string name);
		void RemoveExercise (List<Exercise> exercises, string name);
	}

	public partial class EditWorkout : Form {
		public readonly IExerciseFunctions _exerciseFunctions;
		IExerciseFunctions exerciseFunctions = new ExerciseFunctions(); // Assuming ExerciseFunctions implements IExerciseFunctions

		public EditWorkout (Workout workout, IExerciseFunctions exerciseFunctions) {
			InitializeComponent();
			this.workout = workout;  // Store the Workout object.
			_exerciseFunctions = exerciseFunctions;  // Assign the passed-in implementation of IExerciseFunctions.
		}


		public void button1_Click (object sender, EventArgs e) {
			Exercise exercise = new Exercise(NameInput.Text);
			workout.addExercise(exercise);

			ShowNewExerciseDialog(exercise);
			RefreshList();
		}

		public void button2_Click (object sender, EventArgs e) {
			if (_exerciseFunctions != null && workout != null && workout.exercises != null && listBox1 != null && listBox1.SelectedItem != null) {
				var selectedItem = listBox1.SelectedItem;
				var selectedExercise = _exerciseFunctions.SearchForExercise(workout.exercises.ToList(), selectedItem.ToString());
				if (selectedExercise != null) {
					ShowNewExerciseDialog(selectedExercise);
				}
			}
		}

		public void DeleteButton_Click (object sender, EventArgs e) {
			if (_exerciseFunctions != null && workout != null && workout.exercises != null && listBox1 != null && listBox1.SelectedItem != null) {
				var selectedItem = listBox1.SelectedItem.ToString();
				if (!string.IsNullOrEmpty(selectedItem)) {
					_exerciseFunctions.RemoveExercise(workout.exercises.ToList(), selectedItem);
					RefreshList();
				}
			}
		}


		private void ShowNewExerciseDialog (Exercise exercise) {
			var box = new NewExercise(exercise);
			box.ShowDialog();
		}
	}
}
