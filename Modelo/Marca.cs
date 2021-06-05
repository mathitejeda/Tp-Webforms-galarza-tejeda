using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Marca
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public Marca(string nombre)
        {

            Nombre = nombre;
        }
        public Marca(int id, string nombre)
        {

            Nombre = nombre;
            ID = id;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
