using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio_sai
{
    public class Context4 : DbContext
    {
        public Context4(DbContextOptions<Context4> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Saida>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Saida>().Property(c => c.Codigo).ValueGeneratedOnAdd();

        }
        public DbSet<Saida> Saida { get; set; }

    }
}
