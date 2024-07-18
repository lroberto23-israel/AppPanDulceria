using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Notificaciones
    {

        public int NotId { get; set; }
        public int CliId { get; set; }
        public string NotMensaje { get; set; }
        public DateTime NotFecha { get; set; }
        public int NotEstado { get; set; }
    }
}
