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
            return View();
        }


        [HttpPost]
        public IActionResult Build(Workout workout)
        {
            // call method to set workout properties
            repo.BuildWorkout(workout);

            // add workout to db
            repo.AddWorkout(workout);

            return View(workout);
        }


        public IActionResult Library()
        {
            return View();
        }


        //[HttpPost]
        //public IActionResult Library()
        //{
        //    return View();
        //}


        public IActionResult Help()
        {
            return View();
        }


        //[HttpPost]
        //public IActionResult Help()
        //{
        //    return View();
        //}
    }
}
