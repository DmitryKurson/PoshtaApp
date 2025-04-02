using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PoshtaApp.Models;
using PoshtaApp.Services;
using PoshtaApp.ViewModels;

namespace PoshtaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CityService _cityService;
        private readonly RegionService _regionService;
        private readonly PostIndexService _postIndexService;

        public HomeController(CityService cityService, RegionService regionService, PostIndexService postIndexService)
        {
            _cityService = cityService;
            _regionService = regionService;
            _postIndexService = postIndexService;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var cities = await _cityService.GetAllCitiesAsync();
            var oblasti = await _regionService.GetAllOblastiAsync();
            var kraji = await _regionService.GetAllKrajiAsync();
            var indexes = await _postIndexService.GetAllIndexesAsync();

            var model = new HomeViewModel
            {
                Cities = cities,
                Oblasti = oblasti,
                Kraji = kraji,
                Indexes = indexes
            };

            return View(model);
        }

    }
}
