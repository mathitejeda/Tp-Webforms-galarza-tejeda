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
        public int idSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            idSeleccionado = Convert.ToInt32(Request.QueryString["id"]);

            ArticuloNegocio dao = new ArticuloNegocio();
            Articulo articulo = dao.Detalle(idSeleccionado);
            lblNombreArticulo.Text = articulo.nombre;
            imgImagenArticulo.ImageUrl = articulo.imagenUrl; 
            lblPrecioArticulo.Text = Convert.ToString(articulo.precio);
            lblDescripcion.Text = articulo.descripcion;
            //tbId.Text = idSeleccionado.ToString();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //string url = "~/Carrito.aspx?id=" + idSeleccionado;
            Response.Redirect("~/Carrito.aspx?id="+idSeleccionado);
        }
    }
}