using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Data.Entities
{
    public class EquipeSaison
    {
        public int Id { get; set; }

        public int EquipeId { get; set; }

        public int SaisonId { get; set; }

        public Equipe Equipe { get; set; } = null!;

        public Saison Saison { get; set; } = null!;
    }
}
