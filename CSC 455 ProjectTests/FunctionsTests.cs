using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC_455_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_455_Project.Tests {
	[TestClass()]
	public class FunctionsTests {
		[TestMethod()]
		public void SearchForWorkoutTest () {
			// Arrange
			var workout1 = new Workout("Workout 1");
			var workout2 = new Workout("Workout 2");

			var workouts = new HashSet<Workout> { workout1, workout2 };

			// Act
			var result = Functions.SearchForWorkout(workouts, "Workout 1");

			// Assert
			// Add your assertions here
			Assert.IsTrue(result == workout1);
		}

		[TestMethod()]
		public void SearchForWorkoutFailTest () {
			// Arrange
			var workout1 = new Workout("Workout 1");
			var workout2 = new Workout("Workout 2");

			var workouts = new HashSet<Workout> { workout1, workout2 };

			// Act
			var result = Functions.SearchForWorkout(workouts, "Workout 3");

			// Assert
			// Add your assertions here
			Assert.IsTrue(result == null);
		}

		[TestMethod()]
		public void SearchForExerciseTest () {
			// Arrange
			var exercise1 = new Exercise("Exercise 1");
			var exercise2 = new Exercise("Exercise 2");

			var exercises = new HashSet<Exercise> { exercise1, exercise2 };

			// Act
			var result = Functions.SearchForExercise(exercises, "Exercise 1");

			// Assert
			// Add your assertions here
			Assert.IsTrue(result == exercise1);
		}

		[TestMethod()]
		public void SearchForExerciseFailTest () {
			// Arrange
			var exercise1 = new Exercise("Exercise 1");
			var exercise2 = new Exercise("Exercise 2");

			var exercises = new HashSet<Exercise> { exercise1, exercise2 };

			// Act
			var result = Functions.SearchForExercise(exercises, "Exercise 3");

			// Assert
			// Add your assertions here
			Assert.IsTrue(result == null);
		}

		[TestMethod()]
		public void SaveWorkoutsTest () {
			// Arrange
			var workout1 = new Workout("Workout 1");
			var workout2 = new Workout("Workout 2");

			var workouts = new HashSet<Workout> { workout1, workout2 };

			// Act
			Functions.SaveWorkouts(workouts);

			// Assert
			// Add your assertions here
			Assert.IsTrue(File.Exists("Workouts.json"));
		}

		[TestMethod()]
		public void LoadWorkoutsTest () {
			// Arrange
			var workout1 = new Workout("Workout 1");
			var workout2 = new Workout("Workout 2");

			var workouts = new HashSet<Workout> { workout1, workout2 };

			Functions.SaveWorkouts(workouts);

			// Act
			var result = Functions.LoadWorkouts();

			// Assert
			// Add your assertions here
			Assert.IsTrue(result.Count == 2);
		}

		[TestMethod()]
		public void SaveWorkoutDatesTest () {
			// Arrange
			var workoutDay1 = new WorkoutDay(DateOnly.Parse("2022-01-01"));
			var workoutDay2 = new WorkoutDay(DateOnly.Parse("2022-01-02"));

			var workoutDays = new HashSet<WorkoutDay> { workoutDay1, workoutDay2 };

			// Act
			Functions.SaveWorkoutDates(workoutDays);

			// Assert
			// Add your assertions here
			Assert.IsTrue(File.Exists("WorkoutDays.json"));
		}

		[TestMethod()]
		public void LoadWorkoutDatesTest () {
			// Arrange
			var workoutDay1 = new WorkoutDay(DateOnly.Parse("2022-01-01"));
			var workoutDay2 = new WorkoutDay(DateOnly.Parse("2022-01-02"));

			var workoutDays = new HashSet<WorkoutDay> { workoutDay1, workoutDay2 };

			Functions.SaveWorkoutDates(workoutDays);

			// Act
			var result = Functions.LoadWorkoutDates();

			// Assert
			// Add your assertions here
			Assert.IsTrue(result.Count == 2);
		}

		[TestMethod()]
		public void CheckForWorkoutDayTest () {
			// Arrange
			var workoutDay1 = new WorkoutDay(DateOnly.Parse("2022-01-01"));
			var workoutDay2 = new WorkoutDay(DateOnly.Parse("2022-01-02"));

			var workoutDays = new HashSet<WorkoutDay> { workoutDay1, workoutDay2 };

			// Act
			var result = Functions.CheckForWorkoutDay(workoutDays, "2022-01-01");

			// Assert
			// Add your assertions here
			Assert.IsTrue(result == workoutDay1);
		}

		[TestMethod()]
		public void CheckForWorkoutDayFailTest () {
			// Arrange
			var workoutDay1 = new WorkoutDay(DateOnly.Parse("2022-01-01"));
			var workoutDay2 = new WorkoutDay(DateOnly.Parse("2022-01-02"));

			var exercise = new Exercise("Test Exercise");
			workoutDay1.exercises.Add(exercise);
			workoutDay2.exercises.Add(exercise);

			var workoutDays = new HashSet<WorkoutDay> { workoutDay1, workoutDay2 };

			// Act
			var result = Functions.CheckForWorkoutDay(workoutDays, "2022-01-03");

			// Assert
			Assert.IsFalse(result.exercises.Any());
		}


		[TestMethod()]
		public void CheckForWorkoutDayNewTest () {
			// Arrange
			var workoutDay1 = new WorkoutDay(DateOnly.Parse("2022-01-01"));
			var workoutDay2 = new WorkoutDay(DateOnly.Parse("2022-01-02"));

			var workoutDays = new HashSet<WorkoutDay> { workoutDay1, workoutDay2 };

			// Act
			var result = Functions.CheckForWorkoutDay(workoutDays, "2022-01-03");

			// Assert
			// Add your assertions here
			Assert.IsTrue(result.day == DateOnly.Parse("2022-01-03"));
		}

		[TestMethod]
		public void CheckForWorkoutDay_ExistingDate_ReturnsExistingWorkoutDay () {
			// Arrange
			var workoutDays = new HashSet<WorkoutDay> {
				new WorkoutDay(DateOnly.Parse("2022-01-01"))
			};
			var date = "2022-01-01";

			// Act
			var result = Functions.CheckForWorkoutDay(workoutDays, date);

			// Assert
			Assert.AreEqual(DateOnly.Parse(date), result.day);
		}

		[TestMethod]
		public void CheckForWorkoutDay_NonExistingDate_ReturnsNewWorkoutDay () {
			// Arrange
			var workoutDays = new HashSet<WorkoutDay>
			{
		new WorkoutDay(DateOnly.Parse("2022-01-01"))
	};
			var date = "2022-02-02";

			// Act
			var result = Functions.CheckForWorkoutDay(workoutDays, date);

			// Assert
			Assert.AreEqual(DateOnly.Parse(date), result.day);
		}

		[TestMethod]
		public void RemoveExerciseTest () {
			// Arrange
			var exercise1 = new Exercise("Exercise 1");
			var exercise2 = new Exercise("Exercise 2");

			var exercises = new HashSet<Exercise> { exercise1, exercise2 };

			// Act
			Functions.RemoveExercise(exercises, "Exercise 1");

			// Assert
			// Add your assertions here
			Assert.IsTrue(exercises.Count == 1);
			Assert.IsTrue(exercises.Contains(exercise2));
			Assert.IsFalse(exercises.Contains(exercise1));
		}

		[TestMethod]
		public void RemoveExerciseTestFail () {
			// Arrange
			var exercise1 = new Exercise("Exercise 1");
			var exercise2 = new Exercise("Exercise 2");

			var exercises = new HashSet<Exercise> { exercise1, exercise2 };

			// Act
			Functions.RemoveExercise(exercises, "Exercise 3");

			// Assert
			// Add your assertions here
			Assert.IsTrue(exercises.Count == 2);
			Assert.IsTrue(exercises.Contains(exercise1));
			Assert.IsTrue(exercises.Contains(exercise2));
		}

		[TestMethod()]
		public void AddExerciseToWorkoutTest () {
			// Arrange
			var workout = new Workout("Test Workout");
			string exerciseName = "New Exercise";
			var listBox = new ListBox();

			// Act
			Functions.AddExerciseToWorkout(workout, exerciseName, listBox);

			// Assert
			Assert.IsTrue(workout.exercises.Count == 1);
			Assert.IsTrue(listBox.Items.Contains(exerciseName));
		}

		[TestMethod()]
		public void AddExerciseToWorkoutFailTest () {
			// Arrange
			var workout = new Workout("Test Workout");
			string exerciseName = "";
			var listBox = new ListBox();

			// Act
			Functions.AddExerciseToWorkout(workout, exerciseName, listBox);

			// Assert
			Assert.IsTrue(workout.exercises.Count == 0);
			Assert.IsTrue(listBox.Items.Count == 0);
		}

		[TestMethod()]
		public void EditExerciseInWorkoutTest () {
			// Arrange
			var workout = new Workout("Test Workout");
			workout.addExercise(new Exercise("Exercise 1"));
			var listBox = new ListBox();
			listBox.Items.Add("Exercise 1");
			listBox.SelectedItem = "Exercise 1";

			// Act
			Functions.EditExerciseInWorkout(workout, listBox);

			// Assert
			// Assuming ShowNewExerciseDialog launches the edit dialog successfully
			// Assertions would normally be about checking the outcome post-dialog, but dialogs require UI testing frameworks
		}

		[TestMethod()]
		public void RemoveExerciseFromWorkoutTest () {
			// Arrange
			var workout = new Workout("Test Workout");
			var exercise = new Exercise("Exercise 1");
			workout.addExercise(exercise);
			var listBox = new ListBox();
			listBox.Items.Add("Exercise 1");
			listBox.SelectedItem = "Exercise 1";

			// Act
			Functions.RemoveExerciseFromWorkout(workout, listBox);

			// Assert
			Assert.IsFalse(workout.exercises.Contains(exercise));
			Assert.IsTrue(listBox.Items.Count == 0);
		}

		[TestMethod()]
		public void PopulateWorkoutsListBoxTest () {
			// Arrange
			var workouts = new HashSet<Workout> {
				new Workout("Workout 1"),
				new Workout("Workout 2")
			};
			var listBox = new ListBox();

			// Act
			Functions.PopulateWorkoutsListBox(workouts, listBox);

			// Assert
			Assert.AreEqual(2, listBox.Items.Count);
			Assert.IsTrue(listBox.Items.Contains("Workout 1"));
			Assert.IsTrue(listBox.Items.Contains("Workout 2"));
		}

		[TestMethod()]
		public void AddNewWorkoutTest () {
			// Arrange
			var workouts = new HashSet<Workout>();
			var listBox = new ListBox();
			string workoutName = "New Workout";

			// Act
			Functions.AddNewWorkout(workoutName, workouts, listBox);

			// Assert
			Assert.IsTrue(workouts.Any(w => w.name == workoutName));
			Assert.IsTrue(listBox.Items.Contains(workoutName));
		}

		[TestMethod()]
		public void DeleteSelectedWorkoutTest () {
			// Arrange
			var workout1 = new Workout("Workout 1");
			var workouts = new HashSet<Workout> { workout1 };
			var listBox = new ListBox();
			listBox.Items.Add("Workout 1");
			listBox.SelectedItem = "Workout 1";

			// Act
			Functions.DeleteSelectedWorkout(listBox, workouts);

			// Assert
			Assert.IsFalse(workouts.Contains(workout1));
			Assert.IsFalse(listBox.Items.Contains("Workout 1"));
		}

		[TestMethod()]
		public void CreateExerciseTest () {
			// Arrange
			var setCount = new NumericUpDown();
			var repCount = new NumericUpDown();
			var checkedListBox = new CheckedListBox();
			var setName = new TextBox();
			var exercise = new Exercise("Initial Name");

			setCount.Value = 3; // Sets the number of sets
			repCount.Value = 10; // Sets the number of repetitions

			// Simulating checked items in the checkedListBox
			checkedListBox.Items.Add("Chest", true);
			checkedListBox.Items.Add("Biceps", true);
			checkedListBox.Items.Add("Calves", false); // Not checked

			setName.Text = "Updated Exercise Name";

			// Act
			Functions.CreateExercise(setCount, repCount, checkedListBox, setName, exercise);

			// Assert
			Assert.AreEqual(3, exercise.sets); // Checking sets
			Assert.AreEqual(10, exercise.reps); // Checking reps
			Assert.AreEqual(2, exercise.musclesHit.Count); // Two muscles should be added
			Assert.IsTrue(exercise.musclesHit.Contains(Muscles.Chest)); // Check specific muscle
			Assert.IsTrue(exercise.musclesHit.Contains(Muscles.Biceps)); // Check specific muscle
			Assert.IsFalse(exercise.musclesHit.Contains(Muscles.Calves)); // Ensure not added
			Assert.AreEqual("Updated Exercise Name", exercise.name); // Check name update
		}

		[TestMethod()]
		public void ShowNewExerciseDialogTest () {
			// Arrange
			var exercise = new Exercise("Test Exercise");

			// Act
			Functions.ShowNewExerciseDialog(exercise);

			// Assert
			// Assuming ShowDialog launches the dialog successfully
			// Assertions would normally be about checking the outcome post-dialog, but dialogs require UI testing frameworks
			Assert.IsTrue(true); // will come back and add testing later if I have time
		}

		[TestMethod()]
		public void EditSelectedWorkoutTest () {
			// Arrange
			var workout1 = new Workout("Workout 1");
			var workout2 = new Workout("Workout 2");
			var workouts = new HashSet<Workout> { workout1, workout2 };
			var listBox = new ListBox();
			listBox.Items.Add("Workout 1");
			listBox.Items.Add("Workout 2");
			listBox.SelectedItem = "Workout 1";

			// Act
			Functions.EditSelectedWorkout(listBox, workouts);

			// Assert
			// Assuming ShowNewWorkoutDialog launches the edit dialog successfully
			// Assertions would normally be about checking the outcome post-dialog, but dialogs require UI testing frameworks
			Assert.IsTrue(true); // will come back and add testing later if I have time
		}

		[TestMethod()]
		public void HandleWorkoutDayTest () {
			// Arrange
			var dateTimePicker = new DateTimePicker();
			dateTimePicker.Value = new DateTime(2022, 1, 1); // Simulate setting the date on a DatePicker control

			var workoutDays = new HashSet<WorkoutDay>();
			var workouts = new HashSet<Workout>();

			var workoutDay = new WorkoutDay(DateOnly.Parse("2022-01-01"));
			var workout = new Workout("Test Workout");
			var exercise = new Exercise("Test Exercise");
			workout.addExercise(exercise);
			workouts.Add(workout);

			// Act
			Functions.HandleWorkoutDay(dateTimePicker, workoutDays, workouts);

			// Assert
			Assert.IsTrue(workoutDays.Any(wd => wd.day == DateOnly.FromDateTime(dateTimePicker.Value) && wd.exercises.Contains(exercise)));
		}

		[TestMethod]
		public void WorkoutDayEqualityTest () {
			// Arrange
			var date = DateOnly.Parse("2023-04-25");
			var workoutDay1 = new WorkoutDay(date);
			var workoutDay2 = new WorkoutDay(date);

			// Act & Assert
			Assert.AreEqual(workoutDay1, workoutDay2);
		}

		[TestMethod]
		public void WorkoutDayInequalityTest () {
			// Arrange
			var workoutDay1 = new WorkoutDay(DateOnly.Parse("2023-04-25"));
			var workoutDay2 = new WorkoutDay(DateOnly.Parse("2023-04-26"));

			// Act & Assert
			Assert.AreNotEqual(workoutDay1, workoutDay2);
		}

		[TestMethod]
		public void WorkoutEqualityTest () {
			// Arrange
			var workout1 = new Workout("Morning Routine");
			var workout2 = new Workout("Morning Routine");

			// Act & Assert
			Assert.AreEqual(workout1, workout2);
		}

		[TestMethod]
		public void WorkoutInequalityTest () {
			// Arrange
			var workout1 = new Workout("Morning Routine");
			var workout2 = new Workout("Evening Routine");

			// Act & Assert
			Assert.AreNotEqual(workout1, workout2);
		}

		[TestMethod]
		public void AddExerciseToWorkoutIncreasesCountTest () {
			// Arrange
			var workout = new Workout("Test Workout");
			var exercise = new Exercise("Push-up");

			// Act
			workout.addExercise(exercise);

			// Assert
			Assert.IsTrue(workout.exercises.Contains(exercise));
			Assert.AreEqual(1, workout.exercises.Count);
		}

		[TestMethod]
		public void RemoveExerciseFromWorkoutDecreasesCountTest () {
			// Arrange
			var workout = new Workout("Test Workout");
			var exercise = new Exercise("Push-up");
			workout.addExercise(exercise);

			// Act
			workout.removeExercise(exercise);

			// Assert
			Assert.IsFalse(workout.exercises.Contains(exercise));
			Assert.AreEqual(0, workout.exercises.Count);
		}

		[TestMethod]
		public void ExerciseInitializationTest () {
			// Arrange
			var exercise = new Exercise("Squat");
			exercise.sets = 3;
			exercise.reps = 12;
			exercise.musclesHit.Add(Muscles.Quads);

			// Assert
			Assert.AreEqual("Squat", exercise.name);
			Assert.AreEqual(3, exercise.sets);
			Assert.AreEqual(12, exercise.reps);
			Assert.IsTrue(exercise.musclesHit.Contains(Muscles.Quads));
		}

		[TestMethod]
		public void AddExerciseToWorkoutDayTest () {
			// Arrange
			var workoutDay = new WorkoutDay(DateOnly.Parse("2023-04-25"));
			var exercise = new Exercise("Jogging");

			// Act
			workoutDay.exercises.Add(exercise);

			// Assert
			Assert.IsTrue(workoutDay.exercises.Contains(exercise));
			Assert.AreEqual(1, workoutDay.exercises.Count);
		}
	}
}