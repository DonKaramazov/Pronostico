using Pronostico.Data;
using Pronostico.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Contextes.Models
{
    public class JoueurModel
    {
        public int Id { get; set; }
        public int? EquipeId { get; set; }

        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public string? Surnom { get; set; }

        public string Email { get; set; } = null!;

        public string? AvatarFile { get; set; }

        public JoueurModel(){}

        public JoueurModel(Joueur obj)
        {
            Id = obj.Id;
            Nom = obj.Nom;
            Prenom = obj.Prenom;
            Surnom = obj.Surnom;
            Email = obj.Email;
            AvatarFile = obj.AvatarFile;
            EquipeId = obj.EquipeId;
        }

        public static Joueur ObjFromModel(Joueur obj,JoueurModel model)
        {

            obj.Id = model.Id;
            obj.Nom = model.Nom;
            obj.Prenom = model.Prenom;
            obj.Surnom = model.Surnom;
            obj.Email = model.Email;
            obj.AvatarFile = model.AvatarFile;
            obj.EquipeId = model.EquipeId;

            //Je commente cette ligne pour le moment, elle cause une exeception à la sauvegarde 
            // Cannot insert explicit value for identity column on ...
            //obj.EquipeDeCoeur = new PronosticoSaisonContext().Equipes.FirstOrDefault(e => e.Id == model.EquipeId); //TODO penser à un cache à l'avenir

            return obj;
        }
    }
}
