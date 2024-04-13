using Pronostico.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Contextes.Models
{
    public class EquipeModel
    {
        public int Id { get; set; }
        public string NomComplet { get; set; } = null!;
        public string NomCourt { get; set; } = null!;
        public string Accronyme { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ImagePath { get; set; }

        public EquipeModel() {}

        public static EquipeModel ModelFromObj(Equipe obj)
        {
            return new EquipeModel()
            {
                Id = obj.Id,
                NomComplet = obj.NomComplet,
                NomCourt = obj.NomCourt,
                Accronyme = obj.Accronyme,
                Description = obj.Description,
                ImagePath = obj.ImagePath,
            };
        }

        public static Equipe ObjToModel(EquipeModel model)
        {
            return new Equipe()
            {
                Id = model.Id,
                NomComplet = model.NomComplet,
                NomCourt = model.NomCourt,
                Accronyme = model.Accronyme,
                Description = model.Description,
                ImagePath = model.ImagePath,
            };
        }
    }
}
