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
    public class LogicaCalorias
    {
        private AccesoDatos.DAO.CaloriasDAO caloriasDao;

        public LogicaCalorias()
        {
            caloriasDao = new CaloriasDAO();
        }

        public bool Insertar(Calorias item)
        {
            try
            {
                caloriasDao.Insertar(item);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable Listar(Calorias item)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = caloriasDao.Listar(item);
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
    }
}
