using InstitutoITLA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoITLA.Models
{
    public class Profesores
    {
       public int ProfesoresID { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido Requerido ")]
        public string Apellido { get; set; }
        public virtual ICollection<AsignaturasMaestros> AsignaturasMaestros { get; set; }
    }
}
