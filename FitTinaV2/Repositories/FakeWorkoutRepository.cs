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
            // create fake exercise list to pull from for testing
            exercises = FakeExerciseList();

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
            workout.WorkoutID = workouts.Count + 1;

            // add workout to list
            workouts.Add(workout);
        }


        public Exercise GetExerciseByID(int id)
        {
            return exercises.Find(e => e.ExerciseID == id);
        }


        public Exercise GetExerciseByName(string name)
        {
            return exercises.Where(e => e.Name == name).SingleOrDefault();
        }


        public Exercise GetRandomExercise()
        {
            int max = exercises.Count + 1;
            int num = rnd.Next(1, max);

            return exercises.Find(e => e.ExerciseID == num);
        }


        public List<Workout> GetWorkoutsByUserName(string name)
        {
            List<Workout> workoutList = workouts.Where(w => w.User.Name == name).ToList();

            return workoutList;
        }

        // add 6 fake exercises to list to test with
        public List<Exercise> FakeExerciseList()
        {
            Exercise e1 = new Exercise();
            e1.ExerciseID = 1;
            e1.Name = "Test name 1";
            e1.Type = "Test type";
            e1.EquipmentRequired = "Test equipment";
            e1.VideoUrl = "Test url";
            exercises.Add(e1);

            Exercise e2 = new Exercise();
            e2.ExerciseID = 2;
            e2.Name = "Test name 2";
            e2.Type = "Test type";
            e2.EquipmentRequired = "Test equipment";
            e2.VideoUrl = "Test url";
            exercises.Add(e2);

            Exercise e3 = new Exercise();
            e3.ExerciseID = 3;
            e3.Name = "Test name 3";
            e3.Type = "Test type";
            e3.EquipmentRequired = "Test equipment";
            e3.VideoUrl = "Test url";
            exercises.Add(e3);

            Exercise e4 = new Exercise();
            e4.ExerciseID = 4;
            e4.Name = "Test name 4";
            e4.Type = "Test type";
            e4.EquipmentRequired = "Test equipment";
            e4.VideoUrl = "Test url";
            exercises.Add(e4);

            Exercise e5 = new Exercise();
            e5.ExerciseID = 5;
            e5.Name = "Test name 5";
            e5.Type = "Test type";
            e5.EquipmentRequired = "Test equipment";
            e5.VideoUrl = "Test url";
            exercises.Add(e5);

            Exercise e6 = new Exercise();
            e6.ExerciseID = 6;
            e6.Name = "Test name 6";
            e6.Type = "Test type";
            e6.EquipmentRequired = "Test equipment";
            e6.VideoUrl = "Test url";
            exercises.Add(e6);

            return exercises;
        }

        public User GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public Exercise GetBodyweightExercise()
        {
            throw new NotImplementedException();
        }
    }
}
