using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Models
{
    public class Saison
    {
        public int Id { get; set; }

        public string Nom { get; set; } = null!;

        public string? Description { get; set; }

        public int DateDebut { get; set; }

        public int DateFin { get; set; }

        public ICollection<JoueurSaison> Joueurs { get; set; } = null!;

        public ICollection<EquipeSaison> Equipes { get; set; } = null!;

        public ICollection<Journee> Calendrier { get; set; } = null!;

    }
}
