using InstitutoITLA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoITLA.Models
{
    public class Asignaturas
    {
        public int AsignaturasID { get; set; }
        [Required(ErrorMessage = "Nombre Requerido ")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Tipo Requerido ")]
        public string TipoDeAsignatura { get; set; }
        public virtual ICollection<AsignaturasMaestros> AsignaturasMaestros { get; set; }
        public virtual ICollection<AsignaturasEstudiantes> AsignaturasEstudiantes { get; set; }
    }
}
