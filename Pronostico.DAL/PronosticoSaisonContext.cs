using Microsoft.EntityFrameworkCore;
using Pronostico.Objet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.DAL
{
    public class PronosticoSaisonContext : DbContext
    {
        public DbSet<Saison> Saisons { get; set; } = null!;

        public DbSet<Joueur> Joueurs { get; set; } = null!;

        public DbSet<Equipe> Equipes { get; set; } = null!;



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO ne pas mettre la chaine de connexion en claire.
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pronostico;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
