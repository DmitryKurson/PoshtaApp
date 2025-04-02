using Microsoft.EntityFrameworkCore;
using PoshtaApp.Models;

namespace PoshtaApp.Services
{
    public interface IRegionService
    {
        Task<List<Raj>> GetAllRegionsAsync();
        Task<Raj?> GetRegionByNameAsync(string name);





        Task<List<Obl>> GetAllOblastiAsync();
        Task<List<Raj>> GetAllKrajiAsync();
        Task<Obl?> GetOblByNameAsync(string name);
        Task<Raj?> GetKrajByNameAsync(string name);

    }
}
