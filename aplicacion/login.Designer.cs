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
            this.buttonInicio = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelClave = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.AccessibleName = "buttonInicio";
            this.buttonInicio.Location = new System.Drawing.Point(60, 97);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 23);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "iniciar";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AccessibleName = "labelUsuario";
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsuario.Location = new System.Drawing.Point(6, 19);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(41, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "usuario";
            this.labelUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelClave
            // 
            this.labelClave.AccessibleName = "labelClave";
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(6, 54);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(33, 13);
            this.labelClave.TabIndex = 2;
            this.labelClave.Text = "clave";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.AccessibleName = "textBoxUsuario";
            this.textBoxUsuario.Location = new System.Drawing.Point(47, 16);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(141, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxClave
            // 
            this.textBoxClave.AccessibleName = "textBoxClave";
            this.textBoxClave.Location = new System.Drawing.Point(47, 51);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(141, 20);
            this.textBoxClave.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 132);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonInicio);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxClave;
    }
}