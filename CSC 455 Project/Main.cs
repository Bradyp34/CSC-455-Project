using System.Security.Cryptography.X509Certificates;

namespace CSC_455_Project {
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            listBox1.Items.Add(textBox1.Text);
            // TODO: Save data to JSON File
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editWorkout(object sender, EventArgs e)
        {

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
