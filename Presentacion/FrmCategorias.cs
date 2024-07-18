using AccesoDatos.Entidades;
using LogicaNegocio;
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
    public partial class FrmCategorias : Form
    {
        private Categorias currentItem;
        private LogicaCategorias logicaCategorias;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            logicaCategorias = new LogicaCategorias();
            listar();

        }

        private void listar()
        {
            dtgCategorias.DataSource = logicaCategorias.Listar(null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            currentItem = new Categorias();
            currentItem.CatNombre = txtCatNombre.Text;
            currentItem.CatDescripcion = txtCatDescripcion.Text;

            logicaCategorias.Insertar(currentItem);

            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCatNombre.Text="";
            txtCatDescripcion.Text="";

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
