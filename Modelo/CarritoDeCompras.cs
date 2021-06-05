using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CarritoDeCompras
    {
        public int id { get; set; }
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String imagenURL { get; set; }
        public String marca { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
    }
}
