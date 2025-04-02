using PoshtaApp.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace PoshtaApp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Obl> Oblasti { get; set; }
        public DbSet<Raj> Rajs { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Aup> Aup { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 🔹 One-to-Many: Obl (Область) → Raj (Райони)
            modelBuilder.Entity<Raj>()
                .HasOne(r => r.Obl)
                .WithMany(o => o.Rajs)   // <=== Додаємо колекцію районів в Obl
                .HasForeignKey(r => r.OblId);

            // 🔹 One-to-Many: Obl (Область) → City (Міста)
            modelBuilder.Entity<City>()
                .HasOne(c => c.Obl)
                .WithMany(o => o.Cities)
                .HasForeignKey(c => c.OblId);

            // 🔹 One-to-Many: Raj (Район) → City (Міста)
            modelBuilder.Entity<City>()
                .HasOne(c => c.Kraj)
                .WithMany(k => k.Cities)
                .HasForeignKey(c => c.KrajId)
                .IsRequired(false); // Район може бути NULL

            // 🔹 One-to-Many: City (Місто) → Aup (Поштові індекси)
            modelBuilder.Entity<Aup>()
                .HasOne(a => a.City)
                .WithMany()
                .HasForeignKey(a => a.CityId)
                .IsRequired(false);



            //// Додаємо області (Obl)
            //modelBuilder.Entity<Obl>().HasData(
            //    new Obl { Id = 1, Name = "Київська" },
            //    new Obl { Id = 2, Name = "Львівська" },
            //    new Obl { Id = 3, Name = "Одеська" },
            //    new Obl { Id = 4, Name = "Дніпропетровська" },
            //    new Obl { Id = 5, Name = "Харківська" }
            //);

            //// Додаємо райони (Raj)
            //modelBuilder.Entity<Raj>().HasData(
            //    new Raj { Id = 1, Name = "Шевченківський" },
            //    new Raj { Id = 2, Name = "Оболонський" },
            //    new Raj { Id = 3, Name = "Франківський" },
            //    new Raj { Id = 4, Name = "Личаківський" },
            //    new Raj { Id = 5, Name = "Приморський" },
            //    new Raj { Id = 6, Name = "Малиновський" },
            //    new Raj { Id = 7, Name = "Індустріальний" },
            //    new Raj { Id = 8, Name = "Новокодацький" },
            //    new Raj { Id = 9, Name = "Київський" },
            //    new Raj { Id = 10, Name = "Московський" }
            //);

            //// Додаємо міста (City)
            //modelBuilder.Entity<City>().HasData(
            //    new City { Id = "1001", Name = "Київ", OblId = 1, KrajId = 1 },
            //    new City { Id = "1002", Name = "Бровари", OblId = 1, KrajId = null },
            //    new City { Id = "2001", Name = "Львів", OblId = 2, KrajId = 3 },
            //    new City { Id = "2002", Name = "Дрогобич", OblId = 2, KrajId = null },
            //    new City { Id = "3001", Name = "Одеса", OblId = 3, KrajId = 5 },
            //    new City { Id = "3002", Name = "Чорноморськ", OblId = 3, KrajId = null },
            //    new City { Id = "4001", Name = "Дніпро", OblId = 4, KrajId = 7 },
            //    new City { Id = "4002", Name = "Кам'янське", OblId = 4, KrajId = null },
            //    new City { Id = "5001", Name = "Харків", OblId = 5, KrajId = 9 },
            //    new City { Id = "5002", Name = "Чугуїв", OblId = 5, KrajId = null }
            //);
        }
    }
}
