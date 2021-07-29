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
    public class ZonaController : ControllerBase
    {


        private readonly clsDbContext _context;

        public ZonaController(clsDbContext context)
        {
            _context = context;
        }

        // GET: api/<ZonaController>
        [HttpGet]

        public IEnumerable<Zona> Get(int idsector)
        {


            var lst = (from d in _context.zonas

                       where d.cod_sector == idsector
                       select new Zona
                       {
                           cod_zona = d.cod_zona,
                           cod_sector = d.cod_sector,
                           des_zona = d.des_zona
                       }).ToList();

            return lst;


        }


        // GET api/<ZonaController>/5
        [HttpGet("{id}")]
        public string Get()
        {
            return "value";
        }

        // POST api/<ZonaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ZonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ZonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
