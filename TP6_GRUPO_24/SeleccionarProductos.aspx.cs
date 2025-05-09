using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace TP6_GRUPO_24
{
    public partial class SeleccionarProductos : System.Web.UI.Page
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

        protected void gvProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            string nombre = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string cantidadPorUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_CantidadPorUnidad")).Text;
            string precioPorUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnidad")).Text;


            Producto producto = new Producto(Convert.ToInt32(idProducto), nombre, cantidadPorUnidad, Convert.ToDecimal(precioPorUnidad));
            

            if (Session["tabla"] == null)
            {

                Session["tabla"] = crearTabla();
            }

            DataTable tabla = (DataTable)Session["tabla"];
            bool productoRepetido = false;
            foreach(DataRow row in tabla.Rows) // Evitar repeticiones de productos.
            {
                if(row["IdProducto"].ToString() == producto.IdProducto.ToString())
                {
                    productoRepetido = true;
                    break;
                }
            }
            
            if (!productoRepetido) {  // g.
            lblProducto.Text = "Producto agregado: " + nombre;
            lblProducto.ForeColor = System.Drawing.Color.Green;
            agregarFila((DataTable)Session["tabla"], producto);
            }
            else
            {
                lblProducto.Text = "El producto ya ha sido agregado.";
                lblProducto.ForeColor = System.Drawing.Color.Red;
            }
        }

        private DataTable crearTabla()
        {
            DataTable datatable = new DataTable();
            DataColumn dataColumn = new DataColumn("IdProducto", System.Type.GetType("System.String"));
            datatable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            datatable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("CantidadPorUnidad", System.Type.GetType("System.String"));
            datatable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            datatable.Columns.Add(dataColumn);

            return datatable;

        }

        private DataTable agregarFila(DataTable dataTable, Producto producto)
        {
            DataRow datarow = dataTable.NewRow();
            datarow["IdProducto"] = producto.IdProducto;
            datarow["NombreProducto"] = producto.NombreProducto;
            datarow["CantidadPorUnidad"] = producto.CantidadPorUnidad;
            datarow["PrecioUnidad"] = producto.PrecioUnidad;
            dataTable.Rows.Add(datarow);

            return dataTable;
        }

        protected void gvProductos_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;  // Evento para paginar la grilla de a 10 filas.
            cargarGridview();
        }
    }
}