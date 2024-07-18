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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkEstIngrediente = new System.Windows.Forms.CheckBox();
            this.lblEstIngrediente = new System.Windows.Forms.Label();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.txtIngId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgIngredientes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblIngId.Location = new System.Drawing.Point(6, 78);
            this.lblIngId.Name = "lblIngId";
            this.lblIngId.Size = new System.Drawing.Size(72, 13);
            this.lblIngId.TabIndex = 1;
            this.lblIngId.Text = "Id Ingrediente";
            // 
            // lblIngNombre
            // 
            this.lblIngNombre.AutoSize = true;
            this.lblIngNombre.Location = new System.Drawing.Point(247, 28);
            this.lblIngNombre.Name = "lblIngNombre";
            this.lblIngNombre.Size = new System.Drawing.Size(100, 13);
            this.lblIngNombre.TabIndex = 2;
            this.lblIngNombre.Text = "Nombre Ingrediente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(242, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 26);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Tabla de Ingredientes";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.chkEstIngrediente);
            this.groupBox1.Controls.Add(this.lblEstIngrediente);
            this.groupBox1.Controls.Add(this.txtIngNombre);
            this.groupBox1.Controls.Add(this.txtIngId);
            this.groupBox1.Controls.Add(this.lblListarProductos);
            this.groupBox1.Controls.Add(this.lblIngId);
            this.groupBox1.Controls.Add(this.lblIngNombre);
            this.groupBox1.Location = new System.Drawing.Point(66, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // chkEstIngrediente
            // 
            this.chkEstIngrediente.AutoSize = true;
            this.chkEstIngrediente.Location = new System.Drawing.Point(353, 78);
            this.chkEstIngrediente.Name = "chkEstIngrediente";
            this.chkEstIngrediente.Size = new System.Drawing.Size(15, 14);
            this.chkEstIngrediente.TabIndex = 14;
            this.chkEstIngrediente.UseVisualStyleBackColor = true;
            // 
            // lblEstIngrediente
            // 
            this.lblEstIngrediente.AutoSize = true;
            this.lblEstIngrediente.Location = new System.Drawing.Point(247, 79);
            this.lblEstIngrediente.Name = "lblEstIngrediente";
            this.lblEstIngrediente.Size = new System.Drawing.Size(96, 13);
            this.lblEstIngrediente.TabIndex = 13;
            this.lblEstIngrediente.Text = "Estado Ingrediente";
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Enabled = false;
            this.txtIngNombre.Location = new System.Drawing.Point(353, 25);
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(158, 20);
            this.txtIngNombre.TabIndex = 4;
            // 
            // txtIngId
            // 
            this.txtIngId.Enabled = false;
            this.txtIngId.Location = new System.Drawing.Point(83, 76);
            this.txtIngId.Name = "txtIngId";
            this.txtIngId.Size = new System.Drawing.Size(140, 20);
            this.txtIngId.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgIngredientes);
            this.groupBox2.Location = new System.Drawing.Point(66, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dtgIngredientes
            // 
            this.dtgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredientes.Location = new System.Drawing.Point(6, 17);
            this.dtgIngredientes.Name = "dtgIngredientes";
            this.dtgIngredientes.Size = new System.Drawing.Size(522, 167);
            this.dtgIngredientes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Location = new System.Drawing.Point(66, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 42);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.borrar1;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(405, 13);
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
            this.btnModificar.Location = new System.Drawing.Point(293, 13);
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
            this.btnNuevo.Location = new System.Drawing.Point(168, 13);
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
            this.btnGuardar.Location = new System.Drawing.Point(53, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.ingredientes;
            this.pictureBox1.Location = new System.Drawing.Point(159, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmIngredientes";
            this.Text = "FrmIngredientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtIngNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkEstIngrediente;
        private System.Windows.Forms.Label lblEstIngrediente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}