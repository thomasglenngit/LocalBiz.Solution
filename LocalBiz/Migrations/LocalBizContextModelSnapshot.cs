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
                });
#pragma warning restore 612, 618
        }
    }
}