namespace Presentacion
{
    partial class FrmDetallePedidos
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
            this.chkEstDetPedido = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblEstDetPedido = new System.Windows.Forms.Label();
            this.txtCanPedido = new System.Windows.Forms.TextBox();
            this.txtIdPedDetalle = new System.Windows.Forms.TextBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.cbxPedido = new System.Windows.Forms.ComboBox();
            this.lblPrecioPedido = new System.Windows.Forms.Label();
            this.lblCanPedido = new System.Windows.Forms.Label();
            this.lblIdDetPedido = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgDetPedido = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetPedido)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstDetPedido);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblEstDetPedido);
            this.groupBox1.Controls.Add(this.txtCanPedido);
            this.groupBox1.Controls.Add(this.txtIdPedDetalle);
            this.groupBox1.Controls.Add(this.cbxProducto);
            this.groupBox1.Controls.Add(this.cbxPedido);
            this.groupBox1.Controls.Add(this.lblPrecioPedido);
            this.groupBox1.Controls.Add(this.lblCanPedido);
            this.groupBox1.Controls.Add(this.lblIdDetPedido);
            this.groupBox1.Controls.Add(this.lblIdProducto);
            this.groupBox1.Controls.Add(this.lblPedido);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkEstDetPedido
            // 
            this.chkEstDetPedido.AutoSize = true;
            this.chkEstDetPedido.Location = new System.Drawing.Point(454, 122);
            this.chkEstDetPedido.Name = "chkEstDetPedido";
            this.chkEstDetPedido.Size = new System.Drawing.Size(15, 14);
            this.chkEstDetPedido.TabIndex = 15;
            this.chkEstDetPedido.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(454, 74);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblEstDetPedido
            // 
            this.lblEstDetPedido.AutoSize = true;
            this.lblEstDetPedido.Location = new System.Drawing.Point(348, 122);
            this.lblEstDetPedido.Name = "lblEstDetPedido";
            this.lblEstDetPedido.Size = new System.Drawing.Size(99, 13);
            this.lblEstDetPedido.TabIndex = 14;
            this.lblEstDetPedido.Text = "Estado Det. Pedido";
            // 
            // txtCanPedido
            // 
            this.txtCanPedido.Location = new System.Drawing.Point(454, 30);
            this.txtCanPedido.Name = "txtCanPedido";
            this.txtCanPedido.Size = new System.Drawing.Size(160, 20);
            this.txtCanPedido.TabIndex = 8;
            // 
            // txtIdPedDetalle
            // 
            this.txtIdPedDetalle.Location = new System.Drawing.Point(123, 30);
            this.txtIdPedDetalle.Name = "txtIdPedDetalle";
            this.txtIdPedDetalle.Size = new System.Drawing.Size(177, 20);
            this.txtIdPedDetalle.TabIndex = 7;
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(123, 114);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(177, 21);
            this.cbxProducto.TabIndex = 6;
            // 
            // cbxPedido
            // 
            this.cbxPedido.FormattingEnabled = true;
            this.cbxPedido.Location = new System.Drawing.Point(123, 74);
            this.cbxPedido.Name = "cbxPedido";
            this.cbxPedido.Size = new System.Drawing.Size(177, 21);
            this.cbxPedido.TabIndex = 5;
            // 
            // lblPrecioPedido
            // 
            this.lblPrecioPedido.AutoSize = true;
            this.lblPrecioPedido.Location = new System.Drawing.Point(348, 77);
            this.lblPrecioPedido.Name = "lblPrecioPedido";
            this.lblPrecioPedido.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioPedido.TabIndex = 4;
            this.lblPrecioPedido.Text = "Precio a pagar";
            // 
            // lblCanPedido
            // 
            this.lblCanPedido.AutoSize = true;
            this.lblCanPedido.Location = new System.Drawing.Point(348, 33);
            this.lblCanPedido.Name = "lblCanPedido";
            this.lblCanPedido.Size = new System.Drawing.Size(85, 13);
            this.lblCanPedido.TabIndex = 3;
            this.lblCanPedido.Text = "Cantidad Pedido";
            // 
            // lblIdDetPedido
            // 
            this.lblIdDetPedido.AutoSize = true;
            this.lblIdDetPedido.Location = new System.Drawing.Point(29, 33);
            this.lblIdDetPedido.Name = "lblIdDetPedido";
            this.lblIdDetPedido.Size = new System.Drawing.Size(88, 13);
            this.lblIdDetPedido.TabIndex = 2;
            this.lblIdDetPedido.Text = "Id Detalle Pedido";
            this.lblIdDetPedido.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(29, 122);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(50, 13);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "Producto";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(29, 77);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(40, 13);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(264, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 26);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Detalle Pedidos";
            // 
            // dtgDetPedido
            // 
            this.dtgDetPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetPedido.Location = new System.Drawing.Point(6, 11);
            this.dtgDetPedido.Name = "dtgDetPedido";
            this.dtgDetPedido.Size = new System.Drawing.Size(655, 146);
            this.dtgDetPedido.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgDetPedido);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 42);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
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
            this.btnModificar.Location = new System.Drawing.Point(313, 13);
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
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.pedido;
            this.pictureBox1.Location = new System.Drawing.Point(226, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 41);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDetallePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDetallePedidos";
            this.Text = "FrmDetallePedidos";
            this.Load += new System.EventHandler(this.FrmDetallePedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetPedido)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCanPedido;
        private System.Windows.Forms.TextBox txtIdPedDetalle;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.ComboBox cbxPedido;
        private System.Windows.Forms.Label lblPrecioPedido;
        private System.Windows.Forms.Label lblCanPedido;
        private System.Windows.Forms.Label lblIdDetPedido;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgDetPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkEstDetPedido;
        private System.Windows.Forms.Label lblEstDetPedido;
    }
}