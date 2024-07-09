using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    internal class DetallePedidos
    {
        public int DpeId { get; set; }
        public int PedId { get; set; }
        public int PrdId { get; set; }
        public float DpeCantidad { get; set; }
        public float DpePrecio { get; set; }
    }
}
