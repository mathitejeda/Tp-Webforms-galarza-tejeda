using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Modelo;

namespace Tp_Webforms
{
    public partial class _Default : Page
    {
        public List<Articulo> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.listar2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}