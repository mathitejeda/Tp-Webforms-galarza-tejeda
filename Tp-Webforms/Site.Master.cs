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
    public partial class SiteMaster : MasterPage
    {
        public List<CarritoDeCompras> carrito { get; set; }

        ArticuloNegocio articuloNegocio = new ArticuloNegocio();

        List<Articulo> itemLista = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "TP WebForm Galarza Tejera ";

            if (!IsPostBack)
            {
                itemLista = articuloNegocio.Listar();                
                Session[Session.SessionID + "itemLista"] = itemLista;
            }

            carrito = (List<CarritoDeCompras>)Session[Session.SessionID + "carrito"];

            int cantidad;

            if (carrito == null)
            {
                cantidad = 0;
            }
            else
            {
                cantidad = carrito.Count();
            }
            lblCantidad.Text = "(" + cantidad + ")";
        }
    }
}