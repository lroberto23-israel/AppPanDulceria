using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DAO
{
    internal class CategoriasDAO
    {
        private Conexion conexion = new Conexion();

        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transacction;

        public void Insertar(Categorias item)
        {
            ejecutarSql.Connection = conexion.AbrirConnection();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO uisrael.dbo.tbl_categorias ( cat_nombre, cat_descripcion) VALUES( '"+item.CatNombre+"', '"+item.CatDescripcion+"');";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConnection();
            }
            catch (Exception ex) {
                throw new Exception("Error ingresando la categoria " + ex.Message);
            
            }

        }

        public DataTable Listar(Categorias item) {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConnection();
                ejecutarSql.CommandText = "SELECT cat_id, cat_nombre, cat_descripcion FROM uisrael.dbo.tbl_categorias";
                transacction=  ejecutarSql.ExecuteReader();
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
