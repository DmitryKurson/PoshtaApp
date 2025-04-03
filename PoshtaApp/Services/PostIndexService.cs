using CsvHelper;
using CsvHelper.Configuration;
using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PoshtaApp.Data;
using PoshtaApp.Models;
using System;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Text;

namespace PoshtaApp.Services
{
    public class PostIndexService :IPostIndexService
    {
        private readonly ApplicationContext _context;
        private readonly IConfiguration _configuration;


        public PostIndexService(ApplicationContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task ImportFromExcelAsync()
        {
            string filePath = _configuration["ExcelFilePath"];

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл не знайдено за шляхом {filePath}");

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true,
                            //ReadHeaderRow = (rowReader) => rowReader.Read() // Пропускає перший рядок, якщо треба.
                        }
                    });

                    var dataTable = result.Tables[0];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        var index = row[5].ToString();  // F2
                        var cityName = row[4].ToString(); // E2
                        var rajName = row[3].ToString();  // D2
                        var oblName = row[1].ToString();  // B2

                        // Пошук існуючих даних у базі
                        var city = await _context.Cities.FirstOrDefaultAsync(c => c.Name == cityName);
                        var raj = await _context.Rajs.FirstOrDefaultAsync(r => r.Name == rajName);
                        var obl = await _context.Oblasti.FirstOrDefaultAsync(o => o.Name == oblName);

                        var aup = new Aup
                        {
                            Index = index,
                            CityName = cityName,
                            RajName = rajName,
                            OblName = oblName,
                            CityId = city?.Id,
                            RajId = raj?.Id,
                            OblId = obl?.Id
                        };

                        _context.Aup.Add(aup);
                    }

                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<Aup>> GetIndexesWithoutCityAsync()
        {
            return await _context.Aup.Where(a => a.CityId == null).ToListAsync();
        }

        public async Task<List<Aup>> GetIndexesWithoutRegionAsync()
        {
            return await _context.Aup.Where(a => a.RajId == null).ToListAsync();
        }

        public async Task<List<Aup>> GetIndexesWithoutOblastAsync()
        {
            return await _context.Aup.Where(a => a.OblId == null).ToListAsync();
        }

        public async Task<List<Aup>> GetAllIndexesAsync()
        {
            return await _context.Aup.ToListAsync();
        }
    }
}
