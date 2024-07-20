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
    public class ClientesDAO
    {

        private Conexion conexion = new Conexion();
        public DataTable List(Clientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllClientes", connection))
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

        public bool Insert(Clientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_InsertCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cli_id", item.CliId);
                    command.Parameters.AddWithValue("@cli_nombre", item.CliNombre);
                    command.Parameters.AddWithValue("@cli_correo", item.CliCorreo);
                    command.Parameters.AddWithValue("@cli_telefono", item.CliTelefono);
                    command.Parameters.AddWithValue("@cli_direccion", item.CliDireccion);
                    command.Parameters.AddWithValue("@cli_estado", item.CliEstado);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Update(Clientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cli_id", item.CliId);
                    command.Parameters.AddWithValue("@cli_nombre", item.CliNombre);
                    command.Parameters.AddWithValue("@cli_correo", item.CliCorreo);
                    command.Parameters.AddWithValue("@cli_telefono", item.CliTelefono);
                    command.Parameters.AddWithValue("@cli_direccion", item.CliDireccion);
                    command.Parameters.AddWithValue("@cli_estado", item.CliEstado);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Delete(Clientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cli_id", item.CliId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
