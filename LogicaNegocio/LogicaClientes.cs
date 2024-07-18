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

        private AccesoDatos.DAO.ClientesDAO entityDao;


        public LogicaClientes()
        {
            entityDao = new ClientesDAO();
        }

        public DataTable List(Clientes item)
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


        public bool Insert(Clientes item)
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

        public bool Update(Clientes item)
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


        public bool Delete(Clientes item)
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
