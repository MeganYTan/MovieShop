using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MovieApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService service)
        {
            _movieService = service;
        }

        public IActionResult Index()
        {
            var result = _movieService.GetAllMovie();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.AddMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _movieService.GetMovieById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.UpdateMovie(movie, movie.Id);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _movieService.GetMovieById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieService.DeleteMovie(movie.Id);
            return RedirectToAction("Index");
        }
    }
}
