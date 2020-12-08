using System;
using FitTinaV2.Models;
using FitTinaV2.Repositories;
using FitTinaV2.Controllers;
using System.Linq;
using Xunit;

namespace FitTinaTests
{
    public class WorkoutTests
    {
        [Fact]
        // test adding new workout
        public void TestAddWorkout()
        {
            // arrange
            var fakeRepo = new FakeWorkoutRepository();
            var controller = new WorkoutController(fakeRepo);
            var workout = new Workout()
            {
                Name = "Test Workout",
                Effort = "medium",
                UserName = "Test",
            };

            // act
            controller.Build(workout);

            // assert
            // get new workout from db
            var workoutFromDb = fakeRepo.Workouts.ToList()[0];
            Assert.Equal(1, workoutFromDb.WorkoutID);
            Assert.Equal("Test Workout", workoutFromDb.Name);
            Assert.Equal(3, workoutFromDb.Sets);
            Assert.Equal(12, workoutFromDb.Reps);
            Assert.NotNull(workout.Exercise1);
            Assert.NotNull(workout.Exercise2);
            Assert.NotNull(workout.Exercise3);
            Assert.NotNull(workout.Exercise4);
            Assert.NotNull(workout.Exercise5);
            Assert.NotNull(workout.Exercise6);
            Assert.Equal("Test", workoutFromDb.User.Name);

            // test failing - must add exercises to list manually
        }
    }
}
