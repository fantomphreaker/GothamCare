using DataService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService
{
    public class GothamCaresApiContext : DbContext
    {
        public GothamCaresApiContext(DbContextOptions<GothamCaresApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Outlet>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Volunteer>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                Email = "abcd@gmail.com",
                Password = "abcd"


            }, new Admin
            {
                Email = "efgh@gmail.com",
                Password = "efgh"

            }, new Admin
            {
                Email = "ijkl@gmail.com",
                Password = "ijkl"
            }
            );

        }

        public DbSet<Outlet> Outlets { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
