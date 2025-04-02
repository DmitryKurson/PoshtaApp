using Microsoft.EntityFrameworkCore;
using PoshtaApp.Models;

namespace PoshtaApp.Services
{
    public interface IPostIndexService
    {
        Task<bool> ImportIndexesFromCsvAsync(IFormFile file);
        //Task<List<Aup>> GetIndexesByCityAsync(string cityName);
        Task<List<Aup>> GetIndexesWithoutCityAsync();


        Task<List<Aup>> GetIndexesWithoutRegionAsync();


        Task<List<Aup>> GetIndexesWithoutOblastAsync();

        Task<List<Aup>> GetAllIndexesAsync();

    }
}
