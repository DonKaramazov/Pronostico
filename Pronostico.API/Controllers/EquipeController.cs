﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pronostico.API.Outils;
using Pronostico.Objet.Contextes;
using Pronostico.Objet.Contextes.Models;



namespace Pronostico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        [HttpGet]
        public ApiResult<IEnumerable<EquipeModel>> Get() 
        {
            return ApiResultFuncHelper.TryEx(() =>
            {
                return new EquipeContext().GetEquipes();
            });
        }

        //[HttpGet("{id}", Name = "GetById")]
        [HttpGet("Get/{idEquipe}")]
        public ApiResult<EquipeModel> GetById(int idEquipe)
        {
            return ApiResultFuncHelper.TryEx(() =>
            {
                EquipeContext ctx = new();

                EquipeModel? equipe = ctx.GetEquipe(idEquipe);
                if (equipe == null)
                    throw new MetierException(Libelles.LIBCOD_NOTFOUND, Libelles.ERRCOD_NOTFOUND);

                return equipe;
            });
        }

        [HttpPost]
        public ApiResult<EquipeModel> CreateOrUpdate([FromBody] EquipeModel equipe)
        {
            return ApiResultFuncHelper.TryEx(() =>
            {
                new EquipeContext().DbSauver(equipe);

                return equipe;
            });
        }

    }
}
