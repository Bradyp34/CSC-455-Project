using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC_455_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace CSC_455_Project.Tests {
	public class EditWorkoutTests {
		[Fact]
		public void AddExercise_CallsAddExerciseOnService () {
			// Arrange
			var mockService = new Mock<IExerciseService>();
			var form = new EditWorkout(mockService.Object);

			// Act
			form.AddExercise("Test");

			// Assert
			mockService.Verify(s => s.AddExercise(It.IsAny<Exercise>()), Times.Once);
		}

		[Fact]
		public void EditExercise_CallsSearchForExerciseOnService () {
			// Arrange
			var mockService = new Mock<IExerciseService>();
			var form = new EditWorkout(mockService.Object);

			// Act
			form.EditExercise("Test");

			// Assert
			mockService.Verify(s => s.SearchForExercise(It.IsAny<string>()), Times.Once);
		}

		[Fact]
		public void DeleteExercise_CallsRemoveExerciseOnService () {
			// Arrange
			var mockService = new Mock<IExerciseService>();
			mockService.Setup(s => s.SearchForExercise(It.IsAny<string>())).Returns(new Exercise("Test"));
			var form = new EditWorkout(mockService.Object);

			// Act
			form.DeleteExercise("Test");

			// Assert
			mockService.Verify(s => s.RemoveExercise(It.IsAny<string>()), Times.Once);
		}
	}
}
