using AM.ApllicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AmContext : DbContext

    {
        public DbSet<Flight> flights{get;set ;}
        public DbSet<Passenger> passengers { get; set; }

        public DbSet<Plane> planes { get; set; }
        public DbSet<Staff> staffs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
