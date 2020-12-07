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
