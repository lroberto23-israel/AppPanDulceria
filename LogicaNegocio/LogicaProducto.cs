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
    public class LogicaProducto
    {

        private AccesoDatos.DAO.ProductosDAO entityDao;


        public LogicaProducto()
        {
            entityDao = new ProductosDAO();
        }

        public DataTable List(Productos item)
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


        public bool Insert(Productos item)
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

        public bool Update(Productos item)
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


        public bool Delete(Productos item)
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
