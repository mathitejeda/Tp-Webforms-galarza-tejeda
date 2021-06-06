using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class CarritoDeComprasNegocio
    {
        public CarritoDeCompras AgregarItem(Articulo item)
        {
            try
            {
            CarritoDeCompras resultado = new CarritoDeCompras();
            resultado.id = item.id;
            resultado.codigo = item.codigo;
            resultado.nombre = item.nombre;
            resultado.imagenURL = item.imagenUrl;
            resultado.marca = Convert.ToString(item.marca);
            resultado.cantidad = 1;
            resultado.precioUnitario = Convert.ToDecimal(item.precio);
            return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
