using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pronostico.Objet.Contextes;
using Pronostico.Objet.Contextes.Models;



namespace Pronostico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<EquipeModel> Get() 
        {
            return new EquipeContext().GetEquipes();
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            EquipeContext ctx = new();

            EquipeModel? equipe = ctx.GetEquipe(id);
            if (equipe == null)
            { return NotFound(); }
            return new ObjectResult(equipe);
        }

        [HttpPost]
        public IActionResult CreateOrUpdate([FromBody] EquipeModel equipe)
        {
            if(equipe == null)
            {
                return BadRequest();
            }

            new EquipeContext().DbSauver(equipe);
          
            return CreatedAtRoute("GetById", new { id = equipe.Id }, equipe);
        }

    }
}
