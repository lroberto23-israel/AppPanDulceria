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
    public class LogicaCredenciales
    {
        private AccesoDatos.DAO.CredencialesDAO entityDao;


        public LogicaCredenciales()
        {
            entityDao = new CredencialesDAO();
        }

        public DataTable List(Credenciales item)
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


        public bool Insert(Credenciales item)
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

        public bool Update(Credenciales item)
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


        public bool Delete(Credenciales item)
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
