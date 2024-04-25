﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_455_Project
{
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
        public string name;

        public List<Exercise> exercises;

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
            this.exercises = new List<Exercise>();
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
        public string name;

        public List<Muscles> musclesHit;

        public int sets;

        public int reps;

        public Exercise(string name)
        {
            if (name == null) throw new ArgumentNullException("No Name");
            this.name = name;
            this.musclesHit = new List<Muscles>();
        }
    }
}
