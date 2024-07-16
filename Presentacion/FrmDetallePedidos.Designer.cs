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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblIdDetPedido = new System.Windows.Forms.Label();
            this.lblCanPedido = new System.Windows.Forms.Label();
            this.lblPrecioPedido = new System.Windows.Forms.Label();
            this.cbxPedido = new System.Windows.Forms.ComboBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.txtIdPedDetalle = new System.Windows.Forms.TextBox();
            this.txtCanPedido = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtgDetPedido = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetPedido)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCanPedido);
            this.groupBox1.Controls.Add(this.txtIdPedDetalle);
            this.groupBox1.Controls.Add(this.cbxProducto);
            this.groupBox1.Controls.Add(this.cbxPedido);
            this.groupBox1.Controls.Add(this.lblPrecioPedido);
            this.groupBox1.Controls.Add(this.lblCanPedido);
            this.groupBox1.Controls.Add(this.lblIdDetPedido);
            this.groupBox1.Controls.Add(this.lblIdProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
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
            // lblCanPedido
            // 
            this.lblCanPedido.AutoSize = true;
            this.lblCanPedido.Location = new System.Drawing.Point(348, 33);
            this.lblCanPedido.Name = "lblCanPedido";
            this.lblCanPedido.Size = new System.Drawing.Size(85, 13);
            this.lblCanPedido.TabIndex = 3;
            this.lblCanPedido.Text = "Cantidad Pedido";
            // 
            // lblPrecioPedido
            // 
            this.lblPrecioPedido.AutoSize = true;
            this.lblPrecioPedido.Location = new System.Drawing.Point(348, 82);
            this.lblPrecioPedido.Name = "lblPrecioPedido";
            this.lblPrecioPedido.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioPedido.TabIndex = 4;
            this.lblPrecioPedido.Text = "Precio a pagar";
            // 
            // cbxPedido
            // 
            this.cbxPedido.FormattingEnabled = true;
            this.cbxPedido.Location = new System.Drawing.Point(123, 74);
            this.cbxPedido.Name = "cbxPedido";
            this.cbxPedido.Size = new System.Drawing.Size(177, 21);
            this.cbxPedido.TabIndex = 5;
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(123, 114);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(177, 21);
            this.cbxProducto.TabIndex = 6;
            // 
            // txtIdPedDetalle
            // 
            this.txtIdPedDetalle.Location = new System.Drawing.Point(123, 30);
            this.txtIdPedDetalle.Name = "txtIdPedDetalle";
            this.txtIdPedDetalle.Size = new System.Drawing.Size(177, 20);
            this.txtIdPedDetalle.TabIndex = 7;
            // 
            // txtCanPedido
            // 
            this.txtCanPedido.Location = new System.Drawing.Point(454, 30);
            this.txtCanPedido.Name = "txtCanPedido";
            this.txtCanPedido.Size = new System.Drawing.Size(160, 20);
            this.txtCanPedido.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(454, 79);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 26);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Detalle Pedidos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(266, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(410, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dtgDetPedido
            // 
            this.dtgDetPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetPedido.Location = new System.Drawing.Point(6, 19);
            this.dtgDetPedido.Name = "dtgDetPedido";
            this.dtgDetPedido.Size = new System.Drawing.Size(764, 130);
            this.dtgDetPedido.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgDetPedido);
            this.groupBox3.Location = new System.Drawing.Point(12, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 159);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(110, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Presentacion.Properties.Resources.eraser_1200;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(566, 10);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // FrmDetallePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDetallePedidos";
            this.Text = "FrmDetallePedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetPedido)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCanPedido;
        private System.Windows.Forms.TextBox txtIdPedDetalle;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.ComboBox cbxPedido;
        private System.Windows.Forms.Label lblPrecioPedido;
        private System.Windows.Forms.Label lblCanPedido;
        private System.Windows.Forms.Label lblIdDetPedido;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dtgDetPedido;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}