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
    public partial class FrmCredenciales : Form
    {
        private LogicaClientes logicaClientes = new LogicaClientes();
        private LogicaCredenciales logicaCredenciales = new LogicaCredenciales();
        private Credenciales currentItem;
        public FrmCredenciales()
        {
            InitializeComponent();
        }
        private void listarClientes()
        {
            cbxListarClientes.DataSource = logicaClientes.List(null);
            cbxListarClientes.DisplayMember = "cli_nombre"; 
            cbxListarClientes.ValueMember = "cli_id";

        }
        private void listar()
        {
            dtgCredenciales.DataSource = logicaCredenciales.List(null);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtCreId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCredenciales_Load(object sender, EventArgs e)
        {
            listarClientes();
            listar();
        }

        private void dtgCredenciales_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCredenciales.SelectedRows.Count > 0)
            {
                //cli_id, cli_nombre, cli_correo, cli_telefono, cli_direccion
                var selectedRow = dtgCredenciales.SelectedRows[0];
                txtCreId.Text = selectedRow.Cells["cre_id"].Value.ToString();
                txtCreClave .Text = selectedRow.Cells["cre_clave"].Value.ToString();
                chkEstCredencial.Checked = selectedRow.Cells["cre_estado"].Value.ToString() == "1";
                cbxListarClientes.SelectedValue = int.Parse(cbxListarClientes.SelectedValue.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentItem = new Credenciales();
            
            currentItem.CliId = int.Parse(cbxListarClientes.SelectedValue.ToString());
            currentItem.CreClave = txtCreClave.Text;
            
            if (logicaCredenciales.Insert(currentItem))
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
            txtCreId.Text = "";
            txtCreClave.Text = "";
            chkEstCredencial.Checked = true;
                       
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            currentItem = new Credenciales();
            currentItem.CliId = int.Parse(cbxListarClientes.SelectedValue.ToString());
            currentItem.CreClave = txtCreClave.Text;
            currentItem.CreEstado= chkEstCredencial.Checked ? 1 : 0;

            if (logicaCredenciales.Update(currentItem))
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
            currentItem = new Credenciales();
            currentItem.CreId = int.Parse(txtCreId.Text);

            if (logicaCredenciales.Delete(currentItem))
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
