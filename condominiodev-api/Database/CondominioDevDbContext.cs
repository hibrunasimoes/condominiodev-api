using System;
using System.Reflection.Emit;
using condominiodev_api.Database.Mappings;
using condominiodev_api.Model;
using Microsoft.EntityFrameworkCore;

namespace condominiodev_api.Database
{
    public class CondominioDevDbContext : DbContext
    {
        public DbSet<Habitante> Habitantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost;Database=BD_CONDOMINIODEVAPI;User=sa;Password=MyPassword123#;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HabitanteMap());
        }
    }

}

