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
    public class LogicaPedido
    {
        private AccesoDatos.DAO.PedidosDAO entityDao;


        public LogicaPedido()
        {
            entityDao = new PedidosDAO();
        }

        public DataTable List(Pedidos item)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = entityDao.List(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dt;

        }


        public bool Insert(Pedidos item)
        {
            try
            {
                return entityDao.Insert(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Update(Pedidos item)
        {
            try
            {
                return entityDao.Update(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public bool Delete(Pedidos item)
        {
            try
            {
                return entityDao.Delete(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
