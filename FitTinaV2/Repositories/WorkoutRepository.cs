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


        // takes input name from user to set user property of workout
        public User GetUserByName(string name)
        {
            name = name.ToLower();

            return Users.Where(u => u.Name.ToLower() == name).SingleOrDefault();
        }


        // takes workout and sets properties
        public Workout BuildWorkout(Workout workout)
        {
            // convert effort to sets and reps
            workout.Sets = workout.GetSets(workout.Effort);
            workout.Reps = workout.GetReps(workout.Effort);

            // set user property
            workout.User = GetUserByName(workout.UserName);

            // get exercises based on user's equipment preference
            if (workout.User.EquipmentPref == "No Equipment")
            {
                // get bodyweight exercises
                workout.Exercise1 = GetBodyweightExercise();
                workout.Exercise2 = GetBodyweightExercise();
                workout.Exercise3 = GetBodyweightExercise();
                workout.Exercise4 = GetBodyweightExercise();
                workout.Exercise5 = GetBodyweightExercise();
                workout.Exercise6 = GetBodyweightExercise();
            }
            else
            {
                // get random exercises
                workout.Exercise1 = GetRandomExercise();
                workout.Exercise2 = GetRandomExercise();
                workout.Exercise3 = GetRandomExercise();
                workout.Exercise4 = GetRandomExercise();
                workout.Exercise5 = GetRandomExercise();
                workout.Exercise6 = GetRandomExercise();
            }

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
            return context.Exercises.Find(id);
        }


        public Exercise GetExerciseByName(string name)
        {
            name = name.ToLower();
            return context.Exercises.Where(e => e.Name.ToLower() == name).SingleOrDefault();
        }


        public Exercise GetRandomExercise()
        {
            int max = Exercises.Count() + 1;
            int num = rnd.Next(1, max);

            return context.Exercises.Find(num);
        }


        public Exercise GetBodyweightExercise()
        {
            List<Exercise> bodyweight = context.Exercises
                .Where(e => e.EquipmentRequired == "Bodyweight").ToList();

            int max = bodyweight.Count();
            int num = rnd.Next(0, max);

            Exercise exercise = bodyweight[num];

            return exercise;
        }


        public List<Workout> GetWorkoutsByUserName(string name)
        {
            name = name.ToLower();

            List<Workout> workouts = new List<Workout>();

            workouts = context.Workouts.Where(w => w.User.Name.ToLower() == name)
                .Include(w => w.User)
                .Include(w => w.Exercise1)
                .Include(w => w.Exercise2)
                .Include(w => w.Exercise3)
                .Include(w => w.Exercise4)
                .Include(w => w.Exercise5)
                .Include(w => w.Exercise6)
                .ToList();

            return workouts;
        }
    }
}
