using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Zona
    {
        [Key]
        [Required]
        public int cod_zona { get; set; }
        [Required]
        public int cod_sector { get; set; }

        [Required]
        public String des_zona { get; set; }
    }
}
