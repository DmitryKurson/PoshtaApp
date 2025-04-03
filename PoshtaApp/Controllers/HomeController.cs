using System.Diagnostics;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Text;
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

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index(string filter = "all")
        {
            List<Aup> indexes;

            switch (filter)
            {
                case "noCity":
                    indexes = await _postIndexService.GetIndexesWithoutCityAsync();
                    break;
                case "noRegion":
                    indexes = await _postIndexService.GetIndexesWithoutRegionAsync();
                    break;
                case "noOblast":
                    indexes = await _postIndexService.GetIndexesWithoutOblastAsync();
                    break;
                default:
                    indexes = await _postIndexService.GetAllIndexesAsync();
                    break;
            }

            ViewBag.Filter = filter;
            ViewBag.Count = indexes.Count;
            return View(indexes);
        }

        public async Task<IActionResult> ExportIndexesToCsv(string filter)
        {
            List<Aup> indexes;
            switch (filter)
            {
                case "noCity":
                    indexes = await _postIndexService.GetIndexesWithoutCityAsync();
                    break;
                case "noRegion":
                    indexes = await _postIndexService.GetIndexesWithoutRegionAsync();
                    break;
                case "noOblast":
                    indexes = await _postIndexService.GetIndexesWithoutOblastAsync();
                    break;
                default:
                    indexes = await _postIndexService.GetAllIndexesAsync();
                    break;
            }

            var memoryStream = new MemoryStream();

            using (var writer = new StreamWriter(memoryStream, Encoding.UTF8, 1024, leaveOpen: true))
            {
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
                {
                    csv.WriteRecords(indexes);
                }
            }
            memoryStream.Seek(0, SeekOrigin.Begin);
            return File(memoryStream.ToArray(), "text/csv", "indexes.csv");
        }





    }
}
