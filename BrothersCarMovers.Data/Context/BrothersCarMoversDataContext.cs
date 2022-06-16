using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BrothersCarMovers.Entities;

namespace BrothersCarMovers.Data.Context
{
    public class BrothersCarMoversDataContext : DbContext
    {
        public BrothersCarMoversDataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<VehicleManufacture> VehicleManufactures { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
