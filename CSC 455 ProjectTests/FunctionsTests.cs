using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC_455_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public void SearchForWorkoutFailTest() {
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
		public void SearchForExerciseFailTest() {
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
			var workoutDays = new HashSet<WorkoutDay>
			{
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
		public void RemoveExerciseTest() {
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
		public void RemoveExerciseTestFail() {
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
	}
}