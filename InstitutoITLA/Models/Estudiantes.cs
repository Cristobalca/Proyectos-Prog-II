using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoITLA.Models
{
    public class Estudiantes
    {
        public int EstudiantesID { get; set; }
        [Required(ErrorMessage = "Matricula Requerida")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "Nombre Requerido ")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido Requerido ")]
        public string Apellido { get; set; }
    }
}
