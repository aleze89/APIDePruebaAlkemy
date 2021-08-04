using MiAPIDeAlkemy.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPIDeAlkemy.Context
{
    public class MiAPIContext : DbContext
    {
        public MiAPIContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Continent> Continents { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<GeographicsIcons> GeographicsIcons { get; set; } = null!;


    }
}
