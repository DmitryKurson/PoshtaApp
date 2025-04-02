﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoshtaApp.Data;

#nullable disable

namespace PoshtaApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20250402203530_initia")]
    partial class initia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PoshtaApp.Models.Aup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityId")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int?>("KrajId")
                        .HasColumnType("int");

                    b.Property<string>("KrajName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OblId")
                        .HasColumnType("int");

                    b.Property<string>("OblName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Aup");
                });

            modelBuilder.Entity("PoshtaApp.Models.City", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("KrajId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OblId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KrajId");

                    b.HasIndex("OblId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("PoshtaApp.Models.Kraj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Kraj");
                });

            modelBuilder.Entity("PoshtaApp.Models.Obl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Oblasti");
                });

            modelBuilder.Entity("PoshtaApp.Models.Aup", b =>
                {
                    b.HasOne("PoshtaApp.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("PoshtaApp.Models.City", b =>
                {
                    b.HasOne("PoshtaApp.Models.Kraj", "Kraj")
                        .WithMany("Cities")
                        .HasForeignKey("KrajId");

                    b.HasOne("PoshtaApp.Models.Obl", "Obl")
                        .WithMany("Cities")
                        .HasForeignKey("OblId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kraj");

                    b.Navigation("Obl");
                });

            modelBuilder.Entity("PoshtaApp.Models.Kraj", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("PoshtaApp.Models.Obl", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
