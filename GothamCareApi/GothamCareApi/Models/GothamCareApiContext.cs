using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.Models
{
    public class GothamCareApiContext : DbContext
    {
        public GothamCareApiContext(DbContextOptions<GothamCareApiContext> options) : base(options)
        {

        }

        public DbSet<Outlet> Outlets { get; set; }
    }
}
