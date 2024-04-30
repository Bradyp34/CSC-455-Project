using System;
using System.Collections.Generic;
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
	public interface IExerciseService {
		void AddExercise (Exercise exercise);
		Exercise SearchForExercise (string name);
		void RemoveExercise (string name);
	}

	public partial class EditWorkout : Form {
		private IExerciseService _exerciseService;

		public EditWorkout (IExerciseService exerciseService) {
			_exerciseService = exerciseService;
		}

		public void button1_Click (object sender, EventArgs e) {
			if (NameInput.Text != "")
				AddExercise(NameInput.Text);
		}

		public void button2_Click (object sender, EventArgs e) {
			if (listBox1.SelectedItem != null) {
				EditExercise(listBox1.SelectedItem.ToString());
			}
		}

		public void DeleteButton_Click (object sender, EventArgs e) {
			if (listBox1.SelectedItem != null)
				DeleteExercise(listBox1.SelectedItem.ToString());
		}

		public void AddExercise (string name) {
			var exercise = new Exercise(name);
			_exerciseService?.AddExercise(exercise);

			var box = new NewExercise(exercise);
			box?.ShowDialog();

			RefreshList();
		}


		public void EditExercise (string name) {
			var exercise = _exerciseService.SearchForExercise(name);
			if (exercise != null) {
				var box = new NewExercise(exercise);
				box.ShowDialog();
			}
		}

		public void DeleteExercise (string name) {
			if (listBox1.SelectedItem != null) {
				_exerciseService.RemoveExercise(name);
				RefreshList();
			}
		}

	}
}
