using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Data.Entities
{
    public class Equipe
    {
        public Equipe()
        {
            
        }

        public Equipe(string nomComplet, string nomCourt, string accronyme, string description, string? imagePath)
        {
            NomComplet = nomComplet;
            NomCourt = nomCourt;
            Accronyme = accronyme;
            Description = description;
            ImagePath = imagePath;
        }

        public int Id { get; set; }

        public string NomComplet { get; set; } = null!;

        public string NomCourt { get; set; } = null!;

        public string Accronyme { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ImagePath { get; set; }


        public void UpdateFrom(Equipe equipe)
        {
            Id = equipe.Id;
            NomComplet = equipe.NomComplet;
            NomCourt = equipe.NomCourt;
            Accronyme = equipe.Accronyme;
            Description = equipe.Description;
            ImagePath = equipe.ImagePath;
        }
    }
}
