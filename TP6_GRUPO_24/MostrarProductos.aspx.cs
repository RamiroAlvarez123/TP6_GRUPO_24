using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
namespace TP6_GRUPO_24
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        GestionProductos gestionProductos = new GestionProductos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tabla"] != null)
            {
                gvProductos.DataSource = (DataTable)Session["tabla"];
                gvProductos.DataBind();
            }
            else
            {
                lblMensaje.Text = "No hay productos seleccionados";  // g.
                lblMensaje.ForeColor = Color.Red;
            }
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
         gvProductos.PageIndex = e.NewPageIndex;  // Evento para paginar la grilla de a 10 filas.
            if (Session["tabla"] != null)
            {
                gvProductos.DataSource = (DataTable)Session["tabla"];
                gvProductos.DataBind();
            }
        }
    }
}