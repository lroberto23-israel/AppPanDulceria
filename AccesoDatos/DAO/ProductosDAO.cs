
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

        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transacction;

        public void Insertar(Productos item)
        {
            ejecutarSql.Connection = conexion.AbrirConnection();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO tbl_productos (prd_nombre, prd_descripcion, prd_precio, cat_id) VALUES('', '', 0, 0)";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConnection();
                string query = string.Format("INSERT INTO tbl_productos (prd_nombre, prd_descripcion, prd_precio, cat_id)" +
                   " VALUES ('{0}', '{1}',{2}, {3},);"
                   , item.PrdNombre, item.PrdDescripcion, item.PrdPrecio, item.CatId);

                Console.WriteLine(query);
                ejecutarSql.CommandText = query;
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex.Message);

            }

        }

        public DataTable Listar(Productos item)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConnection();
                ejecutarSql.CommandText = "SELECT prd_id, prd_nombre, prd_descripcion, prd_precio, cat_id FROM tbl_productos";
                transacction = ejecutarSql.ExecuteReader();
                dt.Load(transacction);
                conexion.CerrarConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo los registros " + ex.Message);

            }
            return dt;
        }
    }
}
