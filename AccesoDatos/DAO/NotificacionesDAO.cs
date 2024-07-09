
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
    internal class NotificacionesDAO
    {
        private Conexion conexion = new Conexion();

        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transacction;

        public void Insertar(Notificaciones item)
        {
            ejecutarSql.Connection = conexion.AbrirConnection();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO uisrael.dbo.tbl_notificaciones (not_id, cli_id, not_mensaje, not_fecha) VALUES(0, 0, '', '')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex.Message);

            }

        }

        public DataTable Listar(Notificaciones item)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConnection();
                ejecutarSql.CommandText = "SELECT not_id, cli_id, not_mensaje, not_fecha FROM uisrael.dbo.tbl_notificaciones";
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
