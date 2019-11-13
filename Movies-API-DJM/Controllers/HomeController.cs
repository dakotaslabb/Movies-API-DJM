using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies_API_DJM.Models;

namespace Movies_API_DJM.Controllers
{
    public class HomeController : Controller
    {
        MoviesDbContext db = new MoviesDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
       
        public IActionResult Result(string Title)
        {
            TempData["Title"] = Title;
            MovieSearch MyMovies = MoviesDAL.SearchMoviesAPI(Title);
            return View(MyMovies.Title);
        }
        public IActionResult MovieDetails(string Title)
        {
            Movies MyMovies = MoviesDAL.FindTitleAPI(Title);
            return View(MyMovies);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public int GetUserId(string userName)
        {
            var users = db.Users.Where(x => x.UserName == userName);
            List<User> userList = db.Users.ToList();

            for (int i = 0; i < userList.Count; i++)
            {
                User u = userList[i];
                if (u.UserName == userName)
                {
                    return u.Id;
                }
            }
            return 0;

        }
        public IActionResult AddToFavorites(string Title)
        {
            string userName = Request.Cookies["userNameCookie"];
            int userId;
            if (userName != null)
            {
                userId = GetUserId(userName);
                Movies MyMovie = MoviesDAL.FindTitleAPI(Title);
                var dataInput = new Movies { imdbID = MyMovie.imdbID, UserId = userId, Plot = MyMovie.Plot, Rated = MyMovie.Rated, Title = MyMovie.Title, Year = MyMovie.Year };
                db.Add(dataInput);
                db.SaveChanges();
                return RedirectToAction("Search");
            }
            else
            {
                ViewData["Message"] = "You are not Logged in! try again";
                return RedirectToAction("Login", "Login");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
