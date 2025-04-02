using PoshtaApp.Models;

namespace PoshtaApp.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllCitiesAsync();
        Task<City?> GetCityByNameAsync(string name);
    }
}
