using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{

    public class ArticuloNegocio
    {

        public List<Articulo> Listar()

        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = CATALOGO_DB;integrated security = sspi;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, M.Descripcion , C.Descripcion, A.id, M.id, C.id, A.Precio " +
                    "from ARTICULOS as A " +
                    "Inner Join Marcas as M on A.IdMarca = M.Id " +
                    "Inner Join CATEGORIAS as C on A.IdCategoria = C.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = lector.GetString(0);

                    aux.nombre = lector.GetString(1);

                    aux.descripcion = lector.GetString(2);

                    aux.imagenUrl = lector.GetString(3);

                    aux.marca = new Marca(lector.GetString(4));

                    aux.categoria = new Categoria(lector.GetString(5));

                    aux.id = lector.GetInt32(6);

                    aux.idMarca = lector.GetInt32(7);

                    aux.idCategoria = lector.GetInt32(8);

                    aux.precio = lector.GetDecimal(9);


                    lista.Add(aux);
                }
                conexion.Close();
                return lista;

            }
            catch (Exception ex2)
            {

                throw ex2;
            }



        }

        public List<Articulo> listar2()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, M.Descripcion , C.Descripcion,A.precio, A.Id " +
                    "from ARTICULOS as A " +
                    "Inner Join Marcas as M on A.IdMarca = M.Id " +
                    "Inner Join CATEGORIAS as C on A.IdCategoria = C.Id";
                datos.setConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = datos.Lector.GetString(0);
                    aux.nombre = datos.Lector.GetString(1);
                    aux.descripcion = datos.Lector.GetString(2);
                    aux.imagenUrl = datos.Lector.GetString(3);
                    aux.marca = new Marca(datos.Lector.GetString(4));
                    aux.categoria = new Categoria(datos.Lector.GetString(5));
                    aux.precio = datos.Lector.GetDecimal(6);
                    aux.id = datos.Lector.GetInt32(7);

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("update Articulos set Nombre = @nombre, Descripcion = @descripcion, imagenUrl = @urlImagen, Codigo = @codigo, idmarca = @idmarca, idcategoria=@idcategoria, precio=@precio Where Id = @id");
                datos.setParametro("@nombre", articulo.nombre);
                datos.setParametro("@descripcion", articulo.descripcion);
                datos.setParametro("@urlImagen", articulo.imagenUrl);
                datos.setParametro("@codigo", articulo.codigo);
                datos.setParametro("@idmarca", articulo.idMarca);
                datos.setParametro("@idcategoria", articulo.idCategoria);
                datos.setParametro("@id", articulo.id);
                datos.setParametro("@precio", articulo.precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "insert into ARTICULOS values('" + nuevo.codigo + "','" + nuevo.nombre + "','" + nuevo.descripcion + "'," + nuevo.marca.ID + "," + nuevo.categoria.ID + ",'" + nuevo.imagenUrl + "'," + nuevo.precio + ")";
                datos.setConsulta(consulta);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Delete From Articulos Where Id= " + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }

    }

}

