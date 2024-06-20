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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            //llamar a listar 
            listar();
            formato();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            string prueba = dataGridViewList.CurrentRow.Cells["pCodigo"].Value.ToString();
            numericCodigo.Value = Convert.ToInt32(prueba);
            prueba = dataGridViewList.CurrentRow.Cells["pPrecio"].Value.ToString();
            numericPrecio.Value = Convert.ToDecimal(prueba);
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
                dataGridViewList.DataSource = ds.listar();
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
            numericPrecio.Value = 0;
            textBoxBuscar.Focus();
            errorProvider1.Clear();
            
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            //

        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
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
                if (numericPrecio.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(numericPrecio, "Ingrese el precio");
                    return;
                }
                // generar una instancia a clase producto
                Producto obj = new Producto();
                obj.PCodigo = Convert.ToInt32(numericCodigo.Value);
                obj.PDetalle = textBoxDetalle.Text;
                obj.PCantidad = Convert.ToInt32(numericCantidad.Value);
                obj.PMarca = textBoxMarca.Text;
                obj.PPrecio = Convert.ToDouble(numericPrecio.Value);
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
                if (numericPrecio.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos");
                    errorProvider1.SetError(numericPrecio, "Ingrese el precio");
                    return;
                }
                // generar una instancia a clase producto
                Producto obj = new Producto();
                obj.PCodigo = Convert.ToInt32(numericCodigo.Value);
                obj.PDetalle = textBoxDetalle.Text;
                obj.PCantidad = Convert.ToInt32(numericCantidad.Value);
                obj.PMarca = textBoxMarca.Text;
                obj.PPrecio = Convert.ToDouble(numericPrecio.Value);
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
        private void textBoxBuscar_DragEnter(object sender, DragEventArgs e)
        {
            
        }
        private void labelMarca_Click(object sender, EventArgs e)
        {

        }
        private void labelDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}
