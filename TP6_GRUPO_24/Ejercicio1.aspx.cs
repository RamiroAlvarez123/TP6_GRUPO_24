using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

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

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text;
            Producto producto = new Producto(Convert.ToInt32(idProducto));

            GestionProductos gestionProductos = new GestionProductos();

            int result = gestionProductos.EliminarProducto(producto);
            if (result > 0)
            {
                lblResult.ForeColor = System.Drawing.Color.Green;
                lblResult.Text = "el producto se ah eliminado con exito";
                cargarGridview();
            }
            else {
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = "ocurrio un error al eliminar el producto";
            }
            
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e) // g.
        {
            gvProductos.EditIndex = e.NewEditIndex;
            cargarGridview();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e) // g.
        {
            gvProductos.EditIndex = -1;
            cargarGridview();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e) // g.
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_idProducto")).Text;
            string nombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_nombreProducto")).Text;
            string cantidadPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_cantidadPorUnidad")).Text;
            string precioUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_precioUnidad")).Text;

            Producto producto = new Producto(Convert.ToInt32(idProducto), nombreProducto, cantidadPorUnidad, Convert.ToDecimal(precioUnidad));
            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.ActualizarProducto(producto);
            gvProductos.EditIndex = -1;
            cargarGridview();
        }
    }
}