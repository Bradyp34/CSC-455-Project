using System.Security.Cryptography.X509Certificates;

namespace CSC_455_Project {
    public partial class Main : Form
    {

        private HashSet<Workout> workouts;

        public Main()
        {
            InitializeComponent();
            workouts = new HashSet<Workout>();
            // TODO: Load from Json
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Take test from texbox and put into list
            var workout = new Workout(textBox1.Text);
            bool added = workouts.Add(workout);
            if(added)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            // TODO: Save data to JSON File
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editWorkout(object sender, EventArgs e)
        {
            // Open editworkout window
            if (listBox1.SelectedItem != null)
            {
                Workout workout = workouts.FirstOrDefault(i => i.name == listBox1.SelectedItem.ToString());
                if (workout != null)
                {
                    var box = new EditWorkout(workout);
                    box.Show();
                }
            }
        }

        private void deleteWorkout(object sender, EventArgs e)
        {
            // Make sure item is selected
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var box = new DateWorkouts(dateTimePicker1.Text);
            box.Show();
        }
    }
}
