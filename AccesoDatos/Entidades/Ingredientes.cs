using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Ingredientes
    {
        public int IngId { get; set; }
        public int PrdId{ get; set; }
        public string IngNombre{ get; set; }
        public int IngEstado { get; set; }
    }
}
