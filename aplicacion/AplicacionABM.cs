using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Globalization;
using WindowsFormsApp1;
using WindowsFormsApp1.business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ABMaplicacion
{
    public partial class AplicacionABM : Form
    {
        private void AplicacionABM_Load(object sender, EventArgs e)
        {
            //llamar a listar 
            listar();
            formato();
            string connectionString = "Data Source=server_name;Initial Catalog=database_name;User ID=username;Password=password";

            // Consulta SQL para obtener los datos
            string query = "SELECT * FROM Categorias";

            // Llamar al método para llenar el ComboBox
            control.FillComboBox(connectionString, query,textBoxCategoriaFk);
        }
        public AplicacionABM()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            string prueba = dataGridViewList.CurrentRow.Cells["ProductoId"].Value.ToString();
            textBoxProductoId.Text = prueba;
            textBoxNombreP.Text = dataGridViewList.CurrentRow.Cells["NombreP"].Value.ToString();
            prueba = dataGridViewList.CurrentRow.Cells["Habilitado"].Value.ToString();
            textBoxHabilitado.Text = prueba;
            prueba = dataGridViewList.CurrentRow.Cells["CantidadP"].Value.ToString();
            textBoxCantidad.Text = prueba;
            prueba = dataGridViewList.CurrentRow.Cells["CategoriaFk"].Value.ToString();
            textBoxCategoriaFk.Text = prueba;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listar()
        {
            try
            {
                //refenrecia a la clase datos sql
                //datosSql ds = new datosSql();
                AccesoDatos ds = new AccesoDatos();
                dataGridViewList.DataSource = ds.Listar();
                labelFilas.Text = "Numero de Registros: "+ Convert.ToString(dataGridViewList.Rows.Count );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace) ;
            }
        }
        //motodo para darle formato
        private void formato()
        {
            dataGridViewList.Columns[0].Width = 50;
            dataGridViewList.Columns[1].Width = 200;
        }
        //buscar metodo
        private void buscar()
        {
            try
            {
                //refenrecia a la clase datos sql
                //datosSql ds = new datosSql();
                AccesoDatos ds = new AccesoDatos();
                dataGridViewList.DataSource = ds.Buscar(textBoxBuscar.Text);
                labelFilas.Text = "Numero de filas: " + Convert.ToString(dataGridViewList.Rows.Count );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //llamar al metodo buscar
            this.buscar();
        }
        private void Limpiar()
        {
            textBoxProductoId.Text = "";
            textBoxNombreP.Clear();
            textBoxBuscar.Clear();
            textBoxCantidad.Clear();
            //textBoxCategoriaFk.Text = string.Empty;
            //textBoxHabilitado.Text = string.Empty;
            dataGridViewList.Focus();
            errorProvider1.Clear();
            pbBuscar.BackColor = Color.Black;
            lblBuscar.ForeColor = Color.Black;
            pbCantidad.BackColor = Color.Black;
            lblCantidad.ForeColor = Color.Black;
            pbProductoId.BackColor = Color.Black;
            lblProductoId.ForeColor = Color.Black;
            pbHabilitado.BackColor = Color.Black;
            lblHabilitado.ForeColor = Color.Black;
            pbCategoriaFk.BackColor = Color.Black;
            lblCategoriaFk.ForeColor = Color.Black;
            pbNombreP.BackColor = Color.Black;
            lblNombreP.ForeColor = Color.Black;
        }
        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        //metodo para control de mensajes de errores
        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Control de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                
                if (textBoxDetalle.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(textBoxDetalle, "Ingrese el detalle");
                    return;
                }
                if (textBoxMarca.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(textBoxMarca, "Ingrese la marca ");
                    return;
                }
                if (textBoxPrecio.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(textBoxPrecio, "Ingrese el precio");
                    return;
                }
                // generar una instancia a clase producto
                Producto obj = new Producto();
                obj.ProductoId1 = Convert.ToInt32(textBoxProductoId.Text);
                obj.NombreP1 = textBoxNombreP.Text;
                bool success = bool.TryParse(textBoxDetalle.Text, out bool result);
                if (success)
                {
                    obj.Habilitado1=result; 
                }
                try
                {
                    int number = int.Parse(textBoxMarca.Text);
                    obj.CategoriaFk1 = number;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número es demasiado grande o demasiado pequeño para un int.");
                }
                try
                {
                    int number = int.Parse(textBoxPrecio.Text);
                    obj.CantidadP1 = number;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número es demasiado grande o demasiado pequeño para un int.");
                }
                //generar instancia sql
                AccesoDatos ds = new AccesoDatos();
                respuesta = ds.Insertar(obj);
                if (respuesta.Equals("OK"))  
                {
                    this.MensajeOk("Se inserto de forma correcta el registro");
                    this.Limpiar();
                    this.listar();
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxProductoId.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(textBoxProductoId, "Ingrese el codigo");
                    return;
                }
                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Realmente desea eliminar el registro","Registros",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK) 
                {
                    //enviar la info a la clase AccesoDatos
                    AccesoDatos ds = new AccesoDatos();
                    respuesta = ds.Eliminar(Convert.ToInt32(textBoxProductoId.Text));
                }
                if (respuesta.Equals("OK")) 
                {
                    this.MensajeOk("Se elimino de forma correcta el registro codigo: " + numericCodigo.Value);
                    this.Limpiar();
                    this.listar();
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (textBoxProductoId.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(numericCodigo, "Ingrese el codigo");
                    return;
                }
                if (textBoxNombreP.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(textBoxDetalle, "Ingrese el detalle");
                    return;
                }
                if (textBoxMarca.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(textBoxMarca, "Ingrese la marca ");
                    return;
                }
                // generar una instancia a clase producto
                Producto obj = new Producto();
                obj.ProductoId1 = Convert.ToInt32(textBoxProductoId.Text);
                obj.NombreP1 = textBoxNombreP.Text;
                //obj.Habilitado1 = bool.Parse(textBoxHabilitado.Text);
                //bool success = bool.TryParse(textBoxHabilitado.Text, out bool result);
                //if (success)
                //{
                //    Console.WriteLine(result); // Salida: True
                //}
                //obj.CategoriaFk1 = Convert.ToInt32(textBoxCategoriaFk.Text);
                obj.CantidadP1 = Convert.ToInt32(textBoxCantidad.Text);
                //generar instancia sql
                AccesoDatos ds = new AccesoDatos();
                respuesta = ds.Actualizar(obj);
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("Se actualizo de forma correcta el registro codigo: "+ obj.ProductoId1.ToString());
                    this.Limpiar();
                    this.listar();
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void numericTipo_ValueChanged(object sender, EventArgs e)
        {

        }
        private void labelMarca_Click(object sender, EventArgs e)
        {

        }
        private void labelDetalle_Click(object sender, EventArgs e)
        {

        }
        private void textBoxMarca_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
                        
        }
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool flag = true;
            control.unPunto(e, textBoxPrecio.Text,flag);
        }
        private void numericCodigo_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBoxDetalle_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelFecha_Click(object sender, EventArgs e)
        {

        }
        private void labelPrecio_Click(object sender, EventArgs e)
        {

        }
        private void labelCantidad_Click(object sender, EventArgs e)
        {

        }
        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }
        private void ButtonMin_Click(object sender, EventArgs e)
        {
            control.ButtonMin_Click(sender, e,WindowState);
        }
        private void ButtonMax_Click(object sender, EventArgs e)
        {
            control.ButtonMax_Click(sender, e,WindowState);
        }
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtLeave(object sender, EventArgs e)
        {
            control.Dejar(sender, e, pContainerUsuario);
        }
        private void textBoxProductoId_TextChanged(object sender, EventArgs e)
        {

        }
        private void pContainerUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtEnter(object sender, EventArgs e)
        {
            control.txtEnter(sender, e, pContainerUsuario);
        }

        private void textBoxProductoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool flag = true;
            control.unPunto(e, textBoxProductoId.Text, flag);
        }

        private void comboEnter(object sender, EventArgs e)
        {
            control.comboEnter(sender, e, pContainerUsuario);   
        }

        private void ComboLeave(object sender, EventArgs e)
        {
            control.DejarCombo(sender, e, pContainerUsuario);
        }

        private void textBoxHabilitado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCategoriaFk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
