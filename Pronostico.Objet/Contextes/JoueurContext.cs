using Pronostico.Data.Entities;
using Pronostico.Objet.Contextes.Models;
using Pronostico.Objet.Contextes.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Contextes
{
    public class JoueurContext : BaseContextePronostico
    {
        public JoueurContext() : base() { }

        public IEnumerable<JoueurModel> GetJoueurs()
        {
            return _context.Joueurs.Select(j => new JoueurModel(j));
        }

        public JoueurModel? GetJoueur(int id)
        {
            return (from j in _context.Joueurs
                    where j.Id == id
                    select new JoueurModel(j)
                    ).FirstOrDefault();
        }

        public void DbSauver(JoueurModel joueurModel)
        {
            
            if(joueurModel?.Id == 0)
            {
                Joueur joueur = JoueurModel.ObjFromModel(new Joueur(), joueurModel);
                _context.Joueurs.Add(joueur);
                _context.SaveChanges();
                joueurModel.Id = joueur.Id;
            }
            else
            {
                Joueur? joueurBase = _context.Joueurs.FirstOrDefault(j => j.Id == joueurModel.Id);

                if(joueurBase != null)
                {
                    joueurBase = JoueurModel.ObjFromModel(joueurBase, joueurModel);
                    _context.SaveChanges();
                }
            }
        }
    }
}
