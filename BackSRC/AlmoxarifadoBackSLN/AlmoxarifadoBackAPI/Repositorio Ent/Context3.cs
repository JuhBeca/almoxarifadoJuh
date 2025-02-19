using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio_Ent
{
    public class Context3 : DbContext
    {
        public Context3(DbContextOptions<Context3> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entrada>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Entrada>().Property(c => c.Codigo).ValueGeneratedOnAdd();

        }
        public DbSet<Entrada> Entrada { get; set; }

    }
}
