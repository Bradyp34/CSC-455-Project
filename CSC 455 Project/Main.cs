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
			workouts = Functions.InitializeWorkouts();
			workoutDays = Functions.InitializeWorkoutDays();
			foreach (Workout workout in workouts) {
				listBox1.Items.Add(workout.name);
			}
		}

		private void button1_Click (object sender, EventArgs e) {
			Functions.AddWorkout(workouts, textBox1.Text, name => listBox1.Items.Add(name));
		}

		private void editWorkout (object sender, EventArgs e) {
			Functions.EditSelectedWorkout(workouts, listBox1.SelectedItem?.ToString(), workout => {
				var box = new EditWorkout(workout);
				box.ShowDialog();
			});
		}

		private void deleteWorkout (object sender, EventArgs e) {
			Functions.DeleteSelectedWorkout(workouts, listBox1.SelectedItem?.ToString(), name => listBox1.Items.Remove(name));
		}

		private void button3_Click (object sender, EventArgs e) {
			Functions.ManageWorkoutDay(workoutDays, dateTimePicker1.Value, workouts, (workday, ws) => {
				var box = new DateWorkouts(workday, ws);
				box.ShowDialog();
			});
		}
	}
}
