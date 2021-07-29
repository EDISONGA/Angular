using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class MaxTb
    {
        [Key]
        public int cod_persona { get; set; }

      
        public String nom_persona { get; set; }
       
        public String fec_nacimiento { get; set; }


   
        public int cod_sector { get; set; }
   
        public int cod_zona { get; set; }
     
        public float Sueldo { get; set; }
        public String des_zona { get; set; }
        public String des_sector { get; set; }
    }
}
