using System;
using System.Collections.Generic;
using System.Linq;
using FitTinaV2.Models;

namespace FitTinaV2.Repositories
{
    public interface IWorkoutRepository
    {
        IQueryable<Workout> Workouts { get; }
        IQueryable<Exercise> Exercises { get; }
        IQueryable<User> Users { get; }

        // workout methods
        Workout BuildWorkout(Workout workout);
        void AddWorkout(Workout workout);
        List<Workout> GetWorkoutsByUserName(string name);

        // exercise methods
        Exercise GetExerciseByID(int id);
        Exercise GetExerciseByName(string name);
        Exercise GetRandomExercise();
    }
}
