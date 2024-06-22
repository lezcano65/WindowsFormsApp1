namespace ABMaplicacion
{
    partial class AplicacionABM
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
            this.components = new System.ComponentModel.Container();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelFilas = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.numericCodigo = new System.Windows.Forms.NumericUpDown();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.AccessibleName = "buttonNuevo";
            this.buttonNuevo.Location = new System.Drawing.Point(6, 146);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click_1);
            // 
            // buttonEditar
            // 
            this.buttonEditar.AccessibleName = "buttonEditar";
            this.buttonEditar.Location = new System.Drawing.Point(7, 175);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.AccessibleName = "buttonBorrar";
            this.buttonBorrar.Location = new System.Drawing.Point(94, 146);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 2;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AccessibleName = "buttonLimpiar";
            this.buttonLimpiar.Location = new System.Drawing.Point(94, 175);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click_1);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AccessibleName = "labelCodigo";
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(3, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 7;
            this.labelCodigo.Text = "Codigo";
            this.labelCodigo.Click += new System.EventHandler(this.labelCodigo_Click);
            // 
            // labelDetalle
            // 
            this.labelDetalle.AccessibleName = "labelDetalle";
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Location = new System.Drawing.Point(3, 33);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(40, 13);
            this.labelDetalle.TabIndex = 8;
            this.labelDetalle.Text = "Detalle";
            this.labelDetalle.Click += new System.EventHandler(this.labelDetalle_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AccessibleName = "labelMarca";
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(3, 55);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 9;
            this.labelMarca.Text = "Marca";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AccessibleName = "labelCantidad";
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(3, 76);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 10;
            this.labelCantidad.Text = "Cantidad";
            this.labelCantidad.Click += new System.EventHandler(this.labelCantidad_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AccessibleName = "labelPrecio";
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(4, 99);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "Precio";
            this.labelPrecio.Click += new System.EventHandler(this.labelPrecio_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AccessibleName = "labelFecha";
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(3, 122);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.AccessibleName = "textBoxDetalle";
            this.textBoxDetalle.Location = new System.Drawing.Point(53, 29);
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(116, 20);
            this.textBoxDetalle.TabIndex = 14;
            this.textBoxDetalle.TextChanged += new System.EventHandler(this.textBoxDetalle_TextChanged);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.AccessibleName = "dateTimePickerFecha";
            this.dateTimePickerFecha.CustomFormat = "";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(53, 120);
            this.dateTimePickerFecha.MaxDate = new System.DateTime(2024, 6, 15, 15, 56, 27, 0);
            this.dateTimePickerFecha.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerFecha.TabIndex = 18;
            this.dateTimePickerFecha.Value = new System.DateTime(2024, 6, 15, 0, 0, 0, 0);
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AccessibleName = "dataGridViewList";
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(194, 7);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(397, 145);
            this.dataGridViewList.TabIndex = 21;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.AccessibleName = "buttonBuscar";
            this.buttonBuscar.Location = new System.Drawing.Point(482, 177);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 22;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.AccessibleName = "textBoxBuscar";
            this.textBoxBuscar.Location = new System.Drawing.Point(194, 177);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(282, 20);
            this.textBoxBuscar.TabIndex = 23;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelFilas
            // 
            this.labelFilas.AccessibleName = "labelFilas";
            this.labelFilas.AutoSize = true;
            this.labelFilas.Location = new System.Drawing.Point(191, 156);
            this.labelFilas.Name = "labelFilas";
            this.labelFilas.Size = new System.Drawing.Size(101, 13);
            this.labelFilas.TabIndex = 24;
            this.labelFilas.Text = "Numero de registros";
            this.labelFilas.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numericCantidad
            // 
            this.numericCantidad.AccessibleName = "numericCantidad";
            this.numericCantidad.Location = new System.Drawing.Point(53, 73);
            this.numericCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(116, 20);
            this.numericCantidad.TabIndex = 26;
            this.numericCantidad.ValueChanged += new System.EventHandler(this.numericTipo_ValueChanged);
            // 
            // numericCodigo
            // 
            this.numericCodigo.AccessibleName = "numericCodigo";
            this.numericCodigo.Location = new System.Drawing.Point(53, 7);
            this.numericCodigo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCodigo.Name = "numericCodigo";
            this.numericCodigo.Size = new System.Drawing.Size(116, 20);
            this.numericCodigo.TabIndex = 28;
            this.numericCodigo.ValueChanged += new System.EventHandler(this.numericCodigo_ValueChanged);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.AccessibleName = "textBoxMarca";
            this.textBoxMarca.Location = new System.Drawing.Point(53, 51);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(116, 20);
            this.textBoxMarca.TabIndex = 29;
            this.textBoxMarca.TextChanged += new System.EventHandler(this.textBoxMarca_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.AccessibleName = "textBoxPrecio";
            this.textBoxPrecio.Location = new System.Drawing.Point(53, 96);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(116, 20);
            this.textBoxPrecio.TabIndex = 30;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // AplicacionABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 210);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.numericCodigo);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.labelFilas);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNuevo);
            this.Name = "AplicacionABM";
            this.Text = "AplicacionABM";
            this.Load += new System.EventHandler(this.AplicacionABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelFilas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericCodigo;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}

