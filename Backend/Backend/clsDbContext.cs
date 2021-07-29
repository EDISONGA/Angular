using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class clsDbContext : DbContext
    {
        public  DbSet<Persona> Personas { get; set; }


        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Zona> zonas { get; set; }
       


        public clsDbContext(DbContextOptions<clsDbContext> options): base(options)
        {

        }
    }
}
