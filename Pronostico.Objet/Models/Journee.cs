using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Models
{
    public class Journee
    {
        public int Id { get; set; }

        public string Nom { get; set; } = null!;

        public string? Commentaire { get; set; }

        public int SaisonId { get; set; }

        public Saison Saison { get; set; } = null!;

        public ICollection<Match> Matchs { get; set; } = null!;
    }
}
