﻿using System;
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

namespace CSC_455_Project {
	public interface IExerciseFunctions {
		Exercise SearchForExercise (List<Exercise> exercises, string name);
		void RemoveExercise (List<Exercise> exercises, string name);
	}

	public partial class EditWorkout : Form {
		private readonly IExerciseFunctions _exerciseFunctions;

		public EditWorkout (IExerciseFunctions exerciseFunctions) {
			_exerciseFunctions = exerciseFunctions;
		}

		public void button1_Click (object sender, EventArgs e) {
			Exercise exercise = new Exercise(NameInput.Text);
			workout.addExercise(exercise);

			ShowNewExerciseDialog(exercise);
			RefreshList();
		}

		public void button2_Click (object sender, EventArgs e) {
			Exercise exercise = _exerciseFunctions.SearchForExercise(workout.exercises.ToList(), listBox1.SelectedItem.ToString());
			if (exercise != null) {
				ShowNewExerciseDialog(exercise);
			}
		}

		public void DeleteButton_Click (object sender, EventArgs e) {
			var selectedItem = listBox1.SelectedItem;

			if (selectedItem != null) {
				_exerciseFunctions.RemoveExercise(workout.exercises.ToList(), selectedItem.ToString());
				RefreshList();
			}
		}

		private void ShowNewExerciseDialog (Exercise exercise) {
			var box = new NewExercise(exercise);
			box.ShowDialog();
		}
	}
}
