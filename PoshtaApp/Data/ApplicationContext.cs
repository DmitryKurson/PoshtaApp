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
            // Зв’язок AUP → City (по CityId)
            modelBuilder.Entity<Aup>()
                .HasOne(a => a.City)
                .WithMany(c => c.Aups)
                .HasForeignKey(a => a.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            // Зв’язок City → Rajon (по RajId)
            modelBuilder.Entity<City>()
                .HasOne(c => c.Raj)
                .WithMany(r => r.Cities)
                .HasForeignKey(c => c.RajId)
                .OnDelete(DeleteBehavior.Restrict);

            // Зв’язок City → Oblast (по OblId)
            modelBuilder.Entity<City>()
                .HasOne(c => c.Obl)
                .WithMany(o => o.Cities)
                .HasForeignKey(c => c.OblId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<City>()
            .Property(c => c.Id)
            .HasColumnType("NVARCHAR(20)");

            modelBuilder.Entity<Raj>().HasData(
                new Raj { Id = 1, Name = "Фастівський" },
                new Raj { Id = 2, Name = "Білоцерківський" },
                new Raj { Id = 3, Name = "Полтавський" },
                new Raj { Id = 4, Name = "Уманський" },
                new Raj { Id = 5, Name = "Кам’янець-Подільський" },
                new Raj { Id = 6, Name = "Драбівський" },
                new Raj { Id = 7, Name = "Дергачівський" },
                new Raj { Id = 8, Name = "Валківський" },
                new Raj { Id = 9, Name = "Кагарлицький" }
            );

            modelBuilder.Entity<Obl>().HasData(
                new Obl { Id = 1101, Name = "Київська" },
                new Obl { Id = 1103, Name = "Чернігівська" },
                new Obl { Id = 1104, Name = "Сумська" },
                new Obl { Id = 1105, Name = "Черкаська" },
                new Obl { Id = 1107, Name = "Полтавська" },
                new Obl { Id = 1108, Name = "Миколаївська" },
                new Obl { Id = 1110, Name = "Кіровоградська" },
                new Obl { Id = 1, Name = "Волинська" },
                new Obl { Id = 756, Name = "Харківська" },
                new Obl { Id = 1119, Name = "Херсонська" },
                new Obl { Id = 1127, Name = "Луганська" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = "00000", Name = "Мар’янівка", RajId = 9, OblId = 1101 },
                new City { Id = "00000007", Name = "с. Першотравневе", RajId = 8, OblId = 756 },
                new City { Id = "0000002", Name = "с. Кислівка", RajId = 7, OblId = 756 },
                new City { Id = "00000021", Name = "с-ще Ягідне", RajId = 6, OblId = 1105 },
                new City { Id = "00001", Name = "с. Білозірка", RajId = 5, OblId = 1108 },
                new City { Id = "000046", Name = "с. Матроска", RajId = 4, OblId = 1108 },
                new City { Id = "00063725", Name = "с. Кучерівка", RajId = 3, OblId = 1107 },
                new City { Id = "00007124", Name = "с. Проказине", RajId = 2, OblId = 1101 },
                new City { Id = "0008120", Name = "с. Садове", RajId = 1, OblId = 1101 },
                new City { Id = "00009322", Name = "с. Петренки", RajId = 3, OblId = 1107 },
                new City { Id = "001111", Name = "с. Кудринці", RajId = 5, OblId = 1104 },
                new City { Id = "000222222", Name = "с. Рункошів", RajId = 5, OblId = 1104 },
                new City { Id = "000222223", Name = "с. Думанів", RajId = 5, OblId = 1104 },
                new City { Id = "00063722", Name = "с. Синьківка", RajId = 6, OblId = 1105 },
                new City { Id = "00092742", Name = "с. Новоомелькове", RajId = 3, OblId = 1107 },
                new City { Id = "00092743", Name = "с. Омелькове", RajId = 3, OblId = 1107 },
                new City { Id = "00112233", Name = "м. Яслав", RajId = 1, OblId = 1 }
            );
        }
    }
}
