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
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.txtMenNotificacion = new System.Windows.Forms.TextBox();
            this.txtFecNotificacion = new System.Windows.Forms.TextBox();
            this.txtIdNotificaciones = new System.Windows.Forms.TextBox();
            this.lblMenNotificacion = new System.Windows.Forms.Label();
            this.lblNotFecha = new System.Windows.Forms.Label();
            this.lblIdNotificacion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgNotificaciones = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxClientes);
            this.groupBox1.Controls.Add(this.lblListarClientes);
            this.groupBox1.Controls.Add(this.txtMenNotificacion);
            this.groupBox1.Controls.Add(this.txtFecNotificacion);
            this.groupBox1.Controls.Add(this.txtIdNotificaciones);
            this.groupBox1.Controls.Add(this.lblMenNotificacion);
            this.groupBox1.Controls.Add(this.lblNotFecha);
            this.groupBox1.Controls.Add(this.lblIdNotificacion);
            this.groupBox1.Location = new System.Drawing.Point(105, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(100, 64);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(156, 21);
            this.cbxClientes.TabIndex = 10;
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.Location = new System.Drawing.Point(6, 67);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.Size = new System.Drawing.Size(44, 13);
            this.lblListarClientes.TabIndex = 9;
            this.lblListarClientes.Text = "Clientes";
            // 
            // txtMenNotificacion
            // 
            this.txtMenNotificacion.Location = new System.Drawing.Point(314, 48);
            this.txtMenNotificacion.Multiline = true;
            this.txtMenNotificacion.Name = "txtMenNotificacion";
            this.txtMenNotificacion.Size = new System.Drawing.Size(212, 87);
            this.txtMenNotificacion.TabIndex = 8;
            // 
            // txtFecNotificacion
            // 
            this.txtFecNotificacion.Location = new System.Drawing.Point(100, 100);
            this.txtFecNotificacion.Name = "txtFecNotificacion";
            this.txtFecNotificacion.Size = new System.Drawing.Size(156, 20);
            this.txtFecNotificacion.TabIndex = 6;
            // 
            // txtIdNotificaciones
            // 
            this.txtIdNotificaciones.Enabled = false;
            this.txtIdNotificaciones.Location = new System.Drawing.Point(100, 29);
            this.txtIdNotificaciones.Name = "txtIdNotificaciones";
            this.txtIdNotificaciones.Size = new System.Drawing.Size(156, 20);
            this.txtIdNotificaciones.TabIndex = 5;
            // 
            // lblMenNotificacion
            // 
            this.lblMenNotificacion.AutoSize = true;
            this.lblMenNotificacion.Location = new System.Drawing.Point(342, 29);
            this.lblMenNotificacion.Name = "lblMenNotificacion";
            this.lblMenNotificacion.Size = new System.Drawing.Size(159, 13);
            this.lblMenNotificacion.TabIndex = 4;
            this.lblMenNotificacion.Text = "Notificación  y/u Observaciones";
            this.lblMenNotificacion.Click += new System.EventHandler(this.lblPrdDescripcion_Click);
            // 
            // lblNotFecha
            // 
            this.lblNotFecha.AutoSize = true;
            this.lblNotFecha.Location = new System.Drawing.Point(6, 100);
            this.lblNotFecha.Name = "lblNotFecha";
            this.lblNotFecha.Size = new System.Drawing.Size(96, 13);
            this.lblNotFecha.TabIndex = 2;
            this.lblNotFecha.Text = "Fecha Notificación";
            // 
            // lblIdNotificacion
            // 
            this.lblIdNotificacion.AutoSize = true;
            this.lblIdNotificacion.Location = new System.Drawing.Point(6, 32);
            this.lblIdNotificacion.Name = "lblIdNotificacion";
            this.lblIdNotificacion.Size = new System.Drawing.Size(78, 13);
            this.lblIdNotificacion.TabIndex = 1;
            this.lblIdNotificacion.Text = "Id_Notificación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(105, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 42);
            this.groupBox3.TabIndex = 13;
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
            this.groupBox2.Controls.Add(this.dtgNotificaciones);
            this.groupBox2.Location = new System.Drawing.Point(105, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 160);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // dtgNotificaciones
            // 
            this.dtgNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotificaciones.Location = new System.Drawing.Point(6, 13);
            this.dtgNotificaciones.Name = "dtgNotificaciones";
            this.dtgNotificaciones.Size = new System.Drawing.Size(545, 141);
            this.dtgNotificaciones.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(218, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 24);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Notificaciones y Observaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Notificacion;
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmNotificaciones";
            this.Text = "FrmNotificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.TextBox txtMenNotificacion;
        private System.Windows.Forms.TextBox txtFecNotificacion;
        private System.Windows.Forms.TextBox txtIdNotificaciones;
        private System.Windows.Forms.Label lblMenNotificacion;
        private System.Windows.Forms.Label lblNotFecha;
        private System.Windows.Forms.Label lblIdNotificacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgNotificaciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}