using BrothersCarMovers.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity => { entity.Property(e => e.Title).IsRequired(); });
            modelBuilder.Entity<Role>().HasData(
                new Role
                { Id=1, Title = "Driver", Description = "Driver" , CreateDateTime= DateTime.Now},
                 new Role
                 { Id = 2, Title = "Client", Description = "Client", CreateDateTime = DateTime.Now },
                   new Role
                   { Id = 3, Title = "Admin", Description = "Admin", CreateDateTime = DateTime.Now },
                      new Role
                      { Id = 4, Title = "Manager", Description = "Manager", CreateDateTime = DateTime.Now });
        }
    }
}
