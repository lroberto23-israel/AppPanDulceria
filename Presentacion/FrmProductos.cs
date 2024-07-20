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
        private LogicaCategorias logicaCategorias;
        public FrmProductos()
        {
            InitializeComponent();
        }


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            logicaProductos = new LogicaProducto();
            logicaCategorias = new LogicaCategorias();
            listar();
            listarCategrias();
        }


        private void listar()
        {
            dtgProductos.DataSource = logicaProductos.List(null);
        }
        private void listarCategrias()
        {
            cbxCategoria.DataSource = logicaCategorias.List(null);
            cbxCategoria.DisplayMember = "cat_nombre";
            cbxCategoria.ValueMember = "cat_id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentItem = new Productos();
            currentItem.PrdNombre = txtPrdNombre.Text;
            currentItem.PrdPrecio = float.Parse(txtPrdPrecio.Text);
            currentItem.PrdDescripcion = txtPrdDescripcion.Text;
            currentItem.CatId = int.Parse(cbxCategoria.SelectedValue.ToString());

            logicaProductos.Insert(currentItem);
            if (logicaProductos.Insert(currentItem))
            {
                listar();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPrdId.Text = "";
            txtPrdNombre.Text = "";
            txtPrdPrecio.Text = "";
            txtPrdDescripcion.Text = "";
            chkEstProducto.Checked = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            currentItem = new Productos();
            currentItem.PrdId = int.Parse(txtPrdId.Text);
            currentItem.PrdNombre = txtPrdNombre.Text;
            currentItem.PrdPrecio = float.Parse(txtPrdPrecio.Text);
            currentItem.PrdDescripcion = txtPrdDescripcion.Text;
            currentItem.CatId = int.Parse(cbxCategoria.SelectedValue.ToString());
            currentItem.PrdEstado=chkEstProducto.Checked? 1:0;

            if (logicaProductos.Update(currentItem))
            {
                listar();
                MessageBox.Show("Actualizacion exitosa");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            currentItem = new Productos();
            currentItem.PrdId = int.Parse(txtPrdId.Text);

            if (logicaProductos.Delete(currentItem))
            {
                listar();
                MessageBox.Show("Eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgProductos.SelectedRows.Count > 0)
            {
                //cli_id, cli_nombre, cli_correo, cli_telefono, cli_direccion
                var selectedRow = dtgProductos.SelectedRows[0];
                txtPrdId.Text = selectedRow.Cells["prd_id"].Value.ToString();
                txtPrdNombre.Text = selectedRow.Cells["prd_nombre"].Value.ToString();
                txtPrdDescripcion.Text = selectedRow.Cells["prd_descripcion"].Value.ToString();
                txtPrdPrecio.Text = selectedRow.Cells["prd_precio"].Value.ToString();
                cbxCategoria.SelectedValue = selectedRow.Cells["cat_id"].Value.ToString();
                chkEstProducto.Checked = selectedRow.Cells["prd_estado"].Value.ToString() == "1";
            }
        }
    }
}
