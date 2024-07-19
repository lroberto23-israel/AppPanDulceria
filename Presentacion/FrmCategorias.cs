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
            dtgCategorias.DataSource = logicaCategorias.List(null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            currentItem = new Categorias();
            currentItem.CatNombre = txtCatNombre.Text;
            currentItem.CatDescripcion = txtCatDescripcion.Text;

            if (logicaCategorias.Insert(currentItem))
            {
                listar();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtCatId.Text = "";
            txtCatNombre.Text = "";
            txtCatDescripcion.Text = "";
            chkEstProducto.Checked = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            currentItem = new Categorias();
            currentItem.CatId = int.Parse(txtCatId.Text);
            currentItem.CatNombre = txtCatNombre.Text;
            currentItem.CatDescripcion = txtCatDescripcion.Text;
            currentItem.CatEstado = chkEstProducto.Checked?1:0;

            if (logicaCategorias.Update(currentItem))
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
            currentItem = new Categorias();
            currentItem.CatId = int.Parse(txtCatId.Text);

            if (logicaCategorias.Delete(currentItem))
            {
                listar();
                MessageBox.Show("Eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtgCategorias_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgCategorias.SelectedRows.Count > 0)
            {
                //cli_id, cli_nombre, cli_correo, cli_telefono, cli_direccion
                var selectedRow = dtgCategorias.SelectedRows[0];
                txtCatId.Text = selectedRow.Cells["cat_id"].Value.ToString();
                txtCatNombre.Text = selectedRow.Cells["cat_nombre"].Value.ToString();
                txtCatDescripcion.Text = selectedRow.Cells["cat_descripcion"].Value.ToString();
                chkEstProducto.Checked = selectedRow.Cells["cat_estado"].Value.ToString() == "1";
            }
        }
    }
}
