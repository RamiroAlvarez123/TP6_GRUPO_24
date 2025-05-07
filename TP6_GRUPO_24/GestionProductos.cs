using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_24
{
    // Similar a la clase ConsultasSQL del tp anterior, esta clase se encargara de ejecutar las consultas SQL.
    public class GestionProductos
    {
        Conexion conexion = new Conexion();

        public DataTable ObtenerProductos()
        {
            string consultaSQL = "SELECT P.IdProducto, P.NombreProducto, P.CantidadPorUnidad, P.PrecioUnidad From Productos P";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        private void ParametrosEliminar(ref SqlCommand comando, Producto producto)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = comando.Parameters.Add("@idProducto", SqlDbType.Int);
            sqlParameter.Value = producto.IdProducto;
        }
        public int EliminarProducto(Producto producto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ParametrosEliminar(ref sqlCommand, producto);
            Conexion conexion = new Conexion();
            string consultaSQL = "DELETE FROM Productos WHERE idProducto = @idProducto";
            int filas = conexion.EjecutarConsulta(sqlCommand, consultaSQL);
            return filas;
        }
    }
}