using System.ComponentModel.DataAnnotations.Schema;

namespace Pronostico.Data.Entities
{
    public class Joueur
    {
        public int Id { get; set; }

        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public string? Surnom { get; set; }

        public string Email { get; set; } = null!;

        public string? AvatarFile { get; set; }

        
        public int? EquipeId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Equipe? EquipeDeCoeur { get; set; }
    }
}
