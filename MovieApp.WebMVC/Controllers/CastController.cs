using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CastApp.WebMVC.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastService _castService;
        public CastController(ICastService service)
        {
            _castService = service;
        }

        public IActionResult Index()
        {
            var result = _castService.GetAllCast();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cast cast)
        {
            if (ModelState.IsValid)
            {
                _castService.AddCast(cast);
                return RedirectToAction("Index");
            }
            return View(cast);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _castService.GetCastById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Cast cast)
        {
            if (ModelState.IsValid)
            {
                _castService.UpdateCast(cast, cast.Id);
                return RedirectToAction("Index");
            }
            return View(cast);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _castService.GetCastById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Cast cast)
        {
            _castService.DeleteCast(cast.Id);
            return RedirectToAction("Index");
        }
    }
}
