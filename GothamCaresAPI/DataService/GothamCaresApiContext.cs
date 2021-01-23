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
        }

        public DbSet<Outlet> Outlets { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }
    }
}
