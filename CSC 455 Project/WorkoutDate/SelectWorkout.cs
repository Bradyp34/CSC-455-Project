using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CSC_455_Project;

namespace CSC_455_Project.WorkoutDate {
	public partial class SelectWorkout : Form {
		private HashSet<Exercise> exerciseList;
		private HashSet<Workout> workouts;

		public SelectWorkout (HashSet<Workout> workouts, HashSet<Exercise> exerciseList) {
			this.workouts = workouts;
			this.exerciseList = exerciseList;
			InitializeComponent();
			Functions.PopulateWorkoutList(listBox1, workouts);
		}

		private void button1_Click (object sender, EventArgs e) {
			if (listBox1.SelectedItem != null) {
				Functions.SelectWorkoutAndAddExercises(listBox1.SelectedItem.ToString(), workouts, exerciseList);
				Close();
			}
		}

		private void SelectWorkout_Load (object sender, EventArgs e) {
			// Potentially other initialization code
		}
	}
}
