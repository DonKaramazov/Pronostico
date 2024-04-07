using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Models
{
    public class Equipe
    {
        public int Id { get; set; }

        public string Nom { get; set; } = null!;

        public string Accronyme { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ImagePath { get; set; }


        public void UpdateFrom(Equipe equipe)
        {
            Id = equipe.Id;
            Nom = equipe.Nom;
            Accronyme = equipe.Accronyme;
            Description = equipe.Description;
            ImagePath = equipe.ImagePath;
        }
    }
}
