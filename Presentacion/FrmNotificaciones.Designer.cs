namespace Presentacion
{
    partial class FrmNotificaciones
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
            this.lblNotId = new System.Windows.Forms.Label();
            this.lblNotMensaje = new System.Windows.Forms.Label();
            this.lblNotFecha = new System.Windows.Forms.Label();
            this.txtNotId = new System.Windows.Forms.TextBox();
            this.txtNotFecha = new System.Windows.Forms.TextBox();
            this.txtNotMensaje = new System.Windows.Forms.TextBox();
            this.dtgNotificacion = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstClientes);
            this.groupBox1.Controls.Add(this.lblListarClientes);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNotMensaje);
            this.groupBox1.Controls.Add(this.txtNotFecha);
            this.groupBox1.Controls.Add(this.txtNotId);
            this.groupBox1.Controls.Add(this.lblNotFecha);
            this.groupBox1.Controls.Add(this.lblNotMensaje);
            this.groupBox1.Controls.Add(this.lblNotId);
            this.groupBox1.Location = new System.Drawing.Point(49, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgNotificacion);
            this.groupBox2.Location = new System.Drawing.Point(152, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblNotId
            // 
            this.lblNotId.AutoSize = true;
            this.lblNotId.Location = new System.Drawing.Point(316, 14);
            this.lblNotId.Name = "lblNotId";
            this.lblNotId.Size = new System.Drawing.Size(75, 13);
            this.lblNotId.TabIndex = 0;
            this.lblNotId.Text = "Id Notificacion";
            // 
            // lblNotMensaje
            // 
            this.lblNotMensaje.AutoSize = true;
            this.lblNotMensaje.Location = new System.Drawing.Point(551, 16);
            this.lblNotMensaje.Name = "lblNotMensaje";
            this.lblNotMensaje.Size = new System.Drawing.Size(116, 13);
            this.lblNotMensaje.TabIndex = 1;
            this.lblNotMensaje.Text = "Mensaje - Observación";
            // 
            // lblNotFecha
            // 
            this.lblNotFecha.AutoSize = true;
            this.lblNotFecha.Location = new System.Drawing.Point(310, 69);
            this.lblNotFecha.Name = "lblNotFecha";
            this.lblNotFecha.Size = new System.Drawing.Size(96, 13);
            this.lblNotFecha.TabIndex = 2;
            this.lblNotFecha.Text = "Fecha Notificación";
            // 
            // txtNotId
            // 
            this.txtNotId.Enabled = false;
            this.txtNotId.Location = new System.Drawing.Point(306, 30);
            this.txtNotId.Name = "txtNotId";
            this.txtNotId.Size = new System.Drawing.Size(100, 20);
            this.txtNotId.TabIndex = 3;
            // 
            // txtNotFecha
            // 
            this.txtNotFecha.Location = new System.Drawing.Point(306, 85);
            this.txtNotFecha.Name = "txtNotFecha";
            this.txtNotFecha.Size = new System.Drawing.Size(100, 20);
            this.txtNotFecha.TabIndex = 4;
            // 
            // txtNotMensaje
            // 
            this.txtNotMensaje.Location = new System.Drawing.Point(490, 33);
            this.txtNotMensaje.Multiline = true;
            this.txtNotMensaje.Name = "txtNotMensaje";
            this.txtNotMensaje.Size = new System.Drawing.Size(243, 121);
            this.txtNotMensaje.TabIndex = 5;
            // 
            // dtgNotificacion
            // 
            this.dtgNotificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotificacion.Location = new System.Drawing.Point(5, 14);
            this.dtgNotificacion.Name = "dtgNotificacion";
            this.dtgNotificacion.Size = new System.Drawing.Size(521, 155);
            this.dtgNotificacion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(237, 143);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(408, 143);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.Location = new System.Drawing.Point(20, 10);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.Size = new System.Drawing.Size(44, 13);
            this.lblListarClientes.TabIndex = 8;
            this.lblListarClientes.Text = "Clientes";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(23, 26);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(199, 121);
            this.lstClientes.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Notificaciones y Observaciones";
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNotificaciones";
            this.Text = "FrmNotificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNotMensaje;
        private System.Windows.Forms.TextBox txtNotFecha;
        private System.Windows.Forms.TextBox txtNotId;
        private System.Windows.Forms.Label lblNotFecha;
        private System.Windows.Forms.Label lblNotMensaje;
        private System.Windows.Forms.Label lblNotId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgNotificacion;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.Label label2;
    }
}