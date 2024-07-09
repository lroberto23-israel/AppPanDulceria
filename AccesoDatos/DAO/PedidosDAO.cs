
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
    internal class PedidosDAO
    {
        private Conexion conexion = new Conexion();

        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transacction;

        public void Insertar(Pedidos item)
        {
            ejecutarSql.Connection = conexion.AbrirConnection();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO uisrael.dbo.tbl_pedidos (ped_id, cli_id, ped_fecha, ped_hora, ped_estado, ped_total) VALUES(0, 0, '', '', '', 0)";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex.Message);

            }

        }

        public DataTable Listar(Pedidos item)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConnection();
                ejecutarSql.CommandText = "SELECT ped_id, cli_id, ped_fecha, ped_hora, ped_estado, ped_total FROM uisrael.dbo.tbl_pedidos";
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
