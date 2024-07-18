using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Pagos
    {

        public int PagId { get; set; }
        public int PedId { get; set; }
        public DateTime PagFecha { get; set; }
        public DateTime PagMonto { get; set; }
        public DateTime PagMetodo { get; set; }
        public int PagEstado { get; set; }

    }
}
