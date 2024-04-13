using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pronostico.API.Outils;
using Pronostico.Objet.Contextes;
using Pronostico.Objet.Contextes.Models;

namespace Pronostico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JoueurController : Controller
    {
        [HttpGet]
        public ApiResult<IEnumerable<JoueurModel>> Get()
        {
            return ApiResultFuncHelper.TryEx(() =>
            {
                return new JoueurContext().GetJoueurs();
            });
        }

        //[HttpGet("{id}", Name = "GetById")]
        [HttpGet("Get/{idJoueur}")]
        public ApiResult<JoueurModel> GetById(int idJoueur)
        {
            return ApiResultFuncHelper.TryEx(() =>
            {
                JoueurContext ctx = new();

                JoueurModel? joueur = ctx.GetJoueur(idJoueur);
                if (joueur == null)
                    throw new MetierException(Libelles.LIBCOD_NOTFOUND, Libelles.ERRCOD_NOTFOUND);

                return joueur;
            });
        }

        [HttpPost]
        public ApiResult<JoueurModel> CreateOrUpdate([FromBody] JoueurModel joueur)
        {
            return ApiResultFuncHelper.TryEx(() =>
            {
                new JoueurContext().DbSauver(joueur);

                return joueur;
            });
        }
    }
}
