using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDataBase.Models
{
    public class Clientes
    {
        [Key]
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string domicilio { get; set; }

    
    }
}
