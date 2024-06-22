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

namespace ABMaplicacion
{
    public partial class AplicacionABM : Form
    {
        private void AplicacionABM_Load(object sender, EventArgs e)
        {
            //llamar a listar 
            listar();
            formato();
        }
        public AplicacionABM()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            string prueba = dataGridViewList.CurrentRow.Cells["pCodigo"].Value.ToString();
            numericCodigo.Value = Convert.ToInt32(prueba);
            prueba = dataGridViewList.CurrentRow.Cells["pPrecio"].Value.ToString();
            prueba = prueba.Replace(',', '.');
            textBoxPrecio.Text = prueba;
            prueba = dataGridViewList.CurrentRow.Cells["pCantidad"].Value.ToString();
            numericCantidad.Value = Convert.ToInt32(prueba);
            textBoxDetalle.Text = dataGridViewList.CurrentRow.Cells["pDetalle"].Value.ToString();
            textBoxMarca.Text = dataGridViewList.CurrentRow.Cells["pMarca"].Value.ToString();
            prueba = dataGridViewList.CurrentRow.Cells["pFecha"].Value.ToString();
            if (DateTime.TryParse(prueba, out DateTime fecha))
            {
                dateTimePickerFecha.Value = fecha;
            }
            else
            {
                dateTimePickerFecha.Value = DateTime.Today;
            }

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
                labelFilas.Text = "Numero de Registros: "+ Convert.ToString(dataGridViewList.Rows.Count-1 );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace) ;
            }
        }
        //motodo para darle formato
        private void formato()
        {
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
                labelFilas.Text = "Numero de filas: " + Convert.ToString(dataGridViewList.Rows.Count - 1);
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
            textBoxDetalle.Clear();
            textBoxBuscar.Clear();
            textBoxMarca.Clear();
            numericCantidad.Value = 0;
            numericCodigo.Value = 0;
            textBoxPrecio.Clear() ;
            textBoxBuscar.Focus();
            errorProvider1.Clear();
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
                if (numericCodigo.Text == "0")
                { 
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(numericCodigo, "Ingrese el codigo");
                    return;
                }
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
                obj.PCodigo = Convert.ToInt32(numericCodigo.Value);
                obj.PDetalle = textBoxDetalle.Text;
                obj.PCantidad = Convert.ToInt32(numericCantidad.Value);
                obj.PMarca = textBoxMarca.Text;
                obj.PPrecio = textBoxPrecio.Text;
                obj.PFecha = dateTimePickerFecha.Value;
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
                if (numericCodigo.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(numericCodigo, "Ingrese el codigo");
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
                    respuesta = ds.Eliminar(Convert.ToInt32(numericCodigo.Value));
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
        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFecha.MaxDate = DateTime.Today;
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (numericCodigo.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(numericCodigo, "Ingrese el codigo");
                    return;
                }
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
                obj.PCodigo = Convert.ToInt32(numericCodigo.Value);
                obj.PDetalle = textBoxDetalle.Text;
                obj.PCantidad = Convert.ToInt32(numericCantidad.Value);
                obj.PMarca = textBoxMarca.Text;
                obj.PPrecio = textBoxPrecio.Text;
                obj.PFecha = dateTimePickerFecha.Value;
                //generar instancia sql
                AccesoDatos ds = new AccesoDatos();
                respuesta = ds.Actualizar(obj);
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("Se actualizo de forma correcta el registro codigo: "+ obj.PCodigo.ToString());
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
        bool bandera = false;
        public void unPunto(KeyPressEventArgs e, string cadena)
        {
            int contador = 0;
            String Caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                Caracter = cadena.Substring(i, 1);
                if (Caracter == ".") contador++;
            }
            if (contador == 0)//no existe un punto
            {
                bandera = true;
                if (e.KeyChar == '.'&& bandera)
                {
                    bandera= false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled= false;
                else e.Handled = true;
            }
            else 
            { 
                bandera = false; 
                e.Handled= true;
                if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
                        
        }
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            unPunto(e, textBoxPrecio.Text);
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
    }
}
