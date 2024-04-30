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
	}
}