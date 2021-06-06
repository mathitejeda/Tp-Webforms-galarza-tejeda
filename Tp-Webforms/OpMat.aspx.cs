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
    public partial class OpMat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null || Request.QueryString["op"] == null || Session[Session.SessionID + "carrito"] == null) Response.Redirect("~/");

            List<CarritoDeCompras> carrito = (List<CarritoDeCompras>)Session[Session.SessionID + "carrito"];
            int idItemSelected = Convert.ToInt32(Request.QueryString["id"]);
            String op = Request.QueryString["op"];
            CarritoDeCompras itemListSelected = carrito.Find(J => J.id == idItemSelected);
            if (itemListSelected == null) Response.Redirect("~/");
            CarritoDeComprasNegocio carritoDeComprasNegocio = new CarritoDeComprasNegocio();
            int cantAux = itemListSelected.cantidad;
            int result = cantAux;
            int index = carrito.IndexOf(itemListSelected);

            switch (op)
            {
                case "minus":
                    if (cantAux > 1)
                    {
                        result = cantAux - 1;
                    }
                    else
                    {
                        Response.Redirect("~/Carrito");
                    }
                    break;

                case "plus":
                    result = cantAux + 1;
                    break;

                case "del":
                    carrito.RemoveAt(index);
                    Session[Session.SessionID + "carrito"] = carrito;
                    Response.Redirect("~/Carrito");
                    break;

                default:
                    Response.Redirect("~/");
                    break;
            }

            itemListSelected.cantidad = result;
            carrito[index] = itemListSelected;
            Session[Session.SessionID + "carrito"] = carrito;
            Response.Redirect("~/Carrito");

        }
    }
}