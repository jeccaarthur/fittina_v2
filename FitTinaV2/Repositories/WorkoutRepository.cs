using System;
using System.Collections.Generic;
using System.Linq;
using FitTinaV2.Models;
using Microsoft.EntityFrameworkCore;

namespace FitTinaV2.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private FitTinaDbContext context;
        Random rnd = new Random();

        public WorkoutRepository(FitTinaDbContext c)
        {
            context = c;
        }

        public IQueryable<Workout> Workouts
        {
            get
            {
                return context.Workouts.Include(w => w.DateCreated)
                    .Include(w => w.User)
                    .Include(w => w.Exercise1)
                    .Include(w => w.Exercise2)
                    .Include(w => w.Exercise3)
                    .Include(w => w.Exercise4)
                    .Include(w => w.Exercise5)
                    .Include(w => w.Exercise6);
            }
        }


        public IQueryable<Exercise> Exercises
        {
            get
            {
                return context.Exercises;
            }
        }


        public IQueryable<User> Users
        {
            get
            {
                return context.Users;
            }
        }


        // takes workout and sets properties
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
            workout.User = context.Users.Where(u => u.Name == workout.UserName).SingleOrDefault();

            return workout;
        }


        public void AddWorkout(Workout workout)
        {
            context.Workouts.Add(workout);
            context.SaveChanges();
        }


        public Exercise GetExerciseByID(int id)
        {
            Exercise exercise = new Exercise();
            exercise = context.Exercises.Find(id);

            return exercise;
        }


        public Exercise GetExerciseByName(string name)
        {
            Exercise exercise = new Exercise();
            exercise = context.Exercises.Where(e => e.Name == name).SingleOrDefault();

            return exercise;
        }


        public Exercise GetRandomExercise()
        {
            int num = rnd.Next(1, Exercises.Count());
            Exercise exercise = context.Exercises.Find(num);
            return exercise;
        }


        public List<Workout> GetWorkoutsByUserName(string name)
        {
            List<Workout> workouts = new List<Workout>();

            workouts = context.Workouts.Where(w => w.User.Name == name).ToList();

            return workouts;
        }
    }
}
