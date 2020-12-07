using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitTinaV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitTinaV2.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Build()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Build(BuildVM build)
        {
            return View(build);
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
