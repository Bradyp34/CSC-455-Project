using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSC_455_Project.Functions;

namespace CSC_455_Project
{
	public partial class NewExercise : Form {
		public NewExercise () {
			InitializeComponent();
		}

		public void CreateExercise (object sender, EventArgs e) {
			Functions.CreateExercise(SetCount, RepCount, checkedListBox1, SetName, exercise);
		}
	}
}
