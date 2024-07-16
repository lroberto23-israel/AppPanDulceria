using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Productos
    {
        public int PrdId { get; set; }
        public string PrdNombre { get; set; }
        public string PrdDescripcion { get; set; }
        public float PrdPrecio { get; set; }
        public int CatId { get; set; }
    }
}
