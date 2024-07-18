
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
    internal class IngredientesDAO
    {

        private Conexion conexion = new Conexion();
        public DataTable List(Ingredientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_List", connection))
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

        public bool Insert(Ingredientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@Name", item.Name);
                    //command.Parameters.AddWithValue("@Age", item.Age);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Update(Ingredientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@Id", item.Id);
                    //command.Parameters.AddWithValue("@Name", item.Name);
                    //command.Parameters.AddWithValue("@Age", item.Age);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Delete(Ingredientes item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@Id", item.Id);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
