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
        public DbSet<Kraj> Kraj { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Aup> Aup { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasOne(c => c.Obl)
                .WithMany(o => o.Cities)
                .HasForeignKey(c => c.OblId);

            modelBuilder.Entity<City>()
                .HasOne(c => c.Kraj)
                .WithMany(k => k.Cities)
                .HasForeignKey(c => c.KrajId)
                .IsRequired(false);

            modelBuilder.Entity<Aup>()
                .HasOne(a => a.City)
                .WithMany()
                .HasForeignKey(a => a.CityId)
                .IsRequired(false);
        }
    }
}
