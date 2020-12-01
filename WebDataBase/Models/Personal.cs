using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDataBase.Models
{
    public class Personal
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Nombres (s)")]
        public string nombres { get; set; }

        [Display(Name = "Apellidos (s)")]
        public string apellidos { get; set; }

        [Display(Name = "Lugar donde habita")]
        [MinLength(5, ErrorMessage ="Esta campo requiere al menos 5 caracteres.")]
        public string domicilio { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? fechaNacimiento { get; set; }


        [Display(Name = "Nombre y apellidos del empleado")]
        public string nombreCompleto
        {
            get
            {
                return nombres + " " + apellidos;
            }
        }
    
    }
}
