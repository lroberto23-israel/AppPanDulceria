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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCreId = new System.Windows.Forms.TextBox();
            this.lblCreClave = new System.Windows.Forms.Label();
            this.lblCreId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCredenciales = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredenciales)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblListarClientes);
            this.groupBox1.Controls.Add(this.lstClientes);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtCreId);
            this.groupBox1.Controls.Add(this.lblCreClave);
            this.groupBox1.Controls.Add(this.lblCreId);
            this.groupBox1.Location = new System.Drawing.Point(21, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtCreId
            // 
            this.txtCreId.Enabled = false;
            this.txtCreId.Location = new System.Drawing.Point(254, 35);
            this.txtCreId.Name = "txtCreId";
            this.txtCreId.Size = new System.Drawing.Size(115, 20);
            this.txtCreId.TabIndex = 3;
            // 
            // lblCreClave
            // 
            this.lblCreClave.AutoSize = true;
            this.lblCreClave.Location = new System.Drawing.Point(266, 81);
            this.lblCreClave.Name = "lblCreClave";
            this.lblCreClave.Size = new System.Drawing.Size(87, 13);
            this.lblCreClave.TabIndex = 1;
            this.lblCreClave.Text = "Clave Credencial";
            this.lblCreClave.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCreId
            // 
            this.lblCreId.AutoSize = true;
            this.lblCreId.Location = new System.Drawing.Point(275, 17);
            this.lblCreId.Name = "lblCreId";
            this.lblCreId.Size = new System.Drawing.Size(69, 13);
            this.lblCreId.TabIndex = 0;
            this.lblCreId.Text = "Id Credencial";
            this.lblCreId.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCredenciales);
            this.groupBox2.Location = new System.Drawing.Point(416, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgCredenciales
            // 
            this.dtgCredenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCredenciales.Location = new System.Drawing.Point(6, 6);
            this.dtgCredenciales.Name = "dtgCredenciales";
            this.dtgCredenciales.Size = new System.Drawing.Size(312, 173);
            this.dtgCredenciales.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(94, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(90, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(0, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(261, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Credenciales del Cliente";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(6, 35);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(242, 82);
            this.lstClientes.TabIndex = 3;
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.Location = new System.Drawing.Point(6, 16);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.Size = new System.Drawing.Size(81, 13);
            this.lblListarClientes.TabIndex = 5;
            this.lblListarClientes.Text = "Listado Clientes";
            // 
            // FrmCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 255);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCredenciales";
            this.Text = "FrmCredenciales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredenciales)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCreId;
        private System.Windows.Forms.Label lblCreClave;
        private System.Windows.Forms.DataGridView dtgCredenciales;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCreId;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.ListBox lstClientes;
    }
}