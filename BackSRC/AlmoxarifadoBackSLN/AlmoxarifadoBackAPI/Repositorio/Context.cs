﻿using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(c=>c.Codigo);
            modelBuilder.Entity<Categoria>().Property(c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Produto>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Produto>().Property(c => c.Codigo).ValueGeneratedOnAdd();

            modelBuilder.Entity<Produtos>().HasKey(c => c.Id);
            modelBuilder.Entity<Produtos>().Property(c => c.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Fornecedor>().HasKey(c => c.IdForn);
            modelBuilder.Entity<Fornecedor>().Property(c => c.IdForn).ValueGeneratedOnAdd();

            modelBuilder.Entity<Secretaria>().HasKey(c => c.IdSec);
            modelBuilder.Entity<Secretaria>().Property(c => c.IdSec).ValueGeneratedOnAdd();

            modelBuilder.Entity<Entrada>().HasKey(c => c.IdEnt);
            modelBuilder.Entity<Entrada>().Property(c => c.IdEnt).ValueGeneratedOnAdd();

            modelBuilder.Entity<Saida>().HasKey(c => c.IdSaida);
            modelBuilder.Entity<Saida>().Property(c => c.IdSaida).ValueGeneratedOnAdd();

            modelBuilder.Entity<ItensEntrada>().HasKey(c => c.IdItensEnt);
            modelBuilder.Entity<ItensEntrada>().Property(c => c.IdItensEnt).ValueGeneratedOnAdd();

            modelBuilder.Entity<ItensSaida>().HasKey(c => c.IdItensSaida);
            modelBuilder.Entity<ItensSaida>().Property(c => c.IdItensSaida).ValueGeneratedOnAdd();
        }


        public DbSet<Categoria> Categoria { get; set; }
<<<<<<< HEAD
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Secretaria> Secretaria { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<ItensEntrada> ItensEntrada { get; set; }
        public DbSet<ItensSaida> ItensSaida{ get; set; }
=======
        public DbSet<Produto> Produto { get; set; }
        
>>>>>>> LayoutPadrão
    }
}
