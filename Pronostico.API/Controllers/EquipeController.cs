using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pronostico.DAL;
using Pronostico.DAL.RecordSets;
using Pronostico.Objet.Models;



namespace Pronostico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Equipe> Get() 
        {
            return EquipeRec.LireTout();
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            Equipe? equipe = EquipeRec.LireParId(id);
            if (equipe == null)
            { return NotFound(); }
            return new ObjectResult(equipe);
        }

        [HttpPost]
        public IActionResult CreateOrUpdate([FromBody] Equipe equipe)
        {
            if(equipe == null)
            {
                return BadRequest();
            }

            EquipeRec.DbSauver(equipe);
          
            return CreatedAtRoute("GetById", new { id = equipe.Id }, equipe);
        }

    }
}
