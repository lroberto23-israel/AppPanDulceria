
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
    public class ProductosDAO
    {

        private Conexion conexion = new Conexion();
        public DataTable List(Productos item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllProductos", connection))
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

        public bool Insert(Productos item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_InsertProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prd_nombre", item.PrdNombre);
                    command.Parameters.AddWithValue("@prd_descripcion", item.PrdDescripcion);
                    command.Parameters.AddWithValue("@prd_precio", item.PrdPrecio);
                    command.Parameters.AddWithValue("@cat_id", item.CatId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Update(Productos item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prd_id", item.PrdId);
                    command.Parameters.AddWithValue("@prd_nombre", item.PrdNombre);
                    command.Parameters.AddWithValue("@prd_descripcion", item.PrdDescripcion);
                    command.Parameters.AddWithValue("@prd_precio", item.PrdPrecio);
                    command.Parameters.AddWithValue("@cat_id", item.CatId);
                    command.Parameters.AddWithValue("@prd_estado", item.PrdEstado);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Delete(Productos item)
        {
            using (SqlConnection connection = conexion.AbrirConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prd_id", item.PrdId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
