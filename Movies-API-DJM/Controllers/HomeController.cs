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
        public IActionResult AddToFavorites(string Title)
        {
            Movies MyMovie = MoviesDAL.FindTitleAPI(Title);
            db.Add(MyMovie);
            db.SaveChanges();
            return RedirectToAction("Search");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
