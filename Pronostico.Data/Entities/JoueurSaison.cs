using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Data.Entities
{
    public class JoueurSaison
    {
        public int Id { get; set; }

        public int JoueurId { get; set; }

        public int SaisonId { get; set; }

        public Joueur Joueur { get; set; } = null!;

        public Saison Saison { get; set; } = null!;
    }
}
