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
    [Migration("20250403100403_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityId")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("CityName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int?>("OblId")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("OblName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("RajId")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("RajName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OblId");

                    b.HasIndex("RajId");

                    b.ToTable("Aup");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OblId")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int?>("RajId")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OblId");

                    b.HasIndex("RajId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = "00000",
                            Name = "Мар’янівка",
                            OblId = 1101,
                            RajId = 9
                        },
                        new
                        {
                            Id = "00000007",
                            Name = "с. Першотравневе",
                            OblId = 756,
                            RajId = 8
                        },
                        new
                        {
                            Id = "0000002",
                            Name = "с. Кислівка",
                            OblId = 756,
                            RajId = 7
                        },
                        new
                        {
                            Id = "00000021",
                            Name = "с-ще Ягідне",
                            OblId = 1105,
                            RajId = 6
                        },
                        new
                        {
                            Id = "00001",
                            Name = "с. Білозірка",
                            OblId = 1108,
                            RajId = 5
                        },
                        new
                        {
                            Id = "000046",
                            Name = "с. Матроска",
                            OblId = 1108,
                            RajId = 4
                        },
                        new
                        {
                            Id = "00063725",
                            Name = "с. Кучерівка",
                            OblId = 1107,
                            RajId = 3
                        },
                        new
                        {
                            Id = "00007124",
                            Name = "с. Проказине",
                            OblId = 1101,
                            RajId = 2
                        },
                        new
                        {
                            Id = "0008120",
                            Name = "с. Садове",
                            OblId = 1101,
                            RajId = 1
                        },
                        new
                        {
                            Id = "00009322",
                            Name = "с. Петренки",
                            OblId = 1107,
                            RajId = 3
                        },
                        new
                        {
                            Id = "001111",
                            Name = "с. Кудринці",
                            OblId = 1104,
                            RajId = 5
                        },
                        new
                        {
                            Id = "000222222",
                            Name = "с. Рункошів",
                            OblId = 1104,
                            RajId = 5
                        },
                        new
                        {
                            Id = "000222223",
                            Name = "с. Думанів",
                            OblId = 1104,
                            RajId = 5
                        },
                        new
                        {
                            Id = "00063722",
                            Name = "с. Синьківка",
                            OblId = 1105,
                            RajId = 6
                        },
                        new
                        {
                            Id = "00092742",
                            Name = "с. Новоомелькове",
                            OblId = 1107,
                            RajId = 3
                        },
                        new
                        {
                            Id = "00092743",
                            Name = "с. Омелькове",
                            OblId = 1107,
                            RajId = 3
                        },
                        new
                        {
                            Id = "00112233",
                            Name = "м. Яслав",
                            OblId = 1,
                            RajId = 1
                        });
                });

            modelBuilder.Entity("PoshtaApp.Models.Obl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(4)
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
                            Id = 1101,
                            Name = "Київська"
                        },
                        new
                        {
                            Id = 1103,
                            Name = "Чернігівська"
                        },
                        new
                        {
                            Id = 1104,
                            Name = "Сумська"
                        },
                        new
                        {
                            Id = 1105,
                            Name = "Черкаська"
                        },
                        new
                        {
                            Id = 1107,
                            Name = "Полтавська"
                        },
                        new
                        {
                            Id = 1108,
                            Name = "Миколаївська"
                        },
                        new
                        {
                            Id = 1110,
                            Name = "Кіровоградська"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Волинська"
                        },
                        new
                        {
                            Id = 756,
                            Name = "Харківська"
                        },
                        new
                        {
                            Id = 1119,
                            Name = "Херсонська"
                        },
                        new
                        {
                            Id = 1127,
                            Name = "Луганська"
                        });
                });

            modelBuilder.Entity("PoshtaApp.Models.Raj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Rajs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Фастівський"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Білоцерківський"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Полтавський"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Уманський"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Кам’янець-Подільський"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Драбівський"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Дергачівський"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Валківський"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Кагарлицький"
                        });
                });

            modelBuilder.Entity("Aup", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany("Aups")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PoshtaApp.Models.Obl", "Obl")
                        .WithMany()
                        .HasForeignKey("OblId");

                    b.HasOne("PoshtaApp.Models.Raj", "Raj")
                        .WithMany()
                        .HasForeignKey("RajId");

                    b.Navigation("City");

                    b.Navigation("Obl");

                    b.Navigation("Raj");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.HasOne("PoshtaApp.Models.Obl", "Obl")
                        .WithMany("Cities")
                        .HasForeignKey("OblId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PoshtaApp.Models.Raj", "Raj")
                        .WithMany("Cities")
                        .HasForeignKey("RajId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Obl");

                    b.Navigation("Raj");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Navigation("Aups");
                });

            modelBuilder.Entity("PoshtaApp.Models.Obl", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("PoshtaApp.Models.Raj", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
