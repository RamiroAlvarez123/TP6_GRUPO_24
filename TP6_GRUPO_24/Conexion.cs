using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace TP6_GRUPO_24
{
    public class Conexion
    {       
        //private const string connectionString = @"Data Source=DESKTOP-9AUAVE3\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        private const string connectionString = @"Data Source=MOSTRADOR-PC\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        //private const string connectionString = @"Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno; Integrated Security = True";
        public SqlConnection ObtenerConexion()  // Metodo simple para obtener la conexion a SQL.
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }

        // Para obtener las tablas que vamos a usar, pasamos como parametros un string para consultaSQL y otro para nombre d ela tabla.
        public DataTable ObtenerTablas(string consultaSQL, string nombreTabla)
        {
            try
            {

            using (SqlConnection conn = this.ObtenerConexion())  
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaSQL, conn); // Usar DataAdapter + DataSet para cargas simples.
                DataSet dataTable = new DataSet();
                sqlDataAdapter.Fill(dataTable, nombreTabla);
                return dataTable.Tables[nombreTabla];
            }
            }
            catch (Exception ex)
            {
                return null;  
            }
        }

        public int EjecutarConsulta(SqlCommand comando, string consultaSQL)
        {
            int result;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand = comando;
            sqlCommand.Connection = Conexion;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = consultaSQL;
            result = sqlCommand.ExecuteNonQuery();
            Conexion.Close();

            return result;

        }

    }
}