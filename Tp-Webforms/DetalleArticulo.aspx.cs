using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace presentacionWeb
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            int id = int.Parse(Request.QueryString["id"]);
            List<Articulo> listado = (List<Articulo>)Session["listadoArt"];
            Articulo seleccionado = listado.Find(x => x.id == id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}