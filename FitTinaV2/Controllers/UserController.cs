using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitTinaV2.Models;
using FitTinaV2.Repositories;

namespace FitTinaV2.Controllers
{
    public class UserController : Controller
    {
        IUserRepository repo;


        public UserController(IUserRepository r)
        {
            repo = r;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateProfile()
        {
            return View();
        }


        [HttpPost]
        // adds a user
        public IActionResult CreateProfile(User user)
        {
            // convert feet / inches to height before saving to db
            user.Height = user.FeetInchesToTotalHeight(user.Feet, user.Inches);

            // add to db
            repo.AddUser(user);

            return View(user);
        }


        public IActionResult Profile()
        {
            return View();
        }
    }
}
