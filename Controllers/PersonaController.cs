using ApiMongo.Models;
using ApiMongo.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : Controller
    {
        // private IpersonaCollection db = new PersonaCollection();
        public PersonaCollection db;
         
        public PersonaController(PersonaCollection _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersona()
        {
            return Ok(await db.GetAllPersona());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllPersonaDetails(string id)
        {
            return Ok(await db.GetPersonaById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersona([FromBody] Persona persona)
        {
            if (persona == null)
                return BadRequest();

            await db.InsertPersona(persona);

            return Created("Created", true);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersona([FromBody] Persona persona)
        {
            if (persona == null)
                return BadRequest();
                     
           
            await db.UpdatePersona(persona);

            return Created("Created", true);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona(string id)
        {
            await db.DeletePersona(id);

            return NoContent();
        }
    }
}
