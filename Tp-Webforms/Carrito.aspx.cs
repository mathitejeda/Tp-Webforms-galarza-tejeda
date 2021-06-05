using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace presentacionWeb
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Articulo> carrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (List<Articulo>)Session["listaCarrito"];
            if (carrito == null)
                carrito = new List<Articulo>();
            if (!IsPostBack)
            {
                if(Request.QueryString["id"] != null)
                {
                    if(carrito.Find(x=> x.id.ToString() == Request.QueryString["id"]) == null)
                    {
                        List<Articulo> original = (List < Articulo>) Session["listadoArt"];
                        carrito.Add(original.Find(x => x.id.ToString() == Request.QueryString["id"]));
                    }
                }
            }
            Session.Add("listaCarrito", carrito);

        }
    }
}