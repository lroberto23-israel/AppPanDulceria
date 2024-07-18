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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentItem = new Clientes();
            currentItem.CliNombre = txtCliNombre.Text;
            currentItem.CliCorreo = txtCliCorreo.Text;
            currentItem.CliTelefono = txtCliTelefono.Text;
            currentItem.CliDireccion = txtCliDireccion.Text;

            logicaClientes.Insertar(currentItem);

            listar();

        }

        private void listar()
        {
            dtgClientes.DataSource=logicaClientes.Listar(null);
        }

        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgClientes.SelectedRows.Count > 0)
            {
                //cli_id, cli_nombre, cli_correo, cli_telefono, cli_direccion
                var selectedRow = dtgClientes.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["cli_id"].Value);
                string name = selectedRow.Cells["cli_nombre"].Value.ToString();
                string age = selectedRow.Cells["cli_correo"].Value.ToString();

                // Mostrar los datos seleccionados
                MessageBox.Show($"ID: {id}, Name: {name}, Age: {age}");
            }
        }

        private void txtCliDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
