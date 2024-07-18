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
    public class LogicaCategorias
    {

        private AccesoDatos.DAO.CategoriasDAO entityDao;

        public LogicaCategorias()
        {
            entityDao = new CategoriasDAO();
        }

        public DataTable List(Categorias item)
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


        public bool Insert(Categorias item)
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

        public bool Update(Categorias item)
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


        public bool Delete(Categorias item)
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
