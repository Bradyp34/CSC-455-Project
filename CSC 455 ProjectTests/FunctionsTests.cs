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
	}
}