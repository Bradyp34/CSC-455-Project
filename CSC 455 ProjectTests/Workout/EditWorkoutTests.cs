using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC_455_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace CSC_455_Project_Tests {
	[TestClass]
	public class EditWorkoutTests {
		private Mock<IExerciseFunctions>? _mockExerciseFunctions;
		private EditWorkout? _editWorkout;
		private Workout? _mockWorkout;

		[TestInitialize]
		public void SetUp () {
			_mockExerciseFunctions = new Mock<IExerciseFunctions>();
			_mockWorkout = new Workout("Sample Workout");  // Assuming Workout has a constructor that takes a name.
			_editWorkout = new EditWorkout(_mockWorkout, _mockExerciseFunctions.Object);
		}

		[TestMethod]
		public void TestPopulateExercisesList () {
			// Arrange
			_mockWorkout.exercises = new HashSet<Exercise> {
				new Exercise("Exercise 1"),
				new Exercise("Exercise 2"),
				new Exercise("Exercise 3")
			};

			// Act
			_editWorkout.PopulateExercisesList();

			// Assert
			Assert.AreEqual(3, _editWorkout.listBox1.Items.Count);
		}

		[TestMethod]
		public void TestButton1Click () {
			// Arrange
			_editWorkout.NameInput.Text = "New Exercise";

			// Act
			_editWorkout.button1_Click(null, EventArgs.Empty);

			// Assert
			_mockExerciseFunctions.Verify(m => m.SearchForExercise(It.IsAny<List<Exercise>>(), "New Exercise"), Times.Once);
			Assert.AreEqual(1, _editWorkout.listBox1.Items.Count);
		}

		[TestMethod]
		public void TestButton2Click () {
			// Arrange
			_mockWorkout.exercises = new HashSet<Exercise> {
				new Exercise("Exercise 1"),
				new Exercise("Exercise 2"),
				new Exercise("Exercise 3")
			};

			_mockExerciseFunctions.Setup(m => m.SearchForExercise(It.IsAny<List<Exercise>>(), "Exercise 2")).Returns(new Exercise("Exercise 2"));
			_editWorkout.listBox1.SelectedItem = "Exercise 2";

			// Act
			_editWorkout.button2_Click(null, EventArgs.Empty);

			// Assert
			_mockExerciseFunctions.Verify(m => m.SearchForExercise(It.IsAny<List<Exercise>>(), "Exercise 2"), Times.Once);
			Assert.AreEqual(3, _editWorkout.listBox1.Items.Count);
		}
	}
}
