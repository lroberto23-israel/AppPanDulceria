namespace Presentacion
{
    partial class FrmProductos
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
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtPrdDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrdPrecio = new System.Windows.Forms.TextBox();
            this.txtPrdNombre = new System.Windows.Forms.TextBox();
            this.txtPrdId = new System.Windows.Forms.TextBox();
            this.lblPrdDescripcion = new System.Windows.Forms.Label();
            this.lblPrdPrecio = new System.Windows.Forms.Label();
            this.lblPrdNombre = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstProducto = new System.Windows.Forms.Label();
            this.chkEstProducto = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstProducto);
            this.groupBox1.Controls.Add(this.lblEstProducto);
            this.groupBox1.Controls.Add(this.cbxCategoria);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.txtPrdDescripcion);
            this.groupBox1.Controls.Add(this.txtPrdPrecio);
            this.groupBox1.Controls.Add(this.txtPrdNombre);
            this.groupBox1.Controls.Add(this.txtPrdId);
            this.groupBox1.Controls.Add(this.lblPrdDescripcion);
            this.groupBox1.Controls.Add(this.lblPrdPrecio);
            this.groupBox1.Controls.Add(this.lblPrdNombre);
            this.groupBox1.Controls.Add(this.lblProdId);
            this.groupBox1.Location = new System.Drawing.Point(82, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(105, 50);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(156, 21);
            this.cbxCategoria.TabIndex = 10;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 53);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtPrdDescripcion
            // 
            this.txtPrdDescripcion.Location = new System.Drawing.Point(314, 41);
            this.txtPrdDescripcion.Multiline = true;
            this.txtPrdDescripcion.Name = "txtPrdDescripcion";
            this.txtPrdDescripcion.Size = new System.Drawing.Size(212, 87);
            this.txtPrdDescripcion.TabIndex = 8;
            // 
            // txtPrdPrecio
            // 
            this.txtPrdPrecio.Location = new System.Drawing.Point(105, 119);
            this.txtPrdPrecio.Name = "txtPrdPrecio";
            this.txtPrdPrecio.Size = new System.Drawing.Size(156, 20);
            this.txtPrdPrecio.TabIndex = 7;
            // 
            // txtPrdNombre
            // 
            this.txtPrdNombre.Location = new System.Drawing.Point(105, 86);
            this.txtPrdNombre.Name = "txtPrdNombre";
            this.txtPrdNombre.Size = new System.Drawing.Size(156, 20);
            this.txtPrdNombre.TabIndex = 6;
            // 
            // txtPrdId
            // 
            this.txtPrdId.Enabled = false;
            this.txtPrdId.Location = new System.Drawing.Point(105, 15);
            this.txtPrdId.Name = "txtPrdId";
            this.txtPrdId.Size = new System.Drawing.Size(156, 20);
            this.txtPrdId.TabIndex = 5;
            // 
            // lblPrdDescripcion
            // 
            this.lblPrdDescripcion.AutoSize = true;
            this.lblPrdDescripcion.Location = new System.Drawing.Point(357, 20);
            this.lblPrdDescripcion.Name = "lblPrdDescripcion";
            this.lblPrdDescripcion.Size = new System.Drawing.Size(126, 13);
            this.lblPrdDescripcion.TabIndex = 4;
            this.lblPrdDescripcion.Text = "Descripcion del Producto";
            // 
            // lblPrdPrecio
            // 
            this.lblPrdPrecio.AutoSize = true;
            this.lblPrdPrecio.Location = new System.Drawing.Point(11, 122);
            this.lblPrdPrecio.Name = "lblPrdPrecio";
            this.lblPrdPrecio.Size = new System.Drawing.Size(83, 13);
            this.lblPrdPrecio.TabIndex = 3;
            this.lblPrdPrecio.Text = "Precio Producto";
            // 
            // lblPrdNombre
            // 
            this.lblPrdNombre.AutoSize = true;
            this.lblPrdNombre.Location = new System.Drawing.Point(11, 86);
            this.lblPrdNombre.Name = "lblPrdNombre";
            this.lblPrdNombre.Size = new System.Drawing.Size(90, 13);
            this.lblPrdNombre.TabIndex = 2;
            this.lblPrdNombre.Text = "Nombre Producto";
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Location = new System.Drawing.Point(11, 18);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(65, 13);
            this.lblProdId.TabIndex = 1;
            this.lblProdId.Text = "Id_Producto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(262, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Productos a Ofrecer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgProductos);
            this.groupBox2.Location = new System.Drawing.Point(82, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(6, 13);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(545, 141);
            this.dtgProductos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(82, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 42);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources._32422shortcake_98853;
            this.pictureBox1.Location = new System.Drawing.Point(208, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstProducto
            // 
            this.lblEstProducto.AutoSize = true;
            this.lblEstProducto.Location = new System.Drawing.Point(11, 158);
            this.lblEstProducto.Name = "lblEstProducto";
            this.lblEstProducto.Size = new System.Drawing.Size(86, 13);
            this.lblEstProducto.TabIndex = 11;
            this.lblEstProducto.Text = "Estado Producto";
            // 
            // chkEstProducto
            // 
            this.chkEstProducto.AutoSize = true;
            this.chkEstProducto.Location = new System.Drawing.Point(105, 158);
            this.chkEstProducto.Name = "chkEstProducto";
            this.chkEstProducto.Size = new System.Drawing.Size(15, 14);
            this.chkEstProducto.TabIndex = 12;
            this.chkEstProducto.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrdDescripcion;
        private System.Windows.Forms.TextBox txtPrdPrecio;
        private System.Windows.Forms.TextBox txtPrdNombre;
        private System.Windows.Forms.TextBox txtPrdId;
        private System.Windows.Forms.Label lblPrdDescripcion;
        private System.Windows.Forms.Label lblPrdPrecio;
        private System.Windows.Forms.Label lblPrdNombre;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkEstProducto;
        private System.Windows.Forms.Label lblEstProducto;
    }
}