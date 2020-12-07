using System;
using System.Collections.Generic;
using System.Linq;
using FitTinaV2.Models;

namespace FitTinaV2.Repositories
{
    public class FakeWorkoutRepository : IWorkoutRepository
    {
        private List<Workout> workouts = new List<Workout>();
        private List<Exercise> exercises = new List<Exercise>();
        Random rnd = new Random();


        public IQueryable<Workout> Workouts
        {
            get
            {
                return workouts.AsQueryable<Workout>();
            }
        }


        public IQueryable<Exercise> Exercises
        {
            get
            {
                return exercises.AsQueryable<Exercise>();
            }
        }


        public void AddWorkout(Workout workout)
        {
            // simulate ai pk
            workout.WorkoutID = workouts.Count;

            // add workout to list
            workouts.Add(workout);
        }


        public Exercise GetExerciseByID(int id)
        {
            Exercise exercise = new Exercise();
            exercise = exercises.Find(e => e.ExerciseID == id);

            return exercise;
        }


        public Exercise GetExerciseByName(string name)
        {
            Exercise exercise = new Exercise();
            exercise = exercises.Where(e => e.Name == name).SingleOrDefault();

            return exercise;
        }


        public Exercise GetRandomExercise()
        {
            int num = rnd.Next(1, Exercises.Count());

            Exercise exercise = new Exercise();
            exercise = exercises.Find(e => e.ExerciseID == num);

            return exercise;
        }


        public List<Workout> GetWorkoutsByUserName(string name)
        {
            List<Workout> workoutList = new List<Workout>();
            workoutList = workouts.Where(w => w.User.Name == name).ToList();

            return workoutList;
        }
    }
}
