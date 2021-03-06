﻿// <auto-generated />
using LocalBiz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBiz.Migrations
{
    [DbContext(typeof(LocalBizContext))]
    partial class LocalBizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBiz.Models.Biz", b =>
                {
                    b.Property<int>("BizId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("BizId");

                    b.ToTable("Bizs");

                    b.HasData(
                        new
                        {
                            BizId = 1,
                            Address = "405 - 3 Wacker Drive, Chicago, IL",
                            Name = "Great Lakes Bank",
                            Type = "Financial - Bank",
                            Url = "info@glbanking.com"
                        },
                        new
                        {
                            BizId = 3,
                            Address = "#4334 Williams Street, Chicago, IL",
                            Name = "Tip Top Tailor",
                            Type = "Dry Cleaning/Tailor",
                            Url = "charlie@tiptop.com"
                        },
                        new
                        {
                            BizId = 5,
                            Address = "#253 Jackson Avenue, Chicago, IL",
                            Name = "Euro Cars",
                            Type = "Auto Mechanic",
                            Url = "info@eurocars.com"
                        },
                        new
                        {
                            BizId = 7,
                            Address = "#478 Cander Avenue, Chicago, IL",
                            Name = "Trip and Slide",
                            Type = "Recreational - Roller Rink",
                            Url = "info@tripandslide.com"
                        },
                        new
                        {
                            BizId = 9,
                            Address = "#4446 - 305 Jackson Avenue, Chicago, IL",
                            Name = "Tax Grind",
                            Type = "Financial - Tax Preparation",
                            Url = "info@taxgrind.com"
                        },
                        new
                        {
                            BizId = 11,
                            Address = "#334 Bellevue Circle, Chicago, IL",
                            Name = "Crank and Chain",
                            Type = "Transportation - Bicycle Repair",
                            Url = "info@crankandchain.com"
                        });
                });

            modelBuilder.Entity("LocalBiz.Models.Resto", b =>
                {
                    b.Property<int>("RestoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RAddress");

                    b.Property<string>("RName");

                    b.Property<string>("RType");

                    b.Property<string>("RUrl");

                    b.HasKey("RestoId");

                    b.ToTable("Restos");

                    b.HasData(
                        new
                        {
                            RestoId = 2,
                            RAddress = "#1 Happy Street, Chicago, IL",
                            RName = "Wok With Me",
                            RType = "Restaurant - Chinese",
                            RUrl = "info@wokwithme.com"
                        },
                        new
                        {
                            RestoId = 4,
                            RAddress = "#455 Michigan Avenue, Chicago, IL",
                            RName = "Panera",
                            RType = "Restaurant - American",
                            RUrl = "info@panera.com"
                        },
                        new
                        {
                            RestoId = 6,
                            RAddress = "#3446 - 55 N. Wacker Drive, Chicago, IL",
                            RName = "Pretzel Choke",
                            RType = "Restaurant - German",
                            RUrl = "info@pretzelchoke.com"
                        },
                        new
                        {
                            RestoId = 8,
                            RAddress = "#3 Anderson Road, Chicago, IL",
                            RName = "Green Tongue",
                            RType = "Restaurant - Health Food",
                            RUrl = "info@greentongue.com"
                        },
                        new
                        {
                            RestoId = 10,
                            RAddress = "#5001 Andretti Blvd, Chicago, IL",
                            RName = "Bowl of Carb",
                            RType = "Restaurant - Italian",
                            RUrl = "eatme@carbitup.com"
                        },
                        new
                        {
                            RestoId = 12,
                            RAddress = "#4003 - 3 N. Michigan Avenue, Chicago, IL",
                            RName = "Pho Q",
                            RType = "Restaurant - Vietnamese",
                            RUrl = "info@phoq.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
