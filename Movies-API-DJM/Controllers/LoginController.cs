using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies_API_DJM.Models;

namespace Movies_API_DJM.Controllers
{
    public class LoginController : Controller
    {
       MoviesDbContext db = new MoviesDbContext();

        public IActionResult ClearCookie()
        {
            Response.Cookies.Delete("userNameCookie");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            List<User> users = db.Users.ToList();

            for (int i = 0; i < users.Count; i++)
            {
                User u = users[i];
                if (u.UserName == userName && u.Password == password)
                {
                    Response.Cookies.Append("userNameCookie", u.UserName);
                    return RedirectToAction("Index", "Home");
                }
            }

            ViewData["Message"] = "Incorrect User name or password, please register or try again";
            return View();

        }

        // GET: Users/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Register(string userName, string password, string firstName, string lastName)
        {
            List<User> users = db.Users.ToList();

            for (int i = 0; i < users.Count; i++)
            {
                User u = users[i];
                if (u.UserName.Equals(userName))
                {
                    ViewData["Message"] = "That user already exists. Please try again!";
                    return View();
                }
            }

            if (ModelState.IsValid)
            {
                var dataInput = new User { UserName = userName, Password = password, FirstName= firstName, LastName = lastName };
                db.Add(dataInput);
                db.SaveChanges();
                ViewData["Message"] = "Successfully Created.";
                return View();
            }

            return View();

        }


    }
}