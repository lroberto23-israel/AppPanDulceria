namespace Presentacion
{
    partial class FrmPagos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgPagos = new System.Windows.Forms.DataGridView();
            this.lblIdPago = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.lblPagoMetodo = new System.Windows.Forms.Label();
            this.txtIpago = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.txtPagoMetodo = new System.Windows.Forms.TextBox();
            this.cbxIdPedido = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxIdPedido);
            this.groupBox1.Controls.Add(this.txtPagoMetodo);
            this.groupBox1.Controls.Add(this.txtMontoPago);
            this.groupBox1.Controls.Add(this.txtFechaPago);
            this.groupBox1.Controls.Add(this.txtIpago);
            this.groupBox1.Controls.Add(this.lblPagoMetodo);
            this.groupBox1.Controls.Add(this.lblMontoPago);
            this.groupBox1.Controls.Add(this.lblFechaPago);
            this.groupBox1.Controls.Add(this.lblIdPedido);
            this.groupBox1.Controls.Add(this.lblIdPago);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 43);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgPagos);
            this.groupBox3.Location = new System.Drawing.Point(12, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 144);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dtgPagos
            // 
            this.dtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagos.Location = new System.Drawing.Point(6, 11);
            this.dtgPagos.Name = "dtgPagos";
            this.dtgPagos.Size = new System.Drawing.Size(764, 127);
            this.dtgPagos.TabIndex = 0;
            // 
            // lblIdPago
            // 
            this.lblIdPago.AutoSize = true;
            this.lblIdPago.Location = new System.Drawing.Point(53, 37);
            this.lblIdPago.Name = "lblIdPago";
            this.lblIdPago.Size = new System.Drawing.Size(44, 13);
            this.lblIdPago.TabIndex = 0;
            this.lblIdPago.Text = "Id Pago";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(53, 93);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(40, 13);
            this.lblIdPedido.TabIndex = 1;
            this.lblIdPedido.Text = "Pedido";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(337, 37);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(65, 13);
            this.lblFechaPago.TabIndex = 2;
            this.lblFechaPago.Text = "Fecha Pago";
            // 
            // lblMontoPago
            // 
            this.lblMontoPago.AutoSize = true;
            this.lblMontoPago.Location = new System.Drawing.Point(337, 93);
            this.lblMontoPago.Name = "lblMontoPago";
            this.lblMontoPago.Size = new System.Drawing.Size(85, 13);
            this.lblMontoPago.TabIndex = 3;
            this.lblMontoPago.Text = "Total a Cancelar";
            // 
            // lblPagoMetodo
            // 
            this.lblPagoMetodo.AutoSize = true;
            this.lblPagoMetodo.Location = new System.Drawing.Point(337, 149);
            this.lblPagoMetodo.Name = "lblPagoMetodo";
            this.lblPagoMetodo.Size = new System.Drawing.Size(86, 13);
            this.lblPagoMetodo.TabIndex = 4;
            this.lblPagoMetodo.Text = "Método de Pago";
            // 
            // txtIpago
            // 
            this.txtIpago.Location = new System.Drawing.Point(139, 34);
            this.txtIpago.Name = "txtIpago";
            this.txtIpago.Size = new System.Drawing.Size(121, 20);
            this.txtIpago.TabIndex = 5;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(468, 34);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPago.TabIndex = 6;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(468, 90);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPago.TabIndex = 7;
            // 
            // txtPagoMetodo
            // 
            this.txtPagoMetodo.Location = new System.Drawing.Point(468, 146);
            this.txtPagoMetodo.Name = "txtPagoMetodo";
            this.txtPagoMetodo.Size = new System.Drawing.Size(100, 20);
            this.txtPagoMetodo.TabIndex = 8;
            // 
            // cbxIdPedido
            // 
            this.cbxIdPedido.FormattingEnabled = true;
            this.cbxIdPedido.Location = new System.Drawing.Point(139, 90);
            this.cbxIdPedido.Name = "cbxIdPedido";
            this.cbxIdPedido.Size = new System.Drawing.Size(121, 21);
            this.cbxIdPedido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pagos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.borrar1;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(537, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Presentacion.Properties.Resources.archivo_de_edicion;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(392, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.agregar_documento;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(243, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(79, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgPagos;
        private System.Windows.Forms.Label lblPagoMetodo;
        private System.Windows.Forms.Label lblMontoPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label lblIdPago;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxIdPedido;
        private System.Windows.Forms.TextBox txtPagoMetodo;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtIpago;
        private System.Windows.Forms.Label label6;
    }
}