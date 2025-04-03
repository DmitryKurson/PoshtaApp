using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PoshtaApp.Models;

namespace PoshtaApp.Services
{
    public interface IPostIndexService
    {
        Task ImportFromExcelAsync();
        Task<List<Aup>> GetIndexesWithoutCityAsync();
        Task<List<Aup>> GetIndexesWithoutRegionAsync();
        Task<List<Aup>> GetIndexesWithoutOblastAsync();
        Task<List<Aup>> GetAllIndexesAsync();
    }
}
