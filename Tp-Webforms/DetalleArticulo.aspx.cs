using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;

namespace presentacionWeb
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idSeleccionado = Convert.ToInt32(Request.QueryString["id"]);

            ArticuloNegocio dao = new ArticuloNegocio();
            Articulo articulo = dao.Detalle(idSeleccionado);
            lblNombreArticulo.Text = articulo.nombre;
            imgImagenArticulo.ImageUrl = articulo.imagenUrl; 
            lblPrecioArticulo.Text = Convert.ToString(articulo.precio);
            lblDescripcion.Text = articulo.descripcion;
        }
    }
}