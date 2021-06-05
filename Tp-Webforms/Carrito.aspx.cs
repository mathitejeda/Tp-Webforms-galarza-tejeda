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
    public partial class Carrito : System.Web.UI.Page
    {   
        public List<CarritoDeCompras> carrito { get; set; }
        public Articulo articulo { get; set; }
        public CarritoDeCompras itemCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Session.SessionID + "carrito"] == null && Request.QueryString["id"] == null) Response.Redirect("~/");

            List<Articulo> itemLista = new List<Articulo>();
            itemLista = (List<Articulo>)Session[Session.SessionID + "itemLista"];
            carrito = (List<CarritoDeCompras>)Session[Session.SessionID + "carrito"];

            CarritoDeComprasNegocio carritoDeComprasNegocio = new CarritoDeComprasNegocio();

            if (Request.QueryString["id"] != null)
            {
                int idSeleccionado = Convert.ToInt32(Request.QueryString["id"]);

                articulo = itemLista.Find(J => J.id == idSeleccionado);
                
                if (carrito == null)
                {
                    carrito = new List<CarritoDeCompras>();
                    carrito.Add(carritoDeComprasNegocio.AgregarItem(articulo));
                    Session[Session.SessionID + "carrito"] = carrito;
                }
                else
                {

                    itemCarrito = carrito.Find(J => J.id == idSeleccionado);
                    if (itemCarrito == null)
                    {
                        carrito.Add(carritoDeComprasNegocio.AgregarItem(articulo));
                        Session[Session.SessionID + "carrito"] = carrito;
                    }
                }
            }

            if (carrito != null)
            {
                decimal total = 0;
                foreach (var item in carrito)
                {
                    decimal aux = item.cantidad * item.precioUnitario;
                    total = total + aux;
                }
                lblTotal.Text = total.ToString();
            }
            else
            {
                Response.Redirect("~/");
            }






           

        }



       






    }
}