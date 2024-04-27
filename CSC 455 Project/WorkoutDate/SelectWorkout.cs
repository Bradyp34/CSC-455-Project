using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_455_Project.WorkoutDate
{
    public partial class SelectWorkout : Form
    {
        private HashSet<Exercise> exerciseList;
        private HashSet<Workout> workouts;
        private void RefreshList()
        {
            listBox1.Items.Clear();

            
        }
        public SelectWorkout(HashSet<Workout> workouts,HashSet<Exercise> exerciseList)
        {
            this.workouts = workouts;
            this.exerciseList = exerciseList;
            InitializeComponent();
            foreach (var item in workouts)
            {
                listBox1.Items.Add(item.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {

            }
        }


    }
}
