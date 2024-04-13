using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Data.Entities
{
    public class Prono
    {
        public int Id { get; set; }

        public string? TypResultat { get; set; }

        public int? DatProno { get; set; }

        public int? DatHMSProno { get; set; }

        public string? Commentaire { get; set; }

        public int JoueurId { get; set; }

        public Joueur Joueur { get; set; } = null!;
       
    }
}
