using Pronostico.Objet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.DAL.RecordSets
{
    public class EquipeRec
    {
        public static IEnumerable<Equipe> LireTout()
        {
            return new PronosticoSaisonContext().Equipes;
        }

        public static Equipe? LireParId(int id) => new PronosticoSaisonContext().Equipes.FirstOrDefault(e => e.Id == id);

        public static void DbSauver(Equipe equipe)
        {
            PronosticoSaisonContext context = new();

            if(equipe?.Id == null)
            {
                // Création
                context.Equipes.Add(equipe);
                context.SaveChanges();
            }
            else
            {
                // Edit
                Equipe? equipeBase = context.Equipes.FirstOrDefault(e => e.Id == equipe.Id);
                equipeBase?.UpdateFrom(equipe);
                context.SaveChanges();
            }
        }
    }
}
