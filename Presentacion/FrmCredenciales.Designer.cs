namespace Presentacion
{
    partial class FrmCredenciales
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
            this.cbxListarClientes = new System.Windows.Forms.ComboBox();
            this.chkEstCredencial = new System.Windows.Forms.CheckBox();
            this.lblEstCredencial = new System.Windows.Forms.Label();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.txtCreClave = new System.Windows.Forms.TextBox();
            this.txtCreId = new System.Windows.Forms.TextBox();
            this.lblCreClave = new System.Windows.Forms.Label();
            this.lblCreId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCredenciales = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredenciales)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxListarClientes);
            this.groupBox1.Controls.Add(this.chkEstCredencial);
            this.groupBox1.Controls.Add(this.lblEstCredencial);
            this.groupBox1.Controls.Add(this.lblListarClientes);
            this.groupBox1.Controls.Add(this.txtCreClave);
            this.groupBox1.Controls.Add(this.txtCreId);
            this.groupBox1.Controls.Add(this.lblCreClave);
            this.groupBox1.Controls.Add(this.lblCreId);
            this.groupBox1.Location = new System.Drawing.Point(27, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbxListarClientes
            // 
            this.cbxListarClientes.FormattingEnabled = true;
            this.cbxListarClientes.Location = new System.Drawing.Point(114, 28);
            this.cbxListarClientes.Name = "cbxListarClientes";
            this.cbxListarClientes.Size = new System.Drawing.Size(149, 21);
            this.cbxListarClientes.TabIndex = 15;
            // 
            // chkEstCredencial
            // 
            this.chkEstCredencial.AutoSize = true;
            this.chkEstCredencial.Location = new System.Drawing.Point(383, 88);
            this.chkEstCredencial.Name = "chkEstCredencial";
            this.chkEstCredencial.Size = new System.Drawing.Size(15, 14);
            this.chkEstCredencial.TabIndex = 14;
            this.chkEstCredencial.UseVisualStyleBackColor = true;
            // 
            // lblEstCredencial
            // 
            this.lblEstCredencial.AutoSize = true;
            this.lblEstCredencial.Location = new System.Drawing.Point(290, 88);
            this.lblEstCredencial.Name = "lblEstCredencial";
            this.lblEstCredencial.Size = new System.Drawing.Size(93, 13);
            this.lblEstCredencial.TabIndex = 13;
            this.lblEstCredencial.Text = "Estado Credencial";
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.Location = new System.Drawing.Point(6, 32);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.Size = new System.Drawing.Size(81, 13);
            this.lblListarClientes.TabIndex = 5;
            this.lblListarClientes.Text = "Listado Clientes";
            // 
            // txtCreClave
            // 
            this.txtCreClave.Location = new System.Drawing.Point(383, 28);
            this.txtCreClave.Name = "txtCreClave";
            this.txtCreClave.Size = new System.Drawing.Size(143, 20);
            this.txtCreClave.TabIndex = 4;
            // 
            // txtCreId
            // 
            this.txtCreId.Enabled = false;
            this.txtCreId.Location = new System.Drawing.Point(114, 85);
            this.txtCreId.Name = "txtCreId";
            this.txtCreId.Size = new System.Drawing.Size(115, 20);
            this.txtCreId.TabIndex = 3;
            this.txtCreId.TextChanged += new System.EventHandler(this.txtCreId_TextChanged);
            // 
            // lblCreClave
            // 
            this.lblCreClave.AutoSize = true;
            this.lblCreClave.Location = new System.Drawing.Point(290, 32);
            this.lblCreClave.Name = "lblCreClave";
            this.lblCreClave.Size = new System.Drawing.Size(87, 13);
            this.lblCreClave.TabIndex = 1;
            this.lblCreClave.Text = "Clave Credencial";
            this.lblCreClave.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCreId
            // 
            this.lblCreId.AutoSize = true;
            this.lblCreId.Location = new System.Drawing.Point(6, 88);
            this.lblCreId.Name = "lblCreId";
            this.lblCreId.Size = new System.Drawing.Size(69, 13);
            this.lblCreId.TabIndex = 0;
            this.lblCreId.Text = "Id Credencial";
            this.lblCreId.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCredenciales);
            this.groupBox2.Location = new System.Drawing.Point(27, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgCredenciales
            // 
            this.dtgCredenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCredenciales.Location = new System.Drawing.Point(6, 20);
            this.dtgCredenciales.Name = "dtgCredenciales";
            this.dtgCredenciales.Size = new System.Drawing.Size(520, 166);
            this.dtgCredenciales.TabIndex = 0;
            this.dtgCredenciales.SelectionChanged += new System.EventHandler(this.dtgCredenciales_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(196, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Credenciales del Cliente";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(27, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 42);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.borrar1;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(402, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Presentacion.Properties.Resources.archivo_de_edicion;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(278, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.agregar_documento;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(154, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(34, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.credential_3324737;
            this.pictureBox1.Location = new System.Drawing.Point(126, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCredenciales";
            this.Text = "FrmCredenciales";
            this.Load += new System.EventHandler(this.FrmCredenciales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredenciales)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCreId;
        private System.Windows.Forms.Label lblCreClave;
        private System.Windows.Forms.DataGridView dtgCredenciales;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCreClave;
        private System.Windows.Forms.TextBox txtCreId;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkEstCredencial;
        private System.Windows.Forms.Label lblEstCredencial;
        private System.Windows.Forms.ComboBox cbxListarClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}