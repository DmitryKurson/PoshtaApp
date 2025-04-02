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
    [Migration("20250402213254_added_raj_obl_relation")]
    partial class added_raj_obl_relation
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

                    b.HasData(
                        new
                        {
                            Id = "1001",
                            KrajId = 1,
                            Name = "Київ",
                            OblId = 1
                        },
                        new
                        {
                            Id = "1002",
                            Name = "Бровари",
                            OblId = 1
                        },
                        new
                        {
                            Id = "2001",
                            KrajId = 3,
                            Name = "Львів",
                            OblId = 2
                        },
                        new
                        {
                            Id = "2002",
                            Name = "Дрогобич",
                            OblId = 2
                        },
                        new
                        {
                            Id = "3001",
                            KrajId = 5,
                            Name = "Одеса",
                            OblId = 3
                        },
                        new
                        {
                            Id = "3002",
                            Name = "Чорноморськ",
                            OblId = 3
                        },
                        new
                        {
                            Id = "4001",
                            KrajId = 7,
                            Name = "Дніпро",
                            OblId = 4
                        },
                        new
                        {
                            Id = "4002",
                            Name = "Кам'янське",
                            OblId = 4
                        },
                        new
                        {
                            Id = "5001",
                            KrajId = 9,
                            Name = "Харків",
                            OblId = 5
                        },
                        new
                        {
                            Id = "5002",
                            Name = "Чугуїв",
                            OblId = 5
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Київська"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Львівська"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Одеська"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Дніпропетровська"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Харківська"
                        });
                });

            modelBuilder.Entity("PoshtaApp.Models.Raj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OblId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OblId");

                    b.ToTable("Kraj");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Шевченківський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Оболонський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Франківський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Личаківський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Приморський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Малиновський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 7,
                            Name = "Індустріальний",
                            OblId = 0
                        },
                        new
                        {
                            Id = 8,
                            Name = "Новокодацький",
                            OblId = 0
                        },
                        new
                        {
                            Id = 9,
                            Name = "Київський",
                            OblId = 0
                        },
                        new
                        {
                            Id = 10,
                            Name = "Московський",
                            OblId = 0
                        });
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
                    b.HasOne("PoshtaApp.Models.Raj", "Kraj")
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

            modelBuilder.Entity("PoshtaApp.Models.Raj", b =>
                {
                    b.HasOne("PoshtaApp.Models.Obl", "Obl")
                        .WithMany("Rajs")
                        .HasForeignKey("OblId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obl");
                });

            modelBuilder.Entity("PoshtaApp.Models.Obl", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Rajs");
                });

            modelBuilder.Entity("PoshtaApp.Models.Raj", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
