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

        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transacction;

        public void Insertar(Clientes item)
        {
            ejecutarSql.Connection = conexion.AbrirConnection();
            try
            {
                string query = string.Format("INSERT INTO tbl_clientes(cli_nombre, cli_correo, cli_telefono, cli_direccion)" +
                    " VALUES ('{0}', '{1}','{2}', '{3}');"
                    , item.CliNombre, item.CliCorreo, item.CliTelefono, item.CliDireccion);

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

        public DataTable Listar(Clientes item)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConnection();
                ejecutarSql.CommandText = "SELECT cli_id, cli_nombre, cli_correo, cli_telefono, cli_direccion FROM tbl_clientes";
                transacction = ejecutarSql.ExecuteReader();
                dt.Load(transacction);
                conexion.CerrarConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo los registros" + ex.Message);

            }
            return dt;
        }
    }
}
