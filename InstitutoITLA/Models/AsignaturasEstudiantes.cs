using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InstitutoITLA.Models;

namespace InstitutoITLA.Models
{
    public class AsignaturasEstudiantes
    {
        public int AsignaturasEstudiantesID { get; set; }
        [Required(ErrorMessage = "Estudiante Requerido ")]
        public int EstudiantesID { get; set; }
        [Required(ErrorMessage = "Asignatura Requerido ")]
        public int AsignaturasID { get; set; }
        public virtual Asignaturas Asignaturas { get; set; }
        public virtual Estudiantes Estudiantes { get; set; }
    }
}
