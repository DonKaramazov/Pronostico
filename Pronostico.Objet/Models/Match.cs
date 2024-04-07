using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pronostico.Objet.Helpers;

namespace Pronostico.Objet.Models
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
    }
}
