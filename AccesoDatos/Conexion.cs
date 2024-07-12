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
        private SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=UISRAEL;Persist Security Info=True;User ID=sa;TrustServerCertificate=True");

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
