namespace Presentacion
{
    partial class FrmProductos
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
            this.txtPrdDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrdPrecio = new System.Windows.Forms.TextBox();
            this.txtPrdNombre = new System.Windows.Forms.TextBox();
            this.txtPrdId = new System.Windows.Forms.TextBox();
            this.lblPrdDescripcion = new System.Windows.Forms.Label();
            this.lblPrdPrecio = new System.Windows.Forms.Label();
            this.lblPrdNombre = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrdDescripcion);
            this.groupBox1.Controls.Add(this.txtPrdPrecio);
            this.groupBox1.Controls.Add(this.txtPrdNombre);
            this.groupBox1.Controls.Add(this.txtPrdId);
            this.groupBox1.Controls.Add(this.lblPrdDescripcion);
            this.groupBox1.Controls.Add(this.lblPrdPrecio);
            this.groupBox1.Controls.Add(this.lblPrdNombre);
            this.groupBox1.Controls.Add(this.lblProdId);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(82, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPrdDescripcion
            // 
            this.txtPrdDescripcion.Location = new System.Drawing.Point(314, 48);
            this.txtPrdDescripcion.Multiline = true;
            this.txtPrdDescripcion.Name = "txtPrdDescripcion";
            this.txtPrdDescripcion.Size = new System.Drawing.Size(212, 87);
            this.txtPrdDescripcion.TabIndex = 8;
            // 
            // txtPrdPrecio
            // 
            this.txtPrdPrecio.Location = new System.Drawing.Point(100, 119);
            this.txtPrdPrecio.Name = "txtPrdPrecio";
            this.txtPrdPrecio.Size = new System.Drawing.Size(156, 20);
            this.txtPrdPrecio.TabIndex = 7;
            // 
            // txtPrdNombre
            // 
            this.txtPrdNombre.Location = new System.Drawing.Point(100, 74);
            this.txtPrdNombre.Name = "txtPrdNombre";
            this.txtPrdNombre.Size = new System.Drawing.Size(156, 20);
            this.txtPrdNombre.TabIndex = 6;
            // 
            // txtPrdId
            // 
            this.txtPrdId.Enabled = false;
            this.txtPrdId.Location = new System.Drawing.Point(100, 29);
            this.txtPrdId.Name = "txtPrdId";
            this.txtPrdId.Size = new System.Drawing.Size(156, 20);
            this.txtPrdId.TabIndex = 5;
            // 
            // lblPrdDescripcion
            // 
            this.lblPrdDescripcion.AutoSize = true;
            this.lblPrdDescripcion.Location = new System.Drawing.Point(357, 29);
            this.lblPrdDescripcion.Name = "lblPrdDescripcion";
            this.lblPrdDescripcion.Size = new System.Drawing.Size(126, 13);
            this.lblPrdDescripcion.TabIndex = 4;
            this.lblPrdDescripcion.Text = "Descripcion del Producto";
            // 
            // lblPrdPrecio
            // 
            this.lblPrdPrecio.AutoSize = true;
            this.lblPrdPrecio.Location = new System.Drawing.Point(6, 122);
            this.lblPrdPrecio.Name = "lblPrdPrecio";
            this.lblPrdPrecio.Size = new System.Drawing.Size(83, 13);
            this.lblPrdPrecio.TabIndex = 3;
            this.lblPrdPrecio.Text = "Precio Producto";
            // 
            // lblPrdNombre
            // 
            this.lblPrdNombre.AutoSize = true;
            this.lblPrdNombre.Location = new System.Drawing.Point(6, 77);
            this.lblPrdNombre.Name = "lblPrdNombre";
            this.lblPrdNombre.Size = new System.Drawing.Size(90, 13);
            this.lblPrdNombre.TabIndex = 2;
            this.lblPrdNombre.Text = "Nombre Producto";
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Location = new System.Drawing.Point(29, 32);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(65, 13);
            this.lblProdId.TabIndex = 1;
            this.lblProdId.Text = "Id_Producto";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(343, 176);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(149, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(262, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Productos a Ofrecer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgProductos);
            this.groupBox2.Location = new System.Drawing.Point(82, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(6, 13);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(545, 141);
            this.dtgProductos.TabIndex = 0;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrdDescripcion;
        private System.Windows.Forms.TextBox txtPrdPrecio;
        private System.Windows.Forms.TextBox txtPrdNombre;
        private System.Windows.Forms.TextBox txtPrdId;
        private System.Windows.Forms.Label lblPrdDescripcion;
        private System.Windows.Forms.Label lblPrdPrecio;
        private System.Windows.Forms.Label lblPrdNombre;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgProductos;
    }
}