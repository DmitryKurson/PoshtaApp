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

        public IActionResult Privacy()
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

            // Отримуємо індекси за фільтром
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

            // Створюємо MemoryStream для CSV
            var memoryStream = new MemoryStream();

            // Використовуємо StreamWriter для запису в потік
            using (var writer = new StreamWriter(memoryStream, Encoding.UTF8, 1024, leaveOpen: true))
            {
                // Використовуємо CsvWriter для запису в CSV
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
                {
                    // Записуємо дані в CSV
                    csv.WriteRecords(indexes);
                }
            }

            // Потрібно перемістити курсор назад на початок потоку
            memoryStream.Seek(0, SeekOrigin.Begin);

            // Повертаємо файл для завантаження
            return File(memoryStream.ToArray(), "text/csv", "indexes.csv");
        }





    }
}
