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
	public partial class DateWorkouts : Form {
		public void RefreshList () {
			Functions.RefreshExerciseList(listBox1, dateWorkout.exercises);
		}

		public void Edit_Click (object sender, EventArgs e) {
			Functions.EditExercise(dateWorkout.exercises, listBox1.SelectedItem?.ToString(), exercise =>
			{
				var box = new NewExercise(exercise);
				box.ShowDialog();
			});
			RefreshList();
		}

		public void Delete_Click (object sender, EventArgs e) {
			Functions.DeleteExercise(dateWorkout.exercises, listBox1.SelectedItem?.ToString());
			RefreshList();
		}

		public void AddExercise_Click (object sender, EventArgs e) {
			Functions.AddNewExercise(dateWorkout.exercises, exercise =>
			{
				var box = new NewExercise(exercise);
				box.ShowDialog();
			});
			RefreshList();
		}

		public void AddWorkout_Click (object sender, EventArgs e) {
			HashSet<Exercise> exerciseList = new HashSet<Exercise>();
			var box = new SelectWorkout(workouts, exerciseList);
			box.ShowDialog();
			Functions.AddExercisesFromWorkout(dateWorkout.exercises, exerciseList);
			RefreshList();
		}
	}
}
