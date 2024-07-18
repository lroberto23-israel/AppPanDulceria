﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Pedidos
    {
        public int PedId { get; set; }
        public int CliId { get; set; }
        public DateTime PedFecha { get; set; }
        public DateTime PedHora { get; set; }
        public float PedTotal { get; set; }
        public int PedEstado { get; set; }
    }
}
