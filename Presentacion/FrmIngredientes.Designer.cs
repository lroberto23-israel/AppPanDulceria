namespace Presentacion
{
    partial class FrmIngredientes
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
            this.lblListarProductos = new System.Windows.Forms.Label();
            this.lblIngId = new System.Windows.Forms.Label();
            this.lblIngNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgIngredientes = new System.Windows.Forms.DataGridView();
            this.txtIngId = new System.Windows.Forms.TextBox();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListarProductos
            // 
            this.lblListarProductos.AutoSize = true;
            this.lblListarProductos.Location = new System.Drawing.Point(6, 28);
            this.lblListarProductos.Name = "lblListarProductos";
            this.lblListarProductos.Size = new System.Drawing.Size(55, 13);
            this.lblListarProductos.TabIndex = 0;
            this.lblListarProductos.Text = "Productos";
            this.lblListarProductos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIngId
            // 
            this.lblIngId.AutoSize = true;
            this.lblIngId.Location = new System.Drawing.Point(194, 29);
            this.lblIngId.Name = "lblIngId";
            this.lblIngId.Size = new System.Drawing.Size(72, 13);
            this.lblIngId.TabIndex = 1;
            this.lblIngId.Text = "Id Ingrediente";
            // 
            // lblIngNombre
            // 
            this.lblIngNombre.AutoSize = true;
            this.lblIngNombre.Location = new System.Drawing.Point(344, 28);
            this.lblIngNombre.Name = "lblIngNombre";
            this.lblIngNombre.Size = new System.Drawing.Size(100, 13);
            this.lblIngNombre.TabIndex = 2;
            this.lblIngNombre.Text = "Nombre Ingrediente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(229, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 26);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Tabla de Ingredientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lstProductos);
            this.groupBox1.Controls.Add(this.txtIngNombre);
            this.groupBox1.Controls.Add(this.txtIngId);
            this.groupBox1.Controls.Add(this.lblListarProductos);
            this.groupBox1.Controls.Add(this.lblIngId);
            this.groupBox1.Controls.Add(this.lblIngNombre);
            this.groupBox1.Location = new System.Drawing.Point(83, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgIngredientes);
            this.groupBox2.Location = new System.Drawing.Point(83, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 203);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dtgIngredientes
            // 
            this.dtgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredientes.Location = new System.Drawing.Point(6, 19);
            this.dtgIngredientes.Name = "dtgIngredientes";
            this.dtgIngredientes.Size = new System.Drawing.Size(474, 178);
            this.dtgIngredientes.TabIndex = 0;
            // 
            // txtIngId
            // 
            this.txtIngId.Enabled = false;
            this.txtIngId.Location = new System.Drawing.Point(181, 45);
            this.txtIngId.Name = "txtIngId";
            this.txtIngId.Size = new System.Drawing.Size(100, 20);
            this.txtIngId.TabIndex = 3;
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Enabled = false;
            this.txtIngNombre.Location = new System.Drawing.Point(321, 45);
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(158, 20);
            this.txtIngNombre.TabIndex = 4;
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(9, 44);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(153, 121);
            this.lstProductos.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(223, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(321, 143);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmIngredientes";
            this.Text = "FrmIngredientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListarProductos;
        private System.Windows.Forms.Label lblIngId;
        private System.Windows.Forms.Label lblIngNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIngId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgIngredientes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.TextBox txtIngNombre;
    }
}