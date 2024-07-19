using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    internal class Conexion
    {
        private string connectionString = "Data Source=10.0.2.2;Initial Catalog=UISRAEL;User ID=sa;Password=Clave3123;TrustServerCertificate=True";
        public SqlConnection AbrirConnection()
        {
            //if (connection.State == System.Data.ConnectionState.Closed)
            //{
            //    connection.Open();
            //}

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }

        //public SqlConnection CerrarConnection()

        //{

        //    if (connection.State == System.Data.ConnectionState.Open)

        //    {

        //        connection.Close();

        //    }

        //    return connection;

        //}


    }
}
