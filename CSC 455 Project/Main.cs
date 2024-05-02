using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using static CSC_455_Project.Exercise;
using static CSC_455_Project.Functions;

namespace CSC_455_Project {
	public partial class Main : Form {

		private HashSet<Workout> workouts;
		private HashSet<WorkoutDay> workoutDays;

		public Main () {
			InitializeComponent();

			// Load workouts and workout days from files
			workouts = LoadWorkouts();
			workoutDays = LoadWorkoutDates();

			// Populate the list box with workout names
			foreach (Workout workout in workouts) {
				listBox1.Items.Add(workout.name);
			}
		}

		private void Form1_Load (object sender, EventArgs e) {
			// Any additional setup when form loads can be placed here
		}

		private void listView1_SelectedIndexChanged (object sender, EventArgs e) {
			// Handle list view selection changes if needed
		}

		private void button1_Click (object sender, EventArgs e) {
			// Add a new workout based on the text input and save the list of workouts
			var workout = new Workout(textBox1.Text);
			bool added = workouts.Add(workout);
			if (added) {
				listBox1.Items.Add(textBox1.Text);
				SaveWorkouts(workouts);
			}
		}

		private void editWorkout (object sender, EventArgs e) {
			// Open the edit workout window if a workout is selected
			if (listBox1.SelectedItem != null) {
				Workout workout = SearchForWorkout(workouts, listBox1.SelectedItem.ToString());
				if (workout != null) {
					var box = new EditWorkout(workout);
					box.ShowDialog();
				}
			}
		}

		private void deleteWorkout (object sender, EventArgs e) {
			// Delete the selected workout from the list and save the updated list
			var selectedItem = listBox1.SelectedItem;
			if (selectedItem != null) {
				string name = selectedItem.ToString();
				listBox1.Items.Remove(selectedItem);
				workouts.Remove(workouts.FirstOrDefault(x => x.name == name));
				SaveWorkouts(workouts);
			}
		}

		private void button3_Click (object sender, EventArgs e) {
			// Handle specific actions for the third button, possibly managing workout days
			var workday = CheckForWorkoutDay(workoutDays, dateTimePicker1.Value.ToShortDateString());
			var box = new DateWorkouts(workday, this.workouts);
			box.ShowDialog();

			// Save changes if any exercises were added to the workout day
			if (workday.exercises.Count > 0) {
				workoutDays.Add(workday);
				SaveWorkoutDates(workoutDays);
			}
		}
	}
}
