using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace TP6_GRUPO_24
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if(Session["tabla"] != null) // g
            {

            Session["tabla"] = null;
            lblMensaje.Text = "Los productos se eliminaron con exito";
            lblMensaje.ForeColor = Color.Green;
            }
            else
            {
                lblMensaje.Text = "No hay productos seleccionados";
                lblMensaje.ForeColor = Color.Red;
            }
          
        }
    }
}