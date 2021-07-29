using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxTbController : ControllerBase
    {


        private readonly clsDbContext _context;

        public MaxTbController(clsDbContext context)
        {
            _context = context;
        }

        // GET: api/<MaxTbController>
        [HttpGet]
        public IEnumerable<MaxTb> Get()
        {


            var lst = (from d in _context.Personas
                     
                         from d1 in _context.Sectors
                       from d2 in _context.zonas
                      
                       where d.cod_zona == d2.cod_zona && d.cod_sector == d1.cod_sector
                       orderby  d1.des_sector
                       orderby d2.des_zona
                       
                       select new MaxTb 
                       {

                           cod_persona = d.cod_persona,

                           nom_persona = d.nom_persona,

                           fec_nacimiento = d.fec_nacimiento,
                           cod_sector = d.cod_sector,

                           cod_zona = d.cod_zona,

                           Sueldo = d.Sueldo,
                           des_sector = d1.des_sector,
                           des_zona = d2.des_zona,


                       }).ToList();

            return lst;


        }

        // GET api/<MaxTbController>/5
        [HttpGet("{id}")]
        public IEnumerable<MaxTb> Get(int id)
        {

            var lst = (from d in _context.Personas

                       from d1 in _context.Sectors
                       from d2 in _context.zonas

                       where d.cod_zona == d2.cod_zona && d.cod_sector == d1.cod_sector && d1.cod_sector== id
                       orderby d1.des_sector
                       orderby d2.des_zona

                       select new MaxTb
                       {

                           cod_persona = d.cod_persona,

                           nom_persona = d.nom_persona,

                           fec_nacimiento = d.fec_nacimiento,
                           cod_sector = d.cod_sector,

                           cod_zona = d.cod_zona,

                           Sueldo = d.Sueldo,
                           des_sector = d1.des_sector,
                           des_zona = d2.des_zona,


                       }).ToList();

            return lst;



        }

        // POST api/<MaxTbController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MaxTbController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MaxTbController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
