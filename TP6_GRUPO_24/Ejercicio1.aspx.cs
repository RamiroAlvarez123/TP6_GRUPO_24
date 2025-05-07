using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_24
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
            GestionProductos gestionProductos = new GestionProductos();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                cargarGridview();
            }
        }

        private void cargarGridview()
        {
            gvProductos.DataSource = gestionProductos.ObtenerProductos(); //  Carga los datos de productos en el GridView.
            gvProductos.DataBind();
            
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;  // Evento para paginar la grilla de a 10 filas.
            cargarGridview();
        }
    }
}