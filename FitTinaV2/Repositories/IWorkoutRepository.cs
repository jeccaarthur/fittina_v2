using System;
using System.Linq;
using FitTinaV2.Models;

namespace FitTinaV2.Repositories
{
    public interface IWorkoutRepository
    {
        IQueryable<Workout> Workouts { get; }
        IQueryable<Exercise> Exercises { get; }
    }
}
