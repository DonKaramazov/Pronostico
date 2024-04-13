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
    }
}
