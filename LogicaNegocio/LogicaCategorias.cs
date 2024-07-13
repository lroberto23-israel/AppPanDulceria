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

        private CategoriasDAO categoriasDAO;

        public LogicaCategorias()
        {
            categoriasDAO = new CategoriasDAO();
        }

        public bool Insertar(Categorias item)
        {
            try
            {
                categoriasDAO.Insertar(item);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable Listar(Categorias item)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = categoriasDAO.Listar(item);
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
    }
}
