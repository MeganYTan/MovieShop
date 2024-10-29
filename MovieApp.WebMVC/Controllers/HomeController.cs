using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using MovieApp.WebMVC.Models;
using System.Diagnostics;

namespace MovieApp.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieRepository _movieRepository;
        public HomeController(ILogger<HomeController> logger, IMovieRepository movieRepo)
        {
            _logger = logger;
            _movieRepository = movieRepo;
        }

        public IActionResult Index()
        {
            IEnumerable<MovieCardModel> allMovies 
                = _movieRepository.GetAll()
                .Select(movie => new MovieCardModel
                {
                    Url = movie.PosterUrl
                })
                .ToList();
            return View(allMovies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
