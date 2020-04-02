using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.Models
{
    public class Clientes
    {
        public int ClienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string Cedula { get; set; }
        public string Telefono { get; set; }

    }

}
