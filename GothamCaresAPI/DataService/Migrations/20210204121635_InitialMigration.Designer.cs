﻿// <auto-generated />
using System;
using DataService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataService.Migrations
{
    [DbContext(typeof(GothamCaresApiContext))]
    [Migration("20210204121635_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DataService.Models.Admin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Email = "abcd@gmail.com",
                            Password = "abcd"
                        },
                        new
                        {
                            Email = "efgh@gmail.com",
                            Password = "efgh"
                        },
                        new
                        {
                            Email = "ijkl@gmail.com",
                            Password = "ijkl"
                        });
                });

            modelBuilder.Entity("DataService.Models.Outlet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("FoodType")
                        .HasColumnType("integer");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OutletName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int>("RequiredNoOfVolunteers")
                        .HasColumnType("integer");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalAvailableFoodPackets")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Outlets");
                });

            modelBuilder.Entity("DataService.Models.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("OutletID")
                        .HasColumnType("integer");

                    b.Property<string>("VolunteerAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("VolunteerDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VolunteerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VolunteerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OutletID");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("DataService.Models.Volunteer", b =>
                {
                    b.HasOne("DataService.Models.Outlet", "Outlet")
                        .WithMany()
                        .HasForeignKey("OutletID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Outlet");
                });
#pragma warning restore 612, 618
        }
    }
}
