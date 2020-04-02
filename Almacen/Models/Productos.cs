using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.Models
{
    public class Productos
    {
        public int ProductoID { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Double Precio { get; set; }

    }
}
