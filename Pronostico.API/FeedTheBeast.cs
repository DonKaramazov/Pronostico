using Pronostico.DAL;
using Pronostico.Objet.Models;

namespace Pronostico.API
{
    public class FeedTheBeast
    {

        public static void Seed()
        {
            PronosticoSaisonContext context = new PronosticoSaisonContext();

            Equipe monaco = new Equipe()
            {
                Nom = "AS Monaco",
                Accronyme = "ASM",
                Description = "Le club de la principauté",                       
            };

            context.Equipes.Add(monaco);
            context.SaveChanges();
        }
    }
}
