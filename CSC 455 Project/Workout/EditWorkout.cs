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
			this.workout = workout;
			_exerciseFunctions = exerciseFunctions;

			PopulateExercisesList();  // Call this method to populate the list
		}

		public void PopulateExercisesList () {
			listBox1.Items.Clear();  // Clear existing items, if any
			foreach (Exercise exercise in workout.exercises) {
				listBox1.Items.Add(exercise.name);  // Assume each exercise has a 'name' property
			}
		}

		public void button1_Click (object sender, EventArgs e) {
			Exercise exercise = new Exercise(NameInput.Text);
			workout.addExercise(exercise);

			ShowNewExerciseDialog(exercise);
			PopulateExercisesList();
		}

		public void button2_Click (object sender, EventArgs e) {
			if (_exerciseFunctions != null && workout != null && workout.exercises != null && listBox1 != null && listBox1.SelectedItem != null) {
				var selectedItem = listBox1.SelectedItem;
				var selectedExercise = _exerciseFunctions.SearchForExercise(workout.exercises.ToList(), selectedItem.ToString());
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
					_exerciseFunctions.RemoveExercise(workout.exercises.ToList(), exerciseName);  // Remove from the workout
					listBox1.Items.Remove(selectedItem);  // Also remove from the ListBox directly
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
