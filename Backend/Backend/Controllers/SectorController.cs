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
    public class SectorController : ControllerBase

    {
        private readonly clsDbContext _context;

        public SectorController(clsDbContext context)
        {
            _context = context;
        }

     
        // GET: api/<SectorController>
        [HttpGet]
        public  IEnumerable<Sector> Get()
        {
            

                var lst = (from d in _context.Sectors

                           select new Sector
                           {

                               cod_sector = d.cod_sector,
                               des_sector = d.des_sector
                           }).ToList();

                return lst;
            
            
        }

        // GET api/<SectorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SectorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SectorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SectorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
