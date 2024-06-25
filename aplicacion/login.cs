using ABMaplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        AplicacionABM formularioAplicacionABM;
        public login()
        {
            InitializeComponent();
            formularioAplicacionABM = new AplicacionABM();  
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void login_Load(object sender, EventArgs e)
        {

        }
        public void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtEnter(object sender, EventArgs e)
        {
            control.txtEnter(sender, e, pContainerUsuario);
        }
        private void txtLeave(object sender, EventArgs e)
        {
            control.Dejar(sender,e, pContainerUsuario);
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void pbUsuario_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pContainerUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
            rjButton2.Text = textBox2.UseSystemPasswordChar == false ? "ocultar clave" : "mostrar clave";
        }
        private void ButtonMax_Click(object sender, EventArgs e)
        {
            WindowState=control.ButtonMax_Click(sender, e, WindowState);
        }
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonMin_Click(object sender, EventArgs e)
        {
            WindowState=control.ButtonMin_Click(sender, e, WindowState);
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {

            formularioAplicacionABM.ShowDialog();
        }
    }
}
