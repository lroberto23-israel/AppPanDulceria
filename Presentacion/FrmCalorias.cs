using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCalorias : Form
    {
        private AccesoDatos.Entidades.Calorias currentItem;
        private LogicaNegocio.LogicaCalorias logicaCalorias;
        public FrmCalorias()
        {
            InitializeComponent();
        }
        private void FrmCalorias_Load(object sender, EventArgs e)
        {
            logicaCalorias = new LogicaNegocio.LogicaCalorias();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            currentItem = new AccesoDatos.Entidades.Calorias();
            currentItem.CalCantidad = float.Parse(txtCantidad.Text);
            logicaCalorias.Insertar(currentItem);
            
        }

    }
}
