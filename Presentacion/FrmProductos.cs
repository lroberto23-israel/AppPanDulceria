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
    public partial class FrmProductos : Form
    {
        private Productos currentItem;
        private LogicaProducto logicaProductos;
        public FrmProductos()
        {
            InitializeComponent();
        }

       
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            logicaProductos = new LogicaProducto();
            listar();
        }


        private void listar()
        {
            dtgProductos.DataSource = logicaProductos.List(null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentItem = new Productos();
            currentItem.PrdNombre = txtPrdNombre.Text;
            currentItem.PrdPrecio = float.Parse(txtPrdPrecio.Text);
            currentItem.PrdDescripcion = txtPrdDescripcion.Text;
            

            logicaProductos.Insert(currentItem);

            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPrdId.Text = "";
            txtPrdNombre.Text = "";
            txtPrdPrecio.Text = "";
            txtPrdDescripcion.Text = "";
        }
    }
}
