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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgPago = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMonPago = new System.Windows.Forms.TextBox();
            this.cbxPedido = new System.Windows.Forms.ComboBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtModPago = new System.Windows.Forms.TextBox();
            this.txtFecPago = new System.Windows.Forms.TextBox();
            this.txtPrdId = new System.Windows.Forms.TextBox();
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.lblMetPago = new System.Windows.Forms.Label();
            this.lblFecPago = new System.Windows.Forms.Label();
            this.lblIdPago = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkEstPago = new System.Windows.Forms.CheckBox();
            this.lblEstPago = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPago)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(122, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 42);
            this.groupBox3.TabIndex = 16;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPago);
            this.groupBox2.Location = new System.Drawing.Point(122, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 160);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // dtgPago
            // 
            this.dtgPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPago.Location = new System.Drawing.Point(6, 13);
            this.dtgPago.Name = "dtgPago";
            this.dtgPago.Size = new System.Drawing.Size(545, 141);
            this.dtgPago.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(302, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 24);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Formas de Pago";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstPago);
            this.groupBox1.Controls.Add(this.lblMonPago);
            this.groupBox1.Controls.Add(this.lblEstPago);
            this.groupBox1.Controls.Add(this.cbxPedido);
            this.groupBox1.Controls.Add(this.lblPedido);
            this.groupBox1.Controls.Add(this.txtModPago);
            this.groupBox1.Controls.Add(this.txtFecPago);
            this.groupBox1.Controls.Add(this.txtPrdId);
            this.groupBox1.Controls.Add(this.lblMontoPago);
            this.groupBox1.Controls.Add(this.lblMetPago);
            this.groupBox1.Controls.Add(this.lblFecPago);
            this.groupBox1.Controls.Add(this.lblIdPago);
            this.groupBox1.Location = new System.Drawing.Point(122, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 181);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblMonPago
            // 
            this.lblMonPago.Location = new System.Drawing.Point(395, 61);
            this.lblMonPago.Name = "lblMonPago";
            this.lblMonPago.Size = new System.Drawing.Size(156, 20);
            this.lblMonPago.TabIndex = 11;
            // 
            // cbxPedido
            // 
            this.cbxPedido.FormattingEnabled = true;
            this.cbxPedido.Location = new System.Drawing.Point(100, 64);
            this.cbxPedido.Name = "cbxPedido";
            this.cbxPedido.Size = new System.Drawing.Size(156, 21);
            this.cbxPedido.TabIndex = 10;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(6, 67);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(40, 13);
            this.lblPedido.TabIndex = 9;
            this.lblPedido.Text = "Pedido";
            // 
            // txtModPago
            // 
            this.txtModPago.Location = new System.Drawing.Point(395, 29);
            this.txtModPago.Name = "txtModPago";
            this.txtModPago.Size = new System.Drawing.Size(156, 20);
            this.txtModPago.TabIndex = 7;
            // 
            // txtFecPago
            // 
            this.txtFecPago.Location = new System.Drawing.Point(100, 100);
            this.txtFecPago.Name = "txtFecPago";
            this.txtFecPago.Size = new System.Drawing.Size(156, 20);
            this.txtFecPago.TabIndex = 6;
            // 
            // txtPrdId
            // 
            this.txtPrdId.Enabled = false;
            this.txtPrdId.Location = new System.Drawing.Point(100, 29);
            this.txtPrdId.Name = "txtPrdId";
            this.txtPrdId.Size = new System.Drawing.Size(156, 20);
            this.txtPrdId.TabIndex = 5;
            // 
            // lblMontoPago
            // 
            this.lblMontoPago.AutoSize = true;
            this.lblMontoPago.Location = new System.Drawing.Point(288, 64);
            this.lblMontoPago.Name = "lblMontoPago";
            this.lblMontoPago.Size = new System.Drawing.Size(85, 13);
            this.lblMontoPago.TabIndex = 4;
            this.lblMontoPago.Text = "Valor a Cancelar";
            // 
            // lblMetPago
            // 
            this.lblMetPago.AutoSize = true;
            this.lblMetPago.Location = new System.Drawing.Point(288, 32);
            this.lblMetPago.Name = "lblMetPago";
            this.lblMetPago.Size = new System.Drawing.Size(77, 13);
            this.lblMetPago.TabIndex = 3;
            this.lblMetPago.Text = "Modo de Pago";
            // 
            // lblFecPago
            // 
            this.lblFecPago.AutoSize = true;
            this.lblFecPago.Location = new System.Drawing.Point(4, 103);
            this.lblFecPago.Name = "lblFecPago";
            this.lblFecPago.Size = new System.Drawing.Size(80, 13);
            this.lblFecPago.TabIndex = 2;
            this.lblFecPago.Text = "Fecha de Pago";
            // 
            // lblIdPago
            // 
            this.lblIdPago.AutoSize = true;
            this.lblIdPago.Location = new System.Drawing.Point(6, 32);
            this.lblIdPago.Name = "lblIdPago";
            this.lblIdPago.Size = new System.Drawing.Size(47, 13);
            this.lblIdPago.TabIndex = 1;
            this.lblIdPago.Text = "Id_Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.shoppaymentorderbuy_04_icon_icons_com_73886;
            this.pictureBox1.Location = new System.Drawing.Point(248, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // chkEstPago
            // 
            this.chkEstPago.AutoSize = true;
            this.chkEstPago.Location = new System.Drawing.Point(382, 107);
            this.chkEstPago.Name = "chkEstPago";
            this.chkEstPago.Size = new System.Drawing.Size(15, 14);
            this.chkEstPago.TabIndex = 19;
            this.chkEstPago.UseVisualStyleBackColor = true;
            // 
            // lblEstPago
            // 
            this.lblEstPago.AutoSize = true;
            this.lblEstPago.Location = new System.Drawing.Point(288, 107);
            this.lblEstPago.Name = "lblEstPago";
            this.lblEstPago.Size = new System.Drawing.Size(68, 13);
            this.lblEstPago.TabIndex = 18;
            this.lblEstPago.Text = "Estado Pago";
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgPago;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtModPago;
        private System.Windows.Forms.TextBox txtFecPago;
        private System.Windows.Forms.TextBox txtPrdId;
        private System.Windows.Forms.Label lblMontoPago;
        private System.Windows.Forms.Label lblMetPago;
        private System.Windows.Forms.Label lblFecPago;
        private System.Windows.Forms.Label lblIdPago;
        private System.Windows.Forms.TextBox lblMonPago;
        private System.Windows.Forms.CheckBox chkEstPago;
        private System.Windows.Forms.Label lblEstPago;
    }
}