using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp1B.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Filme> filmes;
        public DbSet<Ator> atores;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("Host=pgsql.projetoscti.com.br;Database=projetoscti32;Username=projetoscti32;Password=dbVitin123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>().HasData(new Ator { Id = 1, Nome = "Robert Downey Jr." });
        }
    }
}
