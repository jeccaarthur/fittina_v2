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
        private List<User> users = new List<User>();
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


        public IQueryable<User> Users
        {
            get
            {
                return users.AsQueryable<User>();
            }
        }


        public Workout BuildWorkout(Workout workout)
        {
            // convert effort to sets and reps
            workout.Sets = workout.GetSets(workout.Effort);
            workout.Reps = workout.GetReps(workout.Effort);

            // get exercises
            workout.Exercise1 = GetRandomExercise();
            workout.Exercise2 = GetRandomExercise();
            workout.Exercise3 = GetRandomExercise();
            workout.Exercise4 = GetRandomExercise();
            workout.Exercise5 = GetRandomExercise();
            workout.Exercise6 = GetRandomExercise();

            // get date
            workout.DateCreated = DateTime.Today;

            // get associated user
            workout.User = users.Where(u => u.Name == workout.UserName).SingleOrDefault();

            return workout;
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
            int max = exercises.Count;
            int num = rnd.Next(1, max);

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
