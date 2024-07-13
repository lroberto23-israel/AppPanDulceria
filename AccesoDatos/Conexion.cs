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
        private SqlConnection connection = new SqlConnection("Data Source=10.0.2.2;Initial Catalog=uisrael;User ID=sa;Password=Clave3123;TrustServerCertificate=True");

        public SqlConnection AbrirConnection()

        {

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;

        }

        public SqlConnection CerrarConnection()

        {

            if (connection.State == System.Data.ConnectionState.Open)

            {

                connection.Close();

            }

            return connection;

        }


    }
}
