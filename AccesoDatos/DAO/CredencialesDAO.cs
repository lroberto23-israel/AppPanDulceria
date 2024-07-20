using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DAO
{
    public class CredencialesDAO
    {

        private Conexion conexion = new Conexion();
        public DataTable List(Credenciales item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllCredenciales", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros si es necesario
                    // command.Parameters.AddWithValue("@Param", item.Property);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public bool Insert(Credenciales item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_InsertCredencial", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@cre_id", item.CreId);
                    command.Parameters.AddWithValue("@cli_id", item.CliId);
                    command.Parameters.AddWithValue("@cre_clave", item.CreClave);
                    //command.Parameters.AddWithValue("@cre_estado", item.CreEstado);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Update(Credenciales item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateCredencial", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cre_id", item.CreId);
                    command.Parameters.AddWithValue("@cli_id", item.CliId);
                    command.Parameters.AddWithValue("@cre_clave", item.CreClave);
                    command.Parameters.AddWithValue("@cre_estado", item.CreEstado);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Delete(Credenciales item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteCredencial", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cre_id", item.CreId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
