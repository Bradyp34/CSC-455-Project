using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace CSC_455_Project {
    public partial class Main : Form
    {

        private HashSet<Workout> workouts;

        private HashSet<WorkoutDay> workoutDays;


        public Main()
        {
            InitializeComponent();

            // Save workouts
            try
            {
                
                string fileName = "Workouts.json";
                string jsonString = File.ReadAllText(fileName);
                workouts = JsonSerializer.Deserialize<HashSet<Workout>>(jsonString)!;
                foreach (Workout workout in workouts)
                {
                    listBox1.Items.Add(workout.name);
                }
            }
            catch(Exception ex)
            {
                workouts = new HashSet<Workout>();
            }
            workouts.OnDeserialization(this);


            // Save WorkoutDays
            try
            {

                string fileName = "WorkoutDays.json";
                string jsonString = File.ReadAllText(fileName);
                workoutDays = JsonSerializer.Deserialize<HashSet<WorkoutDay>>(jsonString)!;
            }
            catch (Exception ex)
            {
                workoutDays = new HashSet<WorkoutDay>();
            }
            workoutDays.OnDeserialization(this);
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
            
            string fileName = "Workouts.json";
            string jsonString = JsonSerializer.Serialize(workouts);
            File.WriteAllText(fileName, jsonString);
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
                    box.ShowDialog();
                }
            }
            string jsonString = JsonSerializer.Serialize(workouts);
            string fileName = "Workouts.json";
            File.WriteAllText(fileName, jsonString);
        }

        private void deleteWorkout(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;
            

            // Make sure item is selected
            if (selectedItem!= null)
            {
                string name = selectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                workouts.Remove(workouts.FirstOrDefault(x => x.name == name));
                string fileName = "Workouts.json";
                string jsonString = JsonSerializer.Serialize(workouts);
                File.WriteAllText(fileName, jsonString);
            }
            // Add Remove Workout from list
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var workday = new WorkoutDay(DateOnly.Parse(dateTimePicker1.Value.ToShortDateString()));
            var box = new DateWorkouts(workday);
            box.ShowDialog();

            // If added items to save.
            if(workday.exercises.Count > 0)
            {
                workoutDays.Add(workday);

                // Save to File
                string fileName = "WorkoutsDays.json";
                string jsonString = JsonSerializer.Serialize(workoutDays);
                File.WriteAllText(fileName, jsonString);
            }
        }
    }
}
