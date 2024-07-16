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
        private ProductosDAO productosDAO;
        private Productos productos;

        public LogicaProducto()
        {
            productosDAO = new ProductosDAO();
        }

        public bool Insertar(Productos item)
        {
            try
            {
                productosDAO.Insertar(item);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable Listar(Productos item)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = productosDAO.Listar(item);
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
    }
}
