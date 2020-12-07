using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FitTinaV2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateProfile()
        {
            return View();
        }


        public IActionResult Profile()
        {
            return View();
        }
    }
}
