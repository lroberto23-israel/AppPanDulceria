namespace Presentacion
{
    partial class FrmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCatDescripcion = new System.Windows.Forms.TextBox();
            this.txtCatNombre = new System.Windows.Forms.TextBox();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.lblCatDescripcion = new System.Windows.Forms.Label();
            this.lblCatNombre = new System.Windows.Forms.Label();
            this.lblCatId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEstProducto = new System.Windows.Forms.CheckBox();
            this.lblEstCategoria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstProducto);
            this.groupBox1.Controls.Add(this.txtCatDescripcion);
            this.groupBox1.Controls.Add(this.lblEstCategoria);
            this.groupBox1.Controls.Add(this.txtCatNombre);
            this.groupBox1.Controls.Add(this.txtCatId);
            this.groupBox1.Controls.Add(this.lblCatDescripcion);
            this.groupBox1.Controls.Add(this.lblCatNombre);
            this.groupBox1.Controls.Add(this.lblCatId);
            this.groupBox1.Location = new System.Drawing.Point(70, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCatDescripcion
            // 
            this.txtCatDescripcion.Location = new System.Drawing.Point(435, 12);
            this.txtCatDescripcion.Multiline = true;
            this.txtCatDescripcion.Name = "txtCatDescripcion";
            this.txtCatDescripcion.Size = new System.Drawing.Size(178, 20);
            this.txtCatDescripcion.TabIndex = 5;
            // 
            // txtCatNombre
            // 
            this.txtCatNombre.Location = new System.Drawing.Point(142, 58);
            this.txtCatNombre.Name = "txtCatNombre";
            this.txtCatNombre.Size = new System.Drawing.Size(134, 20);
            this.txtCatNombre.TabIndex = 4;
            // 
            // txtCatId
            // 
            this.txtCatId.Enabled = false;
            this.txtCatId.Location = new System.Drawing.Point(142, 12);
            this.txtCatId.Multiline = true;
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(134, 20);
            this.txtCatId.TabIndex = 3;
            // 
            // lblCatDescripcion
            // 
            this.lblCatDescripcion.AutoSize = true;
            this.lblCatDescripcion.Location = new System.Drawing.Point(322, 19);
            this.lblCatDescripcion.Name = "lblCatDescripcion";
            this.lblCatDescripcion.Size = new System.Drawing.Size(94, 13);
            this.lblCatDescripcion.TabIndex = 2;
            this.lblCatDescripcion.Text = "Breve Descripcion";
            // 
            // lblCatNombre
            // 
            this.lblCatNombre.AutoSize = true;
            this.lblCatNombre.Location = new System.Drawing.Point(17, 61);
            this.lblCatNombre.Name = "lblCatNombre";
            this.lblCatNombre.Size = new System.Drawing.Size(92, 13);
            this.lblCatNombre.TabIndex = 1;
            this.lblCatNombre.Text = "Nombre Categoria";
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.Location = new System.Drawing.Point(17, 19);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(64, 13);
            this.lblCatId.TabIndex = 0;
            this.lblCatId.Text = "Id Categoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCategorias);
            this.groupBox2.Location = new System.Drawing.Point(70, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Location = new System.Drawing.Point(6, 15);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.Size = new System.Drawing.Size(649, 170);
            this.dtgCategorias.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(343, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CATEGORIAS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(70, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 42);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // chkEstProducto
            // 
            this.chkEstProducto.AutoSize = true;
            this.chkEstProducto.Location = new System.Drawing.Point(435, 60);
            this.chkEstProducto.Name = "chkEstProducto";
            this.chkEstProducto.Size = new System.Drawing.Size(15, 14);
            this.chkEstProducto.TabIndex = 14;
            this.chkEstProducto.UseVisualStyleBackColor = true;
            // 
            // lblEstCategoria
            // 
            this.lblEstCategoria.AutoSize = true;
            this.lblEstCategoria.Location = new System.Drawing.Point(322, 61);
            this.lblEstCategoria.Name = "lblEstCategoria";
            this.lblEstCategoria.Size = new System.Drawing.Size(93, 13);
            this.lblEstCategoria.TabIndex = 13;
            this.lblEstCategoria.Text = "Estado Categorias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.panaderia;
            this.pictureBox1.Location = new System.Drawing.Point(273, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.borrar1;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(426, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Presentacion.Properties.Resources.archivo_de_edicion;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(309, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.agregar_documento;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(203, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(89, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCatDescripcion;
        private System.Windows.Forms.Label lblCatNombre;
        private System.Windows.Forms.Label lblCatId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.TextBox txtCatDescripcion;
        private System.Windows.Forms.TextBox txtCatNombre;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkEstProducto;
        private System.Windows.Forms.Label lblEstCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}