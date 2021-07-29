using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Sector
    {
        [Key]
        [Required]
        public int cod_sector { get; set; }

        [Required]
        public String des_sector { get; set; }
       

    }
}
