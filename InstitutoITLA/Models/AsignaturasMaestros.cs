using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoITLA.Models
{
    public class AsignaturasMaestros
    {
        public int AsignaturasMaestrosID { get; set; }
        [Required(ErrorMessage = "Asignaturas Requerido ")]
        public int AsignaturasID { get; set; }
        public virtual Asignaturas Asignaturas { get; set; }
        [Required(ErrorMessage = "Maestro  Requerido ")]
        public int ProfesoresID { get; set; }
        public virtual Profesores Profesores { get; set; }
    }
}
