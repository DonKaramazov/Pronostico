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
    public class EquipeContext : BaseContextePronostico
    {
        public EquipeContext() : base() { }

        public IEnumerable<EquipeModel> GetEquipes()
        {
            return _context.Equipes.Select(e => new EquipeModel()
            {
                Id = e.Id,
                NomComplet = e.NomComplet,
                NomCourt = e.NomCourt,
                Accronyme = e.NomCourt,
                Description = e.Description,
                ImagePath = e.ImagePath
            });
        }

        // On s'amuse avec les différentes manières d'écrire les requetes
        public EquipeModel? GetEquipe(int id)
        {
            return (from e in _context.Equipes
                    where e.Id == id
                    select new EquipeModel
                    {
                        Id = e.Id,
                        NomComplet = e.NomComplet,
                        NomCourt = e.NomCourt,
                        Accronyme = e.NomCourt,
                        Description = e.Description,
                        ImagePath = e.ImagePath
                    }).FirstOrDefault();
        }

        public void DbSauver(EquipeModel equipeModel)
        {
            Equipe equipe = new()
            {
                Id = equipeModel.Id,
                NomComplet = equipeModel.NomComplet,
                NomCourt = equipeModel.NomCourt,
                Description = equipeModel.Description,
                ImagePath = equipeModel.ImagePath,
                Accronyme = equipeModel.Accronyme,
            };

            if(equipeModel?.Id == 0)
            {
                _context.Equipes.Add(equipe);
                _context.SaveChanges();
                equipeModel.Id = equipe.Id;
            }
            else
            {
                Equipe? equipeBase = _context.Equipes.FirstOrDefault(e => e.Id == equipeModel.Id);

                if(equipeBase != null)
                {
                    equipeBase.NomComplet = equipe.NomComplet;
                    equipeBase.NomCourt = equipe.NomCourt;
                    equipeBase.Description = equipe.Description;
                    equipeBase.ImagePath = equipe.ImagePath;
                    equipeBase.Accronyme = equipe.Accronyme;

                    _context.SaveChanges();
                }
            }
        }
    }
}
