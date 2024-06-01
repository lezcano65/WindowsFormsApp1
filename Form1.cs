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
                labelFilas.Text = "Numero de filas: "+ Convert.ToString(dataGridViewList.Rows.Count);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace) ;
            }

        }

        
    }
}
