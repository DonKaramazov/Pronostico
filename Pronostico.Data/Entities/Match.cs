using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Data.Entities
{
    public class Match
    {
        public int Id { get; set; }

        public string? TypResultat { get; set; }

        public int Date { get; set; }

        public int DateHM { get; set; }

        public string? Commentaire { get; set; }

        public int EquipeDomId { get; set; }

        public int EquipeExtId { get; set; }

        [ForeignKey("EquipeDomId")]
        public Equipe EquipeDom { get; set; } = null!;

        [ForeignKey("EquipeExtId")]
        public Equipe EquipeExt { get; set; } = null!;

        public bool IsMatch2Pts { get; set; }

        public ICollection<Match>? Pronos { get; set; }
    }
}
