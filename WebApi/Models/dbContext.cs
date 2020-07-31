using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options): base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-77TGGI49;Initial Catalog=Examen;User ID=erp360;Password=S0p0rt3")
            //    .EnableSensitiveDataLogging(true);
        }

        public DbSet<article> articles { get; set; }
        public DbSet<store> stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<article>();
            modelBuilder.Entity<store>();
        }
    }
    
}
