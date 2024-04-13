using Microsoft.EntityFrameworkCore;
using Pronostico.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Data
{
    public class PronosticoSaisonContext : DbContext
    {
        public DbSet<Saison> Saisons { get; set; } = null!;

        public DbSet<Joueur> Joueurs { get; set; } = null!;

        public DbSet<Equipe> Equipes { get; set; } = null!;

        public DbSet<Match> Matchs { get; set; } = null!;

        public PronosticoSaisonContext()
        {
            
        }

        // public PronosticoSaisonContext(DbContextOptions<PronosticoSaisonContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Joueur>().Property(j => j.EquipeId).ValueGeneratedNever();  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO ne pas mettre la chaine de connexion en claire.
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pronostico;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
