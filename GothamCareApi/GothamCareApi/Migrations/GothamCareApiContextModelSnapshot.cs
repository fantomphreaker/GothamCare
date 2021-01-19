﻿// <auto-generated />
using System;
using GothamCareApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GothamCareApi.Migrations
{
    [DbContext(typeof(GothamCareApiContext))]
    partial class GothamCareApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GothamCareApi.Models.Admin", b =>
                {
                    b.Property<string>("EmailId")
                        .HasColumnType("text");

                    b.Property<string>("AdminName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("EmailId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GothamCareApi.Models.Outlet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FoodType")
                        .HasColumnType("text");

                    b.Property<string>("Landmark")
                        .HasColumnType("text");

                    b.Property<string>("OutletName")
                        .HasColumnType("text");

                    b.Property<int>("RequiredNoOfVolunteers")
                        .HasColumnType("integer");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.Property<int>("TotalAvailableFoodPackets")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Outlets");
                });

            modelBuilder.Entity("GothamCareApi.Models.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("OutletID")
                        .HasColumnType("integer");

                    b.Property<string>("VolunteerAddress")
                        .HasColumnType("text");

                    b.Property<DateTime>("VolunteerDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VolunteerName")
                        .HasColumnType("text");

                    b.Property<string>("VolunteerPhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Volunteers");
                });
#pragma warning restore 612, 618
        }
    }
}
