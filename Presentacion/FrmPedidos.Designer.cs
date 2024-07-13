namespace Presentacion
{
    partial class FrmPedidos
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
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.lblPedId = new System.Windows.Forms.Label();
            this.lblPedFecha = new System.Windows.Forms.Label();
            this.lblPedHora = new System.Windows.Forms.Label();
            this.lblEstPedido = new System.Windows.Forms.Label();
            this.lblPedTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPedId = new System.Windows.Forms.TextBox();
            this.txtPedFecha = new System.Windows.Forms.TextBox();
            this.txtPedHora = new System.Windows.Forms.TextBox();
            this.txtPedEstado = new System.Windows.Forms.TextBox();
            this.txtPedTotal = new System.Windows.Forms.TextBox();
            this.lstListarClientes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.Location = new System.Drawing.Point(6, 16);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.Size = new System.Drawing.Size(44, 13);
            this.lblListarClientes.TabIndex = 0;
            this.lblListarClientes.Text = "Clientes";
            this.lblListarClientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPedId
            // 
            this.lblPedId.AutoSize = true;
            this.lblPedId.Location = new System.Drawing.Point(200, 47);
            this.lblPedId.Name = "lblPedId";
            this.lblPedId.Size = new System.Drawing.Size(57, 13);
            this.lblPedId.TabIndex = 1;
            this.lblPedId.Text = "Id Pedidos";
            // 
            // lblPedFecha
            // 
            this.lblPedFecha.AutoSize = true;
            this.lblPedFecha.Location = new System.Drawing.Point(200, 92);
            this.lblPedFecha.Name = "lblPedFecha";
            this.lblPedFecha.Size = new System.Drawing.Size(73, 13);
            this.lblPedFecha.TabIndex = 2;
            this.lblPedFecha.Text = "Fecha Pedido";
            this.lblPedFecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPedHora
            // 
            this.lblPedHora.AutoSize = true;
            this.lblPedHora.Location = new System.Drawing.Point(200, 136);
            this.lblPedHora.Name = "lblPedHora";
            this.lblPedHora.Size = new System.Drawing.Size(66, 13);
            this.lblPedHora.TabIndex = 3;
            this.lblPedHora.Text = "Hora Pedido";
            this.lblPedHora.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEstPedido
            // 
            this.lblEstPedido.AutoSize = true;
            this.lblEstPedido.Location = new System.Drawing.Point(408, 47);
            this.lblEstPedido.Name = "lblEstPedido";
            this.lblEstPedido.Size = new System.Drawing.Size(93, 13);
            this.lblEstPedido.TabIndex = 4;
            this.lblEstPedido.Text = "Estado del Pedido";
            // 
            // lblPedTotal
            // 
            this.lblPedTotal.AutoSize = true;
            this.lblPedTotal.Location = new System.Drawing.Point(408, 92);
            this.lblPedTotal.Name = "lblPedTotal";
            this.lblPedTotal.Size = new System.Drawing.Size(82, 13);
            this.lblPedTotal.TabIndex = 5;
            this.lblPedTotal.Text = "Total de Pedido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pedidos Realizados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListarClientes);
            this.groupBox1.Controls.Add(this.txtPedTotal);
            this.groupBox1.Controls.Add(this.txtPedEstado);
            this.groupBox1.Controls.Add(this.txtPedHora);
            this.groupBox1.Controls.Add(this.txtPedFecha);
            this.groupBox1.Controls.Add(this.txtPedId);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblListarClientes);
            this.groupBox1.Controls.Add(this.lblPedId);
            this.groupBox1.Controls.Add(this.lblPedTotal);
            this.groupBox1.Controls.Add(this.lblPedFecha);
            this.groupBox1.Controls.Add(this.lblEstPedido);
            this.groupBox1.Controls.Add(this.lblPedHora);
            this.groupBox1.Location = new System.Drawing.Point(42, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgPedidos);
            this.groupBox3.Location = new System.Drawing.Point(42, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 200);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(9, 12);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.Size = new System.Drawing.Size(650, 182);
            this.dtgPedidos.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(518, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(80, 227);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtPedId
            // 
            this.txtPedId.Enabled = false;
            this.txtPedId.Location = new System.Drawing.Point(284, 44);
            this.txtPedId.Name = "txtPedId";
            this.txtPedId.Size = new System.Drawing.Size(100, 20);
            this.txtPedId.TabIndex = 10;
            // 
            // txtPedFecha
            // 
            this.txtPedFecha.Location = new System.Drawing.Point(284, 89);
            this.txtPedFecha.Name = "txtPedFecha";
            this.txtPedFecha.Size = new System.Drawing.Size(100, 20);
            this.txtPedFecha.TabIndex = 11;
            // 
            // txtPedHora
            // 
            this.txtPedHora.Location = new System.Drawing.Point(284, 133);
            this.txtPedHora.Name = "txtPedHora";
            this.txtPedHora.Size = new System.Drawing.Size(100, 20);
            this.txtPedHora.TabIndex = 12;
            // 
            // txtPedEstado
            // 
            this.txtPedEstado.Location = new System.Drawing.Point(502, 44);
            this.txtPedEstado.Name = "txtPedEstado";
            this.txtPedEstado.Size = new System.Drawing.Size(100, 20);
            this.txtPedEstado.TabIndex = 13;
            // 
            // txtPedTotal
            // 
            this.txtPedTotal.Location = new System.Drawing.Point(502, 89);
            this.txtPedTotal.Name = "txtPedTotal";
            this.txtPedTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPedTotal.TabIndex = 14;
            // 
            // lstListarClientes
            // 
            this.lstListarClientes.FormattingEnabled = true;
            this.lstListarClientes.Location = new System.Drawing.Point(9, 32);
            this.lstListarClientes.Name = "lstListarClientes";
            this.lstListarClientes.Size = new System.Drawing.Size(185, 134);
            this.lstListarClientes.TabIndex = 10;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 468);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.Label lblPedId;
        private System.Windows.Forms.Label lblPedFecha;
        private System.Windows.Forms.Label lblPedHora;
        private System.Windows.Forms.Label lblEstPedido;
        private System.Windows.Forms.Label lblPedTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox lstListarClientes;
        private System.Windows.Forms.TextBox txtPedTotal;
        private System.Windows.Forms.TextBox txtPedEstado;
        private System.Windows.Forms.TextBox txtPedHora;
        private System.Windows.Forms.TextBox txtPedFecha;
        private System.Windows.Forms.TextBox txtPedId;
    }
}