using Pronostico.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronostico.Objet.Contextes.Utils
{
    public abstract class BaseContextePronostico
    {
        protected readonly PronosticoSaisonContext _context;

        protected BaseContextePronostico()
        {
            _context = new PronosticoSaisonContext();
        }
    }
}
