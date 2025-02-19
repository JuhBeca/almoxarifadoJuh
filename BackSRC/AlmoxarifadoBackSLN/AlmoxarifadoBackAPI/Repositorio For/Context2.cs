using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio_For
{
    public class Context2 : DbContext
    {
        public Context2(DbContextOptions<Context2> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Fornecedor>().Property(c => c.Codigo).ValueGeneratedOnAdd();

        }
        public DbSet<Fornecedor> Fornecedor { get; set; }

    }
}
