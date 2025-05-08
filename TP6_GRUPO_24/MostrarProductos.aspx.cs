using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
        }


    }
}