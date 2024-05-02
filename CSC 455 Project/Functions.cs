using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSC_455_Project.EditWorkout;

namespace CSC_455_Project {
	public static class Functions {
		public static void PopulateWorkoutList (ListBox listBox, HashSet<Workout> workouts) {
			listBox.Items.Clear();
			foreach (var workout in workouts) {
				listBox.Items.Add(workout.name);
			}
		}

		public static void SelectWorkoutAndAddExercises (string selectedItem, HashSet<Workout> workouts, HashSet<Exercise> exerciseList) {
			var workout = SearchForWorkout(workouts, selectedItem);
			if (workout != null) {
				exerciseList.UnionWith(workout.exercises);
			}
		}

		public static void RefreshExerciseList (ListBox listBox, HashSet<Exercise> exercises) {
			listBox.Items.Clear();
			foreach (var item in exercises) {
				listBox.Items.Add(item.name);
			}
		}

		public static void EditExercise (HashSet<Exercise> exercises, string selectedItem, Action<Exercise> showDialog) {
			if (!string.IsNullOrEmpty(selectedItem)) {
				Exercise exercise = SearchForExercise(exercises, selectedItem);
				if (exercise != null) {
					showDialog(exercise);  // This can be a callback to show dialog
					if (!string.IsNullOrEmpty(exercise.name)) {
						exercises.Add(exercise);
					}
				}
			}
		}

		public static void DeleteExercise (HashSet<Exercise> exercises, string selectedItem) {
			if (!string.IsNullOrEmpty(selectedItem)) {
				RemoveExercise(exercises, selectedItem);
			}
		}

		public static void AddNewExercise (HashSet<Exercise> exercises, Action<Exercise> showDialog) {
			Exercise exercise = new Exercise("");
			showDialog(exercise);  // This can be a callback to show dialog
			if (!string.IsNullOrEmpty(exercise.name)) {
				exercises.Add(exercise);
			}
		}

		public static void AddExercisesFromWorkout (HashSet<Exercise> exercises, HashSet<Exercise> selectedExercises) {
			exercises.UnionWith(selectedExercises);
		}

		public static void CreateExercise (
			NumericUpDown setCount,
			NumericUpDown repCount,
			CheckedListBox checkedListBox,
			TextBox setName,
			Exercise exercise) {
			var sets = Convert.ToInt32(setCount.Value);
			var reps = Convert.ToInt32(repCount.Value);
			if (sets >= 1 && reps >= 1) {
				exercise.sets = sets;
				exercise.reps = reps;
			}

			foreach (var item in checkedListBox.CheckedItems) {
				if (Enum.TryParse<Muscles>(item.ToString(), out Muscles muscle)) {
					exercise.musclesHit.Add(muscle);
				}
			}

			if (!string.IsNullOrWhiteSpace(setName.Text)) {
				exercise.name = setName.Text;
				// Assuming there is some kind of close function, but we may need to remove or handle it differently in a static method context
				// Close(); // This might be context-specific, such as closing a form or dialog
			}
		}

		public static void ShowNewExerciseDialog (Exercise exercise) {
			var box = new NewExercise(exercise);
			box.ShowDialog();
		}

		public static void AddExerciseToWorkout (Workout workout, string exerciseName, ListBox listBox) {
			if (string.IsNullOrWhiteSpace(exerciseName)) {
				MessageBox.Show("Exercise name cannot be empty.");
				return;
			}
			Exercise exercise = new Exercise(exerciseName);
			if (workout.exercises.Add(exercise)) {
				listBox.Items.Add(exerciseName); // Update UI
				MessageBox.Show("Exercise added successfully.");
			}
			else {
				MessageBox.Show("Failed to add exercise. It may already exist.");
			}
		}

		public static void EditExerciseInWorkout (Workout workout, ListBox listBox) {
			if (listBox.SelectedItem == null) {
				MessageBox.Show("Please select an exercise to edit.");
				return;
			}
			string exerciseName = listBox.SelectedItem.ToString();
			Exercise existingExercise = SearchForExercise(new HashSet<Exercise>(workout.exercises), exerciseName);
			if (existingExercise != null) {
				// Assuming an EditExerciseDialog form exists to handle the exercise editing
				ShowNewExerciseDialog(existingExercise);
			}
			else {
				MessageBox.Show("Exercise not found.");
			}
		}

		public static void RemoveExerciseFromWorkout (Workout workout, ListBox listBox) {
			if (listBox.SelectedItem == null) {
				MessageBox.Show("Please select an exercise to remove.");
				return;
			}
			string exerciseName = listBox.SelectedItem.ToString();
			Exercise exerciseToRemove = SearchForExercise(new HashSet<Exercise>(workout.exercises), exerciseName);
			if (exerciseToRemove != null && workout.exercises.Remove(exerciseToRemove)) {
				listBox.Items.Remove(listBox.SelectedItem); // Update UI
				MessageBox.Show("Exercise removed successfully.");
			}
			else {
				MessageBox.Show("Failed to remove exercise.");
			}
		}

		public static void PopulateWorkoutsListBox (HashSet<Workout> workouts, ListBox listBox) {
			listBox.Items.Clear();
			foreach (Workout workout in workouts) {
				listBox.Items.Add(workout.name);
			}
		}

		public static void AddNewWorkout (string workoutName, HashSet<Workout> workouts, ListBox listBox) {
			var workout = new Workout(workoutName);
			if (workouts.Add(workout)) {
				listBox.Items.Add(workoutName);
				SaveWorkouts(workouts);
			}
		}

		// Test for this is very complicated
		public static void EditSelectedWorkout (ListBox listBox, HashSet<Workout> workouts) {
			var selectedItem = listBox.SelectedItem;
			if (selectedItem != null) {
				Workout workout = SearchForWorkout(workouts, selectedItem.ToString());
				if (workout != null) {
					var editForm = new EditWorkout(workout);
					editForm.ShowDialog();
				}
			}
		}

		public static void DeleteSelectedWorkout (ListBox listBox, HashSet<Workout> workouts) {
			var selectedItem = listBox.SelectedItem;
			if (selectedItem != null) {
				string workoutName = selectedItem.ToString();
				Workout workoutToDelete = SearchForWorkout(workouts, workoutName);
				if (workouts.Remove(workoutToDelete)) {
					listBox.Items.Remove(selectedItem);
					SaveWorkouts(workouts);
				}
			}
		}

		public static void HandleWorkoutDay (DateTimePicker dateTimePicker, HashSet<WorkoutDay> workoutDays, HashSet<Workout> workouts) {
			var date = dateTimePicker.Value.ToShortDateString();
			var workday = CheckForWorkoutDay(workoutDays, date);
			var box = new DateWorkouts(workday, workouts);
			box.ShowDialog();
			if (workday.exercises.Count > 0) {
				workoutDays.Add(workday);
				SaveWorkoutDates(workoutDays);
			}
		}

		// Search Functions
		public static Workout SearchForWorkout (HashSet<Workout> workouts, string name) {
			return workouts.FirstOrDefault(i => i.name == name);
		}

		public static void SaveWorkouts (HashSet<Workout> workouts) {
			string jsonString = JsonSerializer.Serialize(workouts);
			string fileName = "Workouts.json";
			File.WriteAllText(fileName, jsonString);
		}

		public static Exercise SearchForExercise (HashSet<Exercise> exercises, string name) {
			return exercises.FirstOrDefault(e => e.name == name);
		}

		public static HashSet<Exercise> RemoveExercise (HashSet<Exercise> exercises, string name) {
			var exerciseToRemove = exercises.FirstOrDefault(e => e.name == name);
			if (exerciseToRemove != null) {
				exercises.Remove(exerciseToRemove);
			}
			return exercises;
		}

		public static HashSet<Workout> LoadWorkouts () {
			// Load workouts
			try {

				string fileName = "Workouts.json";
				string jsonString = File.ReadAllText(fileName);
				return JsonSerializer.Deserialize<HashSet<Workout>>(jsonString)!;

			}
			catch (Exception ex) {
				return new HashSet<Workout>();
			}
		}

		public static void SaveWorkoutDates (HashSet<WorkoutDay> workoutDays) {
			string fileName = "WorkoutDays.json";
			string jsonString = JsonSerializer.Serialize(workoutDays);
			File.WriteAllText(fileName, jsonString);
		}

		public static HashSet<WorkoutDay> LoadWorkoutDates () {
			try {

				string fileName = "WorkoutDays.json";
				string jsonString = File.ReadAllText(fileName);
				return JsonSerializer.Deserialize<HashSet<WorkoutDay>>(jsonString)!;
			}
			catch (Exception ex) {
				return new HashSet<WorkoutDay>();
			}
		}

		public static WorkoutDay CheckForWorkoutDay (HashSet<WorkoutDay> workoutDays, string date) {
			// Check if already exists
			WorkoutDay exist = workoutDays.FirstOrDefault(x => x.day == DateOnly.Parse(date));
			WorkoutDay workday;
			if (exist != null) {
				workday = exist;
			}
			else {
				workday = new WorkoutDay(DateOnly.Parse(date));
			}
			return workday;
		}

		internal static void RefreshExerciseList (object listBox1, object exercises) {
			throw new NotImplementedException();
		}
	}
}
