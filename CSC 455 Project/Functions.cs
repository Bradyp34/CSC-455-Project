using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_455_Project
{
    public static class Functions
    {

        // Search Functions
        public static Workout SearchForWorkout(HashSet<Workout> workouts, string name) 
        {
            return workouts.FirstOrDefault(i => i.name == name);
        }

        public static Exercise SearchForExercise(HashSet<Exercise> exercises, string name)
        {
            return exercises.FirstOrDefault(i => i.name == name);
        }

        public static void SaveWorkouts(HashSet<Workout> workouts)
        {
            string jsonString = JsonSerializer.Serialize(workouts);
            string fileName = "Workouts.json";
            File.WriteAllText(fileName, jsonString);
        }

        public static HashSet<Workout> LoadWorkouts() 
        {
            // Load workouts
            try
            {

                string fileName = "Workouts.json";
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<HashSet<Workout>>(jsonString)!;
                
            }
            catch (Exception ex)
            {
                return new HashSet<Workout>();
            }
        }

        public static void SaveWorkoutDates(HashSet<WorkoutDay> workoutDays)
        {
            string fileName = "WorkoutDays.json";
            string jsonString = JsonSerializer.Serialize(workoutDays);
            File.WriteAllText(fileName, jsonString);
        }

        public static HashSet<WorkoutDay> LoadWorkoutDates()
        {
            try
            {

                string fileName = "WorkoutDays.json";
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<HashSet<WorkoutDay>>(jsonString)!;
            }
            catch (Exception ex)
            {
                return new HashSet<WorkoutDay>();
            }
        }

        public static WorkoutDay CheckForWorkoutDay(HashSet<WorkoutDay> workoutDays, string date)
        {
            // Check if already exists
            WorkoutDay exist = workoutDays.FirstOrDefault(x => x.day == DateOnly.Parse(date));
            WorkoutDay workday;
            if (exist != null)
            {
                workday = exist;
            }
            else
            {
                workday = new WorkoutDay(DateOnly.Parse(date));
            }
            return workday;
        }

        public static void RemoveExercise(HashSet<Exercise> exercises, string name)
        {
            exercises.Remove(exercises.FirstOrDefault(x => x.name == name));
        }
	}
}
