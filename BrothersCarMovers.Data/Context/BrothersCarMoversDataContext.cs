using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BrothersCarMovers.Entities;
using BrothersCarMovers.Data.Extensions;

namespace BrothersCarMovers.Data.Context
{
    public class BrothersCarMoversDataContext : DbContext
    {
        public BrothersCarMoversDataContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleManufacture> VehicleManufactures { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
