using Microsoft.EntityFrameworkCore;
using PoshtaApp.Models;

namespace PoshtaApp.Services
{
    public interface IRegionService
    {
        Task<List<Obl>> GetAllOblastiAsync();
        Task<List<Raj>> GetAllKrajiAsync();
        Task<Obl?> GetOblByNameAsync(string name);
        Task<Raj?> GetKrajByNameAsync(string name);
    }
}
