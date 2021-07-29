using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly clsDbContext _context;
        public PersonaController(clsDbContext context)
        {
            _context = context;
        }

        // GET: api/<PersonaController>
        [HttpGet]
       


        public IEnumerable<Persona> Get( )
        {


            var lst = (from d in _context.Personas
                       from d1 in _context.Sectors
                       from d2 in _context.zonas

                       where d.cod_zona == d2.cod_zona && d.cod_sector== d1.cod_sector 
                       select new Persona 
                       {

                           cod_persona = d.cod_persona,

                           nom_persona = d.nom_persona,

                           fec_nacimiento = d.fec_nacimiento,
                           cod_sector = d.cod_sector,

                           cod_zona = d.cod_zona,

                           Sueldo = d.Sueldo,

                           

                       }).ToList();

            return lst;


        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Persona personapost)
        {

            try
            {
                _context.Add(personapost);
                await _context.SaveChangesAsync();
                return Ok(personapost);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Persona personapost)
        {

            try
            {
                if( id != personapost.cod_persona)
                {
                    return NotFound();
                }

                _context.Update(personapost);
                await _context.SaveChangesAsync();
                return Ok(new { message= "Se actualizo con Exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                var personass = await _context.Personas.FindAsync(id);
                 if (personass==null)
                {
                    return NotFound();
                }
                _context.Personas.Remove(personass);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Se Elimino con Exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
