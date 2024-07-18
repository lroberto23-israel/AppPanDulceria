namespace Presentacion
{
    partial class FrmClientes
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCliDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCliTelefono = new System.Windows.Forms.TextBox();
            this.txtCliCorreo = new System.Windows.Forms.TextBox();
            this.txtCliNombre = new System.Windows.Forms.TextBox();
            this.txtCliId = new System.Windows.Forms.TextBox();
            this.lblCliDireccion = new System.Windows.Forms.Label();
            this.lblCliTelefono = new System.Windows.Forms.Label();
            this.lblCliCorreo = new System.Windows.Forms.Label();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtCliDireccion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtCliTelefono);
            this.groupBox1.Controls.Add(this.txtCliCorreo);
            this.groupBox1.Controls.Add(this.txtCliNombre);
            this.groupBox1.Controls.Add(this.txtCliId);
            this.groupBox1.Controls.Add(this.lblCliDireccion);
            this.groupBox1.Controls.Add(this.lblCliTelefono);
            this.groupBox1.Controls.Add(this.lblCliCorreo);
            this.groupBox1.Controls.Add(this.lblCliNombre);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(108, 158);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCliDireccion
            // 
            this.txtCliDireccion.Location = new System.Drawing.Point(453, 74);
            this.txtCliDireccion.Multiline = true;
            this.txtCliDireccion.Name = "txtCliDireccion";
            this.txtCliDireccion.Size = new System.Drawing.Size(217, 62);
            this.txtCliDireccion.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(506, 158);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCliTelefono
            // 
            this.txtCliTelefono.Location = new System.Drawing.Point(453, 32);
            this.txtCliTelefono.Name = "txtCliTelefono";
            this.txtCliTelefono.Size = new System.Drawing.Size(217, 20);
            this.txtCliTelefono.TabIndex = 8;
            // 
            // txtCliCorreo
            // 
            this.txtCliCorreo.Location = new System.Drawing.Point(108, 120);
            this.txtCliCorreo.Name = "txtCliCorreo";
            this.txtCliCorreo.Size = new System.Drawing.Size(193, 20);
            this.txtCliCorreo.TabIndex = 7;
            // 
            // txtCliNombre
            // 
            this.txtCliNombre.Location = new System.Drawing.Point(108, 79);
            this.txtCliNombre.Multiline = true;
            this.txtCliNombre.Name = "txtCliNombre";
            this.txtCliNombre.Size = new System.Drawing.Size(193, 20);
            this.txtCliNombre.TabIndex = 6;
            // 
            // txtCliId
            // 
            this.txtCliId.Enabled = false;
            this.txtCliId.Location = new System.Drawing.Point(108, 36);
            this.txtCliId.Name = "txtCliId";
            this.txtCliId.Size = new System.Drawing.Size(193, 20);
            this.txtCliId.TabIndex = 5;
            // 
            // lblCliDireccion
            // 
            this.lblCliDireccion.AutoSize = true;
            this.lblCliDireccion.Location = new System.Drawing.Point(316, 79);
            this.lblCliDireccion.Name = "lblCliDireccion";
            this.lblCliDireccion.Size = new System.Drawing.Size(120, 13);
            this.lblCliDireccion.TabIndex = 4;
            this.lblCliDireccion.Text = "Dirección y Referencias";
            // 
            // lblCliTelefono
            // 
            this.lblCliTelefono.AutoSize = true;
            this.lblCliTelefono.Location = new System.Drawing.Point(316, 39);
            this.lblCliTelefono.Name = "lblCliTelefono";
            this.lblCliTelefono.Size = new System.Drawing.Size(50, 13);
            this.lblCliTelefono.TabIndex = 3;
            this.lblCliTelefono.Text = "Contacto";
            // 
            // lblCliCorreo
            // 
            this.lblCliCorreo.AutoSize = true;
            this.lblCliCorreo.Location = new System.Drawing.Point(8, 123);
            this.lblCliCorreo.Name = "lblCliCorreo";
            this.lblCliCorreo.Size = new System.Drawing.Size(32, 13);
            this.lblCliCorreo.TabIndex = 2;
            this.lblCliCorreo.Text = "Email";
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Location = new System.Drawing.Point(6, 82);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(96, 13);
            this.lblCliNombre.TabIndex = 1;
            this.lblCliNombre.Text = "Nombre del Cliente";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(8, 39);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(51, 13);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "Id Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgClientes);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(6, 63);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(695, 131);
            this.dtgClientes.TabIndex = 0;
            this.dtgClientes.SelectionChanged += new System.EventHandler(this.dtgClientes_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(286, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 26);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Información de Clientes";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 441);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCliDireccion;
        private System.Windows.Forms.Label lblCliTelefono;
        private System.Windows.Forms.Label lblCliCorreo;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCliDireccion;
        private System.Windows.Forms.TextBox txtCliTelefono;
        private System.Windows.Forms.TextBox txtCliCorreo;
        private System.Windows.Forms.TextBox txtCliNombre;
        private System.Windows.Forms.TextBox txtCliId;
    }
}