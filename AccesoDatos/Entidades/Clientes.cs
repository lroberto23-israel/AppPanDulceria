using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Clientes
    {
        public int CliId { get; set; }
        public string CliNombre{ get; set; }
        public string CliCorreo{ get; set; }
        public string CliTelefono{ get; set; }
        public string CliDireccion{ get; set; }
        public int CliEstado { get; set; }
    }
}
