using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Persona
    {

        [Key]
        [Required]
        public int cod_persona { get; set;}

        [Required]
        public String nom_persona { get; set; }
        [Required]
        public String fec_nacimiento { get; set; }


        [Required]
        public int cod_sector { get; set; }
        [Required]
        public int cod_zona { get; set; }
        [Required]
        public float Sueldo { get; set; }
      


    }
}
