using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Categorias
    {
        public int        CatId { get; set; }
        public string CatNombre { get; set; }
        public string CatDescripcion { get; set; }

        public int CatEstado { get; set; }
    }
}
