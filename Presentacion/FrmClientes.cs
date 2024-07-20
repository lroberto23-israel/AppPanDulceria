using AccesoDatos.DAO;
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
    public partial class FrmClientes : Form
    {
        private Clientes currentItem;
        private LogicaClientes logicaClientes;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            logicaClientes= new LogicaClientes();
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliId.Text = "";
            txtCliNombre.Text="";
            txtCliCorreo.Text = "";
            txtCliTelefono.Text = "";
            txtCliDireccion.Text = "";
            chkEstCliente.Checked = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentItem = new Clientes();
            currentItem.CliNombre = txtCliNombre.Text;
            currentItem.CliCorreo = txtCliCorreo.Text;
            currentItem.CliTelefono = txtCliTelefono.Text;
            currentItem.CliDireccion = txtCliDireccion.Text;
            currentItem.CliEstado = chkEstCliente.Checked?1:0;

            if (logicaClientes.Insert(currentItem))
            {
                listar();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listar()
        {
            dtgClientes.DataSource=logicaClientes.List(null);
        }

        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgClientes.SelectedRows.Count > 0)
            {
                //cli_id, cli_nombre, cli_correo, cli_telefono, cli_direccion
                var selectedRow = dtgClientes.SelectedRows[0];
                txtCliId.Text = selectedRow.Cells["cli_id"].Value.ToString();
                txtCliNombre.Text = selectedRow.Cells["cli_nombre"].Value.ToString();
                txtCliCorreo.Text = selectedRow.Cells["cli_correo"].Value.ToString();
                txtCliTelefono.Text = selectedRow.Cells["cli_telefono"].Value.ToString();
                txtCliDireccion.Text = selectedRow.Cells["cli_direccion"].Value.ToString();
                chkEstCliente.Checked = selectedRow.Cells["cli_estado"].Value.ToString() == "1";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            currentItem = new Clientes();
            currentItem.CliId = int.Parse(txtCliId.Text);
            currentItem.CliNombre = txtCliNombre.Text;
            currentItem.CliCorreo = txtCliCorreo.Text;
            currentItem.CliTelefono = txtCliTelefono.Text;
            currentItem.CliDireccion = txtCliDireccion.Text;
            currentItem.CliEstado = chkEstCliente.Checked ? 1 : 0;

            if (logicaClientes.Update(currentItem))
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
            currentItem = new Clientes();
            currentItem.CliId = int.Parse(txtCliId.Text);

            if (logicaClientes.Delete(currentItem))
            {
                listar();
                MessageBox.Show("Eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listar();

        }
    }
}
