using Microsoft.EntityFrameworkCore;
using PoshtaApp.Data;
using PoshtaApp.Services;
using System;

namespace PoshtaApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // –еЇстрац≥€ серв≥с≥в
            builder.Services.AddScoped<IRegionService, RegionService>();
            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<IPostIndexService, PostIndexService>();

            

            var app = builder.Build();

            var scope = app.Services.CreateScope();
            var postIndexService = scope.ServiceProvider.GetRequiredService<IPostIndexService>();

            await postIndexService.ImportFromExcelAsync();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}
