using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC_455_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace CSC_455_Project_Tests {
	[TestFixture]
	public class EditWorkoutTests {
		private Mock<IExerciseFunctions> _mockExerciseFunctions;
		private EditWorkout _editWorkout;

		[SetUp]
		public void SetUp () {
			_mockExerciseFunctions = new Mock<IExerciseFunctions>();
			_editWorkout = new EditWorkout(_mockExerciseFunctions.Object);
		}

		[Test]
		public void TestButton2Click_ExerciseFound_ShowsNewExerciseDialog () {
			// Arrange
			var exercise = new Exercise("Test");
			_mockExerciseFunctions.Setup(x => x.SearchForExercise(It.IsAny<List<Exercise>>(), It.IsAny<string>())).Returns(exercise);

			// Act
			_editWorkout.button2_Click(null, null);

			// Assert
			// Here you would assert that ShowNewExerciseDialog was called with the correct parameters.
			// This might involve making ShowNewExerciseDialog virtual and overriding it in a test-specific subclass, or it might involve some other form of interaction testing.
		}

		[Test]
		public void TestDeleteButtonClick_ItemSelected_RemovesExercise () {
			// Arrange
			_mockExerciseFunctions.Setup(x => x.RemoveExercise(It.IsAny<List<Exercise>>(), It.IsAny<string>()));

			// Act
			_editWorkout.DeleteButton_Click(null, null);

			// Assert
			_mockExerciseFunctions.Verify(x => x.RemoveExercise(It.IsAny<List<Exercise>>(), It.IsAny<string>()), Times.Once);
		}
	}
}