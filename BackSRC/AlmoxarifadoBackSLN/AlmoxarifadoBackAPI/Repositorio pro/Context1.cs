using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio_pro
{
    public class Context1 : DbContext
    {
        public Context1(DbContextOptions<Context1> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Produto>().Property(c => c.Codigo).ValueGeneratedOnAdd();

        }
        public DbSet<Produto> Produto { get; set; }

    }
}

