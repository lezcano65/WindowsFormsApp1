namespace WindowsFormsApp1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pContainerUsuario = new System.Windows.Forms.Panel();
            this.ButtonCerrar = new WindowsFormsApp1.aplicacion.RJButton();
            this.ButtonMax = new WindowsFormsApp1.aplicacion.RJButton();
            this.ButtonMin = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton2 = new WindowsFormsApp1.aplicacion.RJButton();
            this.rjButton1 = new WindowsFormsApp1.aplicacion.RJButton();
            this.lblClave = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbClave = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pContainerUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AccessibleName = "lblUsuario";
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(130, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pContainerUsuario
            // 
            this.pContainerUsuario.BackColor = System.Drawing.Color.Wheat;
            this.pContainerUsuario.Controls.Add(this.ButtonCerrar);
            this.pContainerUsuario.Controls.Add(this.ButtonMax);
            this.pContainerUsuario.Controls.Add(this.ButtonMin);
            this.pContainerUsuario.Controls.Add(this.rjButton2);
            this.pContainerUsuario.Controls.Add(this.rjButton1);
            this.pContainerUsuario.Controls.Add(this.lblClave);
            this.pContainerUsuario.Controls.Add(this.lblUsuario);
            this.pContainerUsuario.Controls.Add(this.textBox2);
            this.pContainerUsuario.Controls.Add(this.textBox1);
            this.pContainerUsuario.Controls.Add(this.PictureBox3);
            this.pContainerUsuario.Controls.Add(this.pbClave);
            this.pContainerUsuario.Controls.Add(this.pictureBox1);
            this.pContainerUsuario.Controls.Add(this.pbUsuario);
            this.pContainerUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainerUsuario.Location = new System.Drawing.Point(0, 0);
            this.pContainerUsuario.Name = "pContainerUsuario";
            this.pContainerUsuario.Size = new System.Drawing.Size(328, 202);
            this.pContainerUsuario.TabIndex = 8;
            this.pContainerUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainerUsuario_Paint);
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
            this.ButtonCerrar.Location = new System.Drawing.Point(278, 0);
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
            this.ButtonMax.Location = new System.Drawing.Point(226, 0);
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
            this.ButtonMin.Location = new System.Drawing.Point(172, 0);
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
            this.rjButton2.Location = new System.Drawing.Point(195, 157);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(111, 28);
            this.rjButton2.TabIndex = 2;
            this.rjButton2.Text = "mostrar clave";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
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
            this.rjButton1.Location = new System.Drawing.Point(14, 157);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(111, 28);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "ingresar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // lblClave
            // 
            this.lblClave.AccessibleName = "lblUsuario";
            this.lblClave.AutoSize = true;
            this.lblClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(137, 99);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(46, 19);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "clave";
            this.lblClave.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Wheat;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(20, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 17);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "Clave";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox2.Enter += new System.EventHandler(this.txtEnter);
            this.textBox2.Leave += new System.EventHandler(this.txtLeave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 17);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "Usuario";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.Enter += new System.EventHandler(this.txtEnter);
            this.textBox1.Leave += new System.EventHandler(this.txtLeave);
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Wheat;
            this.PictureBox3.Location = new System.Drawing.Point(15, 109);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(291, 40);
            this.PictureBox3.TabIndex = 1;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbClave
            // 
            this.pbClave.BackColor = System.Drawing.Color.Black;
            this.pbClave.Location = new System.Drawing.Point(13, 107);
            this.pbClave.Name = "pbClave";
            this.pbClave.Size = new System.Drawing.Size(295, 44);
            this.pbClave.TabIndex = 1;
            this.pbClave.TabStop = false;
            this.pbClave.Tag = "Usuario";
            this.pbClave.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Location = new System.Drawing.Point(15, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.Black;
            this.pbUsuario.Location = new System.Drawing.Point(13, 50);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(295, 44);
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            this.pbUsuario.Tag = "Usuario";
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(328, 202);
            this.Controls.Add(this.pContainerUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pContainerUsuario.ResumeLayout(false);
            this.pContainerUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pContainerUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox pbClave;
        private aplicacion.RJButton rjButton1;
        private aplicacion.RJButton rjButton2;
        private aplicacion.RJButton ButtonCerrar;
        private aplicacion.RJButton ButtonMax;
        private aplicacion.RJButton ButtonMin;
    }
}