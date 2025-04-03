using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PoshtaApp.Models;
using PoshtaApp.Services;
using PoshtaApp.ViewModels;

namespace PoshtaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IRegionService _regionService;
        private readonly IPostIndexService _postIndexService;

        public HomeController(ICityService cityService, IRegionService regionService, IPostIndexService postIndexService)
        {
            _cityService = cityService;
            _regionService = regionService;
            _postIndexService = postIndexService;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> GetAllPostIndex()
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


        //public async Task<IActionResult> GetIndexWithoutCity()
        //{
        //    var cities = await _cityService.GetAllCitiesAsync();
        //    var oblasti = await _regionService.GetAllOblastiAsync();
        //    var kraji = await _regionService.GetAllKrajiAsync();
        //    var indexes = await _postIndexService.GetAllIndexesAsync();

        //    var model = new HomeViewModel
        //    {
        //        Cities = cities,
        //        Oblasti = oblasti,
        //        Kraji = kraji,
        //        Indexes = indexes
        //    };

        //    return View(model);
        //}
    }
}
