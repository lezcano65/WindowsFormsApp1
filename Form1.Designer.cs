namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelFilas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.AccessibleName = "buttonNuevo";
            this.buttonNuevo.Location = new System.Drawing.Point(29, 249);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.AccessibleName = "buttonEditar";
            this.buttonEditar.Location = new System.Drawing.Point(121, 249);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.AccessibleName = "buttonBorrar";
            this.buttonBorrar.Location = new System.Drawing.Point(213, 249);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 2;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AccessibleName = "buttonLimpiar";
            this.buttonLimpiar.Location = new System.Drawing.Point(303, 249);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.AccessibleName = "buttonCancelar";
            this.Cancelar.Location = new System.Drawing.Point(396, 249);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.AccessibleName = "buttonSalir";
            this.buttonSalir.Location = new System.Drawing.Point(489, 249);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AccessibleName = "labelCodigo";
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(26, 23);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 7;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelDetalle
            // 
            this.labelDetalle.AccessibleName = "labelDetalle";
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Location = new System.Drawing.Point(26, 57);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(40, 13);
            this.labelDetalle.TabIndex = 8;
            this.labelDetalle.Text = "Detalle";
            // 
            // labelMarca
            // 
            this.labelMarca.AccessibleName = "labelMarca";
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(26, 89);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 9;
            this.labelMarca.Text = "Marca";
            // 
            // labelTipo
            // 
            this.labelTipo.AccessibleName = "labelTipo";
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(26, 125);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 10;
            this.labelTipo.Text = "Tipo";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AccessibleName = "labelPrecio";
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(29, 168);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "Precio";
            // 
            // labelFecha
            // 
            this.labelFecha.AccessibleName = "labelFecha";
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(26, 208);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.AccessibleName = "textBoxCodigo";
            this.textBoxCodigo.Location = new System.Drawing.Point(80, 21);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(181, 20);
            this.textBoxCodigo.TabIndex = 13;
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.AccessibleName = "textBoxDetalle";
            this.textBoxDetalle.Location = new System.Drawing.Point(80, 55);
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(181, 20);
            this.textBoxDetalle.TabIndex = 14;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.AccessibleName = "textBoxPrecio";
            this.textBoxPrecio.Location = new System.Drawing.Point(80, 166);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(181, 20);
            this.textBoxPrecio.TabIndex = 15;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.AccessibleName = "comboBoxMarca";
            this.comboBoxMarca.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxMarca.ForeColor = System.Drawing.Color.White;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(80, 87);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(181, 21);
            this.comboBoxMarca.TabIndex = 17;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.AccessibleName = "dateTimePickerFecha";
            this.dateTimePickerFecha.Location = new System.Drawing.Point(80, 206);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerFecha.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleName = "radioButtonTipoNumero";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(80, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Numero";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleName = "radioButtonTipoString";
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(195, 123);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "String";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AccessibleName = "dataGridViewList";
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(288, 106);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(288, 92);
            this.dataGridViewList.TabIndex = 21;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listViewStock
            // 
            this.listViewStock.AccessibleName = "listViewStock";
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(288, 12);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(288, 58);
            this.listViewStock.TabIndex = 6;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.AccessibleName = "buttonBuscar";
            this.buttonBuscar.Location = new System.Drawing.Point(501, 208);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 22;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.AccessibleName = "textBoxBuscar";
            this.textBoxBuscar.Location = new System.Drawing.Point(288, 210);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(195, 20);
            this.textBoxBuscar.TabIndex = 23;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelFilas
            // 
            this.labelFilas.AccessibleName = "labelFilas";
            this.labelFilas.AutoSize = true;
            this.labelFilas.Location = new System.Drawing.Point(285, 87);
            this.labelFilas.Name = "labelFilas";
            this.labelFilas.Size = new System.Drawing.Size(80, 13);
            this.labelFilas.TabIndex = 24;
            this.labelFilas.Text = "Numero de filas";
            this.labelFilas.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 291);
            this.Controls.Add(this.labelFilas);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelFilas;
    }
}

