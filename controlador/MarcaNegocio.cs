using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT id,Descripcion from marcas";
                datos.setConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    lista.Add(new Marca((int)datos.Lector["id"], (string)datos.Lector["descripcion"]));
                }
                return lista;

            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

