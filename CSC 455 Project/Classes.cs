using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSC_455_Project
{

    public class WorkoutDay
    {
        public DateOnly day { get; set; }
        public HashSet<Exercise> exercises { get; set; }


        public override int GetHashCode()
        {
            return day.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is WorkoutDay)
            {
                return this.day == ((WorkoutDay)obj).day;
            }
            return false;
        }

        public WorkoutDay(DateOnly day) 
        {
            this.day = day;
            exercises = new HashSet<Exercise>();
        }
    }

    public enum Muscles
    {
        Chest,
        Biceps,
        Triceps,
        Lats,
        Quads,
        Hamstrings,
        Glutes,
        Back,
        Shoulder,
        Calves
    }

    public class Workout
    {
        public string name { get; set; }

        public HashSet<Exercise> exercises { get; set; }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Workout)
            {
                return this.name == ((Workout)obj).name;
            }
            return false;
        }

        public Workout(string name)
        {
            if (name == null) throw new ArgumentNullException("No Name");
            this.name = name;
            this.exercises = new HashSet<Exercise>();
        }

        public void addExercise(Exercise exercise) 
        {
            exercises.Add(exercise);
        }

        public void removeExercise(Exercise exercise)
        {
            exercises.Remove(exercise);
        }

    }


    public class Exercise
    {
        public string name { get; set; }

        public HashSet<Muscles> musclesHit { get; set; }

        public int sets { get; set; }

        public int reps { get; set; }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Exercise)
            {
                return this.name == ((Exercise)obj).name;
            }
            return false;
        }

        public Exercise(string name)
        {
            if (name == null) throw new ArgumentNullException("No Name");
            this.name = name;
            this.musclesHit = new HashSet<Muscles>();
        }
	}
}
