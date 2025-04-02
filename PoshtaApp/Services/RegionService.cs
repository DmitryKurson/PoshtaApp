using Microsoft.EntityFrameworkCore;
using PoshtaApp.Data;
using PoshtaApp.Models;
using System;

namespace PoshtaApp.Services
{
    public class RegionService:IRegionService
    {
        private readonly ApplicationContext _context;

        public RegionService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Obl>> GetAllOblastiAsync()
        {
            return await _context.Oblasti.ToListAsync();
        }

        public async Task<List<Raj>> GetAllKrajiAsync()
        {
            return await _context.Rajs.ToListAsync();
        }

        public async Task<Obl?> GetOblByNameAsync(string name)
        {
            return await _context.Oblasti.FirstOrDefaultAsync(o => o.Name == name);
        }

        public async Task<Raj?> GetKrajByNameAsync(string name)
        {
            return await _context.Rajs.FirstOrDefaultAsync(k => k.Name == name);
        }
        public async Task<List<Raj>> GetAllRegionsAsync()
        {
            return await _context.Rajs.ToListAsync();
        }

        public async Task<Raj?> GetRegionByNameAsync(string name)
        {
            return await _context.Rajs.FirstOrDefaultAsync(r => r.Name == name);
        }
    }

}
