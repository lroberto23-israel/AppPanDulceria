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
    public partial class FrmMDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }
        private  void abrirCategorias()
        {
            FrmCategorias frmitem = new FrmCategorias();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirClientes()
        {
            FrmClientes frmitem = new FrmClientes();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirCredenciales()
        {
            FrmCredenciales frmitem = new FrmCredenciales();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirDetallePedidos()
        {
            FrmDetallePedidos frmitem = new FrmDetallePedidos();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirIngredientes()
        {
            FrmIngredientes frmitem = new FrmIngredientes();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirNotificaciones()
        {
            FrmNotificaciones frmitem = new FrmNotificaciones();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirPagos()
        {
            FrmPagos frmitem = new FrmPagos();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirPedidos()
        {
            FrmPedidos frmitem = new FrmPedidos();
            frmitem.MdiParent = this;
            frmitem.Show();
        }
        private void abrirProductos()
        {
            FrmProductos frmitem = new FrmProductos();
            frmitem.MdiParent = this;
            frmitem.Show();
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            abrirClientes();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            abrirCategorias();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

              
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirClientes();
        }

        private void ingresoCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirCategorias();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            abrirCredenciales();
        }

        private void credencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirCredenciales();
        }

        private void detallePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirDetallePedidos();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            abrirDetallePedidos();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirNotificaciones();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            abrirNotificaciones();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPagos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            abrirPagos();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirProductos();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            abrirProductos();
        }
    }
}
