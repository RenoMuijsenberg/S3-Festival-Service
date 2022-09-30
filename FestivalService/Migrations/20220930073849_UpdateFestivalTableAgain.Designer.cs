﻿// <auto-generated />
using System;
using FestivalService.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FestivalService.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220930073849_UpdateFestivalTableAgain")]
    partial class UpdateFestivalTableAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FestivalService.Models.FestivalModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FestivalAge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FestivalDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FestivalDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FestivalLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FestivalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FestivalPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FestivalTimeFrame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Festivals");
                });
#pragma warning restore 612, 618
        }
    }
}
