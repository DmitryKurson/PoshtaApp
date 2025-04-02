using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using PoshtaApp.Data;
using PoshtaApp.Models;
using System;
using System.Formats.Asn1;
using System.Globalization;

namespace PoshtaApp.Services
{
    public class PostIndexService
    {
        //private readonly ApplicationContext _context;

        //public PostIndexService(ApplicationContext context)
        //{
        //    _context = context;
        //}

        //public async Task<bool> ImportIndexesFromCsvAsync(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return false;

        //    using var stream = file.OpenReadStream();
        //    using var reader = new StreamReader(stream);
        //    using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
        //    {
        //        Delimiter = ";",
        //        Encoding = System.Text.Encoding.UTF8
        //    });

        //    var records = csv.GetRecords<CsvIndexModel>().ToList();

        //    foreach (var record in records)
        //    {
        //        var obl = await _context.Oblasti.FirstOrDefaultAsync(o => o.Name == record.OblName);
        //        var kraj = await _context.Kraj.FirstOrDefaultAsync(k => k.Name == record.KrajName);
        //        var city = await _context.Cities.FirstOrDefaultAsync(c => c.Name == record.CityName);

        //        var aup = new Aup
        //        {
        //            Index = record.Index,
        //            CityId = city?.Id,
        //            CityName = record.CityName,
        //            OblId = obl?.Id,
        //            OblName = record.OblName,
        //            KrajId = kraj?.Id,
        //            KrajName = record.KrajName
        //        };

        //        _context.Aup.Add(aup);
        //    }

        //    await _context.SaveChangesAsync();
        //    return true;
        //}
        //public async Task<List<Aup>> GetIndexesByCityAsync(string cityName)
        //{

        //}
    }

}
