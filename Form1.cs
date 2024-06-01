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

//using Microsof.E 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //const int tam = 5;
        // select * from TABLA where nombre like '%' + var + '%' or apellido like '%' + var + '%'
        //string prueba = "Data Source=DESKTOP-0K564JG;Initial Catalog = aplicacionBD; Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False";
        //AccesoDatos oDatos = new AccesoDatos(@"Data Source=DESKTOP-0K564JG;Initial Catalog = aplicacionBD; Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False");

        //cargar el datagridview

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
            numericPrecio.Value = Convert.ToInt32(prueba);
            prueba = dataGridViewList.CurrentRow.Cells["pTipo"].Value.ToString();
            numericTipo.Value = Convert.ToInt32(prueba);
            textBoxDetalle.Text = dataGridViewList.CurrentRow.Cells["pDetalle"].Value.ToString();
            textBoxMarca.Text = dataGridViewList.CurrentRow.Cells["pMarca"].Value.ToString();
            //prueba = dataGridViewList.CurrentRow.Cells["pFecha"].Value.ToString();
            dateTimePickerFecha.Value = DateTime.Now;



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
                labelFilas.Text = "Numero de filas: "+ Convert.ToString(dataGridViewList.Rows.Count-1 );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace) ;
            }
        }
        //motodo para darle formato
        private void formato()
        {
            dataGridViewList.Columns[0].Visible = false;
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
            numericTipo.Value = 0;
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
                obj.PTipo = Convert.ToInt32(numericTipo.Value);
                obj.PMarca = textBoxMarca.Text;
                obj.PPrecio = Convert.ToDouble(numericPrecio.Value);
                DateTime prueba = dateTimePickerFecha.Value;
                obj.PFecha = prueba.Date;
                //Console.WriteLine(obj.PCodigo +" "+ obj.PFecha);
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

        }
    }
}
