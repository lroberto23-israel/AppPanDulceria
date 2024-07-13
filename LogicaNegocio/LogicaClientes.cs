using AccesoDatos.DAO;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LogicaClientes
    {
        private ClientesDAO clientesDAO;
        private Clientes clientes;

        public LogicaClientes()
        {
            clientesDAO = new ClientesDAO();
        }

        public bool Insertar(Clientes item)
        {
            try
            {
                clientesDAO.Insertar(item);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable Listar(Clientes item)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = clientesDAO.Listar(item);
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
    }
}
