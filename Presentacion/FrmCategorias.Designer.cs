namespace Presentacion
{
    partial class FrmCategorias
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
            this.txtCatDescripcion = new System.Windows.Forms.TextBox();
            this.txtCatNombre = new System.Windows.Forms.TextBox();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.lblCatDescripcion = new System.Windows.Forms.Label();
            this.lblCatNombre = new System.Windows.Forms.Label();
            this.lblCatId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCatDescripcion);
            this.groupBox1.Controls.Add(this.txtCatNombre);
            this.groupBox1.Controls.Add(this.txtCatId);
            this.groupBox1.Controls.Add(this.lblCatDescripcion);
            this.groupBox1.Controls.Add(this.lblCatNombre);
            this.groupBox1.Controls.Add(this.lblCatId);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCatDescripcion
            // 
            this.txtCatDescripcion.Location = new System.Drawing.Point(20, 121);
            this.txtCatDescripcion.Multiline = true;
            this.txtCatDescripcion.Name = "txtCatDescripcion";
            this.txtCatDescripcion.Size = new System.Drawing.Size(308, 107);
            this.txtCatDescripcion.TabIndex = 5;
            // 
            // txtCatNombre
            // 
            this.txtCatNombre.Location = new System.Drawing.Point(142, 58);
            this.txtCatNombre.Name = "txtCatNombre";
            this.txtCatNombre.Size = new System.Drawing.Size(186, 20);
            this.txtCatNombre.TabIndex = 4;
            // 
            // txtCatId
            // 
            this.txtCatId.Enabled = false;
            this.txtCatId.Location = new System.Drawing.Point(142, 12);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(186, 20);
            this.txtCatId.TabIndex = 3;
            // 
            // lblCatDescripcion
            // 
            this.lblCatDescripcion.AutoSize = true;
            this.lblCatDescripcion.Location = new System.Drawing.Point(121, 105);
            this.lblCatDescripcion.Name = "lblCatDescripcion";
            this.lblCatDescripcion.Size = new System.Drawing.Size(94, 13);
            this.lblCatDescripcion.TabIndex = 2;
            this.lblCatDescripcion.Text = "Breve Descripcion";
            // 
            // lblCatNombre
            // 
            this.lblCatNombre.AutoSize = true;
            this.lblCatNombre.Location = new System.Drawing.Point(17, 61);
            this.lblCatNombre.Name = "lblCatNombre";
            this.lblCatNombre.Size = new System.Drawing.Size(92, 13);
            this.lblCatNombre.TabIndex = 1;
            this.lblCatNombre.Text = "Nombre Categoria";
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.Location = new System.Drawing.Point(17, 19);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(64, 13);
            this.lblCatId.TabIndex = 0;
            this.lblCatId.Text = "Id Categoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCategorias);
            this.groupBox2.Location = new System.Drawing.Point(382, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Location = new System.Drawing.Point(6, 19);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.Size = new System.Drawing.Size(347, 150);
            this.dtgCategorias.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(316, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CATEGORIAS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(434, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(616, 276);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 328);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCatDescripcion;
        private System.Windows.Forms.Label lblCatNombre;
        private System.Windows.Forms.Label lblCatId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.TextBox txtCatDescripcion;
        private System.Windows.Forms.TextBox txtCatNombre;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
    }
}