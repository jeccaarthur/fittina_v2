using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitTinaV2.Models;
using Microsoft.AspNetCore.Mvc;
using FitTinaV2.Repositories;

namespace FitTinaV2.Controllers
{
    public class WorkoutController : Controller
    {
        IWorkoutRepository repo;


        public WorkoutController(IWorkoutRepository r)
        {
            repo = r;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Build()
        {
            ViewBag.Current = "Build";
            return View();
        }


        [HttpPost]
        public IActionResult Build(Workout workout)
        {
            ViewBag.Current = "About";

            // call method to set workout properties
            repo.BuildWorkout(workout);

            // add workout to db
            repo.AddWorkout(workout);

            return View(workout);
        }


        public IActionResult Library()
        {
            ViewBag.Current = "Library";
            List<Workout> workouts = new List<Workout>();
            return View(workouts);
        }


        [HttpPost]
        public IActionResult Library(string name)
        {
            ViewBag.Current = "Library";
            var workouts = repo.GetWorkoutsByUserName(name);
            return View(workouts);
        }


        public IActionResult Help()
        {
            ViewBag.Current = "Help";
            return View();
        }


        [HttpPost]
        public IActionResult Help(string name)
        {
            ViewBag.Current = "Help";
            Exercise exercise = repo.GetExerciseByName(name);
            return View(exercise);
        }
    }
}
