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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AplicacionABM));
            this.textBoxHabilitado = new System.Windows.Forms.ComboBox();
            this.textBoxCategoriaFk = new System.Windows.Forms.ComboBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelFilas = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pContainerUsuario = new System.Windows.Forms.Panel();
            this.lblCategoriaFk = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.textBoxNombreP = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxProductoId = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbCategoriaFk = new System.Windows.Forms.PictureBox();
            this.pbNombreP = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbHabilitado = new System.Windows.Forms.PictureBox();
            this.pbCantidad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbProductoId = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCerrar = new WindowsFormsApp1.aplicacion.RJButton();
            this.ButtonMax = new WindowsFormsApp1.aplicacion.RJButton();
            this.ButtonMin = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton2 = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton5 = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton4 = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton3 = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton1 = new WindowsFormsApp1.aplicacion.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pContainerUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoriaFk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHabilitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductoId)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHabilitado
            // 
            this.textBoxHabilitado.AccessibleName = "textBoxHabilitado";
            this.textBoxHabilitado.BackColor = System.Drawing.Color.Wheat;
            this.textBoxHabilitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxHabilitado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textBoxHabilitado.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHabilitado.FormattingEnabled = true;
            this.textBoxHabilitado.Items.AddRange(new object[] {
            "True",
            "False"});
            this.textBoxHabilitado.Location = new System.Drawing.Point(348, 181);
            this.textBoxHabilitado.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHabilitado.Name = "textBoxHabilitado";
            this.textBoxHabilitado.Size = new System.Drawing.Size(86, 25);
            this.textBoxHabilitado.TabIndex = 4;
            this.textBoxHabilitado.Tag = "Habilitado";
            this.textBoxHabilitado.SelectedIndexChanged += new System.EventHandler(this.textBoxHabilitado_SelectedIndexChanged);
            this.textBoxHabilitado.Enter += new System.EventHandler(this.comboEnter);
            this.textBoxHabilitado.Leave += new System.EventHandler(this.ComboLeave);
            // 
            // textBoxCategoriaFk
            // 
            this.textBoxCategoriaFk.AccessibleName = "textBoxCategoriaFk";
            this.textBoxCategoriaFk.BackColor = System.Drawing.Color.Wheat;
            this.textBoxCategoriaFk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxCategoriaFk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textBoxCategoriaFk.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategoriaFk.FormattingEnabled = true;
            this.textBoxCategoriaFk.Location = new System.Drawing.Point(467, 181);
            this.textBoxCategoriaFk.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCategoriaFk.Name = "textBoxCategoriaFk";
            this.textBoxCategoriaFk.Size = new System.Drawing.Size(106, 25);
            this.textBoxCategoriaFk.TabIndex = 4;
            this.textBoxCategoriaFk.Tag = "CategoriaFk";
            this.textBoxCategoriaFk.SelectedIndexChanged += new System.EventHandler(this.textBoxCategoriaFk_SelectedIndexChanged);
            this.textBoxCategoriaFk.Enter += new System.EventHandler(this.comboEnter);
            this.textBoxCategoriaFk.Leave += new System.EventHandler(this.ComboLeave);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AccessibleName = "dataGridViewList";
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Wheat;
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewList.EnableHeadersVisualStyles = false;
            this.dataGridViewList.GridColor = System.Drawing.Color.Wheat;
            this.dataGridViewList.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Wheat;
            this.dataGridViewList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(700, 111);
            this.dataGridViewList.TabIndex = 21;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.AccessibleDescription = "textBoxBuscar";
            this.textBoxBuscar.AccessibleName = "textBoxBuscar";
            this.textBoxBuscar.BackColor = System.Drawing.Color.Wheat;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscar.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(348, 247);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(231, 17);
            this.textBoxBuscar.TabIndex = 23;
            this.textBoxBuscar.Tag = "Buscar";
            this.textBoxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxBuscar.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxBuscar.Leave += new System.EventHandler(this.txtLeave);
            // 
            // labelFilas
            // 
            this.labelFilas.AccessibleName = "labelFilas";
            this.labelFilas.AutoSize = true;
            this.labelFilas.BackColor = System.Drawing.Color.Wheat;
            this.labelFilas.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilas.Location = new System.Drawing.Point(282, 9);
            this.labelFilas.Name = "labelFilas";
            this.labelFilas.Size = new System.Drawing.Size(155, 19);
            this.labelFilas.TabIndex = 24;
            this.labelFilas.Text = "Numero de registros";
            this.labelFilas.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pContainerUsuario
            // 
            this.pContainerUsuario.AutoSize = true;
            this.pContainerUsuario.BackColor = System.Drawing.Color.Wheat;
            this.pContainerUsuario.Controls.Add(this.textBoxBuscar);
            this.pContainerUsuario.Controls.Add(this.label2);
            this.pContainerUsuario.Controls.Add(this.label1);
            this.pContainerUsuario.Controls.Add(this.labelFilas);
            this.pContainerUsuario.Controls.Add(this.dataGridViewList);
            this.pContainerUsuario.Controls.Add(this.textBoxCategoriaFk);
            this.pContainerUsuario.Controls.Add(this.textBoxHabilitado);
            this.pContainerUsuario.Controls.Add(this.ButtonCerrar);
            this.pContainerUsuario.Controls.Add(this.ButtonMax);
            this.pContainerUsuario.Controls.Add(this.ButtonMin);
            this.pContainerUsuario.Controls.Add(this.rjButton2);
            this.pContainerUsuario.Controls.Add(this.rjButton5);
            this.pContainerUsuario.Controls.Add(this.rjButton4);
            this.pContainerUsuario.Controls.Add(this.rjButton3);
            this.pContainerUsuario.Controls.Add(this.rjButton1);
            this.pContainerUsuario.Controls.Add(this.lblCategoriaFk);
            this.pContainerUsuario.Controls.Add(this.lblBuscar);
            this.pContainerUsuario.Controls.Add(this.lblNombreP);
            this.pContainerUsuario.Controls.Add(this.lblHabilitado);
            this.pContainerUsuario.Controls.Add(this.lblCantidad);
            this.pContainerUsuario.Controls.Add(this.lblProductoId);
            this.pContainerUsuario.Controls.Add(this.textBoxNombreP);
            this.pContainerUsuario.Controls.Add(this.textBoxCantidad);
            this.pContainerUsuario.Controls.Add(this.textBoxProductoId);
            this.pContainerUsuario.Controls.Add(this.pictureBox7);
            this.pContainerUsuario.Controls.Add(this.pictureBox5);
            this.pContainerUsuario.Controls.Add(this.PictureBox3);
            this.pContainerUsuario.Controls.Add(this.pictureBox4);
            this.pContainerUsuario.Controls.Add(this.pbBuscar);
            this.pContainerUsuario.Controls.Add(this.pbCategoriaFk);
            this.pContainerUsuario.Controls.Add(this.pbNombreP);
            this.pContainerUsuario.Controls.Add(this.pictureBox6);
            this.pContainerUsuario.Controls.Add(this.pbHabilitado);
            this.pContainerUsuario.Controls.Add(this.pbCantidad);
            this.pContainerUsuario.Controls.Add(this.pictureBox1);
            this.pContainerUsuario.Controls.Add(this.pbProductoId);
            this.pContainerUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainerUsuario.Location = new System.Drawing.Point(0, 0);
            this.pContainerUsuario.Name = "pContainerUsuario";
            this.pContainerUsuario.Size = new System.Drawing.Size(719, 295);
            this.pContainerUsuario.TabIndex = 31;
            this.pContainerUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainerUsuario_Paint);
            // 
            // lblCategoriaFk
            // 
            this.lblCategoriaFk.AccessibleName = "lblCategoriaFk";
            this.lblCategoriaFk.AutoSize = true;
            this.lblCategoriaFk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoriaFk.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFk.Location = new System.Drawing.Point(472, 162);
            this.lblCategoriaFk.Name = "lblCategoriaFk";
            this.lblCategoriaFk.Size = new System.Drawing.Size(96, 19);
            this.lblCategoriaFk.TabIndex = 1;
            this.lblCategoriaFk.Text = "CategoriaFk";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AccessibleName = "lblBuscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(434, 224);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(58, 19);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AccessibleName = "lblNombreP";
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreP.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(189, 162);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(77, 19);
            this.lblNombreP.TabIndex = 1;
            this.lblNombreP.Text = "NombreP";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AccessibleName = "lblHabilitado";
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHabilitado.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitado.Location = new System.Drawing.Point(350, 162);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(82, 19);
            this.lblHabilitado.TabIndex = 1;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AccessibleName = "lblCantidad";
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidad.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(618, 162);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProductoId
            // 
            this.lblProductoId.AccessibleName = "lblProductoId";
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductoId.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoId.Location = new System.Drawing.Point(16, 162);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(89, 19);
            this.lblProductoId.TabIndex = 1;
            this.lblProductoId.Text = "ProductoId";
            // 
            // textBoxNombreP
            // 
            this.textBoxNombreP.AccessibleDescription = "textBoxNombreP";
            this.textBoxNombreP.AccessibleName = "textBoxNombreP";
            this.textBoxNombreP.BackColor = System.Drawing.Color.Wheat;
            this.textBoxNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreP.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreP.Location = new System.Drawing.Point(144, 184);
            this.textBoxNombreP.Name = "textBoxNombreP";
            this.textBoxNombreP.Size = new System.Drawing.Size(167, 17);
            this.textBoxNombreP.TabIndex = 0;
            this.textBoxNombreP.Tag = "NombreP";
            this.textBoxNombreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombreP.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxNombreP.Leave += new System.EventHandler(this.txtLeave);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.AccessibleDescription = "textBoxCantidad";
            this.textBoxCantidad.BackColor = System.Drawing.Color.Wheat;
            this.textBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCantidad.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(612, 184);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(85, 17);
            this.textBoxCantidad.TabIndex = 0;
            this.textBoxCantidad.Tag = "Cantidad";
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxProductoId_TextChanged);
            this.textBoxCantidad.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            this.textBoxCantidad.Leave += new System.EventHandler(this.txtLeave);
            // 
            // textBoxProductoId
            // 
            this.textBoxProductoId.AccessibleDescription = "textBoxProductoId";
            this.textBoxProductoId.BackColor = System.Drawing.Color.Wheat;
            this.textBoxProductoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductoId.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductoId.Location = new System.Drawing.Point(12, 184);
            this.textBoxProductoId.Name = "textBoxProductoId";
            this.textBoxProductoId.Size = new System.Drawing.Size(97, 17);
            this.textBoxProductoId.TabIndex = 0;
            this.textBoxProductoId.Tag = "ProductoId";
            this.textBoxProductoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProductoId.TextChanged += new System.EventHandler(this.textBoxProductoId_TextChanged);
            this.textBoxProductoId.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxProductoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductoId_KeyPress);
            this.textBoxProductoId.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox7.Location = new System.Drawing.Point(341, 234);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(244, 40);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox5.Location = new System.Drawing.Point(463, 172);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(114, 40);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Wheat;
            this.PictureBox3.Location = new System.Drawing.Point(139, 172);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(177, 40);
            this.PictureBox3.TabIndex = 1;
            this.PictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox4.Location = new System.Drawing.Point(344, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(94, 40);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.AccessibleName = "pbBuscar";
            this.pbBuscar.BackColor = System.Drawing.Color.Black;
            this.pbBuscar.Location = new System.Drawing.Point(339, 232);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(248, 44);
            this.pbBuscar.TabIndex = 1;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Tag = "Usuario";
            // 
            // pbCategoriaFk
            // 
            this.pbCategoriaFk.AccessibleName = "pbCategoriaFk";
            this.pbCategoriaFk.BackColor = System.Drawing.Color.Black;
            this.pbCategoriaFk.Location = new System.Drawing.Point(461, 170);
            this.pbCategoriaFk.Name = "pbCategoriaFk";
            this.pbCategoriaFk.Size = new System.Drawing.Size(118, 44);
            this.pbCategoriaFk.TabIndex = 1;
            this.pbCategoriaFk.TabStop = false;
            this.pbCategoriaFk.Tag = "ProductoId";
            // 
            // pbNombreP
            // 
            this.pbNombreP.AccessibleName = "pbNombreP";
            this.pbNombreP.BackColor = System.Drawing.Color.Black;
            this.pbNombreP.Location = new System.Drawing.Point(137, 170);
            this.pbNombreP.Name = "pbNombreP";
            this.pbNombreP.Size = new System.Drawing.Size(181, 44);
            this.pbNombreP.TabIndex = 1;
            this.pbNombreP.TabStop = false;
            this.pbNombreP.Tag = "Usuario";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox6.Location = new System.Drawing.Point(607, 172);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(95, 40);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pbHabilitado
            // 
            this.pbHabilitado.AccessibleName = "pbHabilitado";
            this.pbHabilitado.BackColor = System.Drawing.Color.Black;
            this.pbHabilitado.Location = new System.Drawing.Point(342, 170);
            this.pbHabilitado.Name = "pbHabilitado";
            this.pbHabilitado.Size = new System.Drawing.Size(98, 44);
            this.pbHabilitado.TabIndex = 1;
            this.pbHabilitado.TabStop = false;
            this.pbHabilitado.Tag = "ProductoId";
            // 
            // pbCantidad
            // 
            this.pbCantidad.AccessibleName = "pbCantidad";
            this.pbCantidad.BackColor = System.Drawing.Color.Black;
            this.pbCantidad.Location = new System.Drawing.Point(605, 170);
            this.pbCantidad.Name = "pbCantidad";
            this.pbCantidad.Size = new System.Drawing.Size(99, 44);
            this.pbCantidad.TabIndex = 1;
            this.pbCantidad.TabStop = false;
            this.pbCantidad.Tag = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Location = new System.Drawing.Point(7, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbProductoId
            // 
            this.pbProductoId.AccessibleName = "pbProductoId";
            this.pbProductoId.BackColor = System.Drawing.Color.Black;
            this.pbProductoId.Location = new System.Drawing.Point(5, 170);
            this.pbProductoId.Name = "pbProductoId";
            this.pbProductoId.Size = new System.Drawing.Size(111, 44);
            this.pbProductoId.TabIndex = 1;
            this.pbProductoId.TabStop = false;
            this.pbProductoId.Tag = "ProductoId";
            // 
            // label1
            // 
            this.label1.AccessibleName = "labelFilas";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Registro seleccionado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.BackgroudColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCerrar.BorderRadius = 18;
            this.ButtonCerrar.BorderSize = 0;
            this.ButtonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCerrar.FlatAppearance.BorderSize = 0;
            this.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCerrar.ForeColor = System.Drawing.Color.White;
            this.ButtonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCerrar.Image")));
            this.ButtonCerrar.Location = new System.Drawing.Point(669, 0);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(50, 35);
            this.ButtonCerrar.TabIndex = 3;
            this.ButtonCerrar.TextColor = System.Drawing.Color.White;
            this.ButtonCerrar.UseVisualStyleBackColor = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // ButtonMax
            // 
            this.ButtonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMax.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMax.BackgroudColor = System.Drawing.Color.Transparent;
            this.ButtonMax.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonMax.BorderRadius = 18;
            this.ButtonMax.BorderSize = 0;
            this.ButtonMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMax.FlatAppearance.BorderSize = 0;
            this.ButtonMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMax.ForeColor = System.Drawing.Color.White;
            this.ButtonMax.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMax.Image")));
            this.ButtonMax.Location = new System.Drawing.Point(617, 0);
            this.ButtonMax.Name = "ButtonMax";
            this.ButtonMax.Size = new System.Drawing.Size(50, 35);
            this.ButtonMax.TabIndex = 3;
            this.ButtonMax.TextColor = System.Drawing.Color.White;
            this.ButtonMax.UseVisualStyleBackColor = false;
            this.ButtonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMin.BackgroudColor = System.Drawing.Color.Transparent;
            this.ButtonMin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonMin.BorderRadius = 18;
            this.ButtonMin.BorderSize = 0;
            this.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin.ForeColor = System.Drawing.Color.White;
            this.ButtonMin.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMin.Image")));
            this.ButtonMin.Location = new System.Drawing.Point(563, 0);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(50, 35);
            this.ButtonMin.TabIndex = 3;
            this.ButtonMin.TextColor = System.Drawing.Color.White;
            this.ButtonMin.UseVisualStyleBackColor = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Crimson;
            this.rjButton2.BackgroudColor = System.Drawing.Color.Crimson;
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 19;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(12, 251);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(61, 28);
            this.rjButton2.TabIndex = 2;
            this.rjButton2.Text = "BORRAR";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton5.BackgroudColor = System.Drawing.Color.MidnightBlue;
            this.rjButton5.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton5.BorderRadius = 19;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(593, 242);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(111, 28);
            this.rjButton5.TabIndex = 2;
            this.rjButton5.Text = "BUSCAR";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton4.BackgroudColor = System.Drawing.Color.MidnightBlue;
            this.rjButton4.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderRadius = 19;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(155, 251);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(61, 28);
            this.rjButton4.TabIndex = 2;
            this.rjButton4.Text = "LIMPIAR";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton3.BackgroudColor = System.Drawing.Color.MidnightBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderRadius = 19;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(83, 251);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(61, 28);
            this.rjButton3.TabIndex = 2;
            this.rjButton3.Text = "EDITAR";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.BackgroudColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 19;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(222, 251);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(61, 28);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "CREAR";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "labelFilas";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "acciones a realizar con los campos rellenos";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // AplicacionABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(719, 295);
            this.Controls.Add(this.pContainerUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AplicacionABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AplicacionABM";
            this.Load += new System.EventHandler(this.AplicacionABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pContainerUsuario.ResumeLayout(false);
            this.pContainerUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoriaFk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHabilitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductoId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelFilas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pContainerUsuario;
        private WindowsFormsApp1.aplicacion.RJButton ButtonCerrar;
        private WindowsFormsApp1.aplicacion.RJButton ButtonMax;
        private WindowsFormsApp1.aplicacion.RJButton ButtonMin;
        private WindowsFormsApp1.aplicacion.RJButton rjButton1;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.TextBox textBoxNombreP;
        private System.Windows.Forms.TextBox textBoxProductoId;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox pbNombreP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbProductoId;
        private WindowsFormsApp1.aplicacion.RJButton rjButton2;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbHabilitado;
        private System.Windows.Forms.Label lblCategoriaFk;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbCategoriaFk;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbCantidad;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.ComboBox textBoxHabilitado;
        private System.Windows.Forms.ComboBox textBoxCategoriaFk;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp1.aplicacion.RJButton rjButton5;
        private WindowsFormsApp1.aplicacion.RJButton rjButton4;
        private WindowsFormsApp1.aplicacion.RJButton rjButton3;
        private System.Windows.Forms.Label label2;
    }
}

