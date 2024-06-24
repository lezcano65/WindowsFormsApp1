using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.business
{

    public class control
    {
        public static void ControlClave(KeyPressEventArgs e, string cadena, ErrorProvider error, TextBox caja)
        {

        }
        public static void ControlUsuario(KeyPressEventArgs e, string cadena)
        {
            int contador = 0;
            bool bandera = false;
            String Caracter = "";
            if (cadena.Length >= 8)
                for (int i = 0; i < cadena.Length; i++)
                {
                    Caracter = cadena.Substring(i, 1);
                    if (Caracter == ".") contador++;
                }
            if (contador == 0)//no existe un punto
            {
                bandera = true;
                if (e.KeyChar == '.' && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
        }
        public static void comboEnter(object sender, EventArgs e, Panel Container)
        {
            ComboBox txt = sender as ComboBox;
            foreach (Control ctrl in Container.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                if (ctrl is Label
                    && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }
        public static void txtEnter(object sender, EventArgs e, Panel Container)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in Container.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                if (ctrl is Label
                    && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }
        public static void DejarCombo(object sender, EventArgs e, Panel Container)
        {
            ComboBox txt = sender as ComboBox;
            foreach (Control ctrl in Container.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.Black;
                    }
                }
                if (ctrl is Label
                    && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }
            }
        }
        public static void Dejar(object sender, EventArgs e, Panel Container)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in Container.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.Black;
                    }
                }
                if (ctrl is Label
                    && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }
            }
        }
        public static FormWindowState ButtonMax_Click(object sender, EventArgs e, FormWindowState estado)
        {
            if (estado == FormWindowState.Normal)
                estado = FormWindowState.Maximized;
            else if (estado == FormWindowState.Maximized)
                estado = FormWindowState.Normal;
            return estado;
        }
        public static FormWindowState ButtonMin_Click(object sender, EventArgs e, FormWindowState estado)
        {
            if (estado == FormWindowState.Normal)
                estado = FormWindowState.Minimized;
            else if (estado == FormWindowState.Minimized)
                estado = FormWindowState.Normal;
            return estado;

        }
        public static void unPunto(KeyPressEventArgs e, string cadena, bool bandera)
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
                if (e.KeyChar == '.' && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
        }
        public static void Numero(KeyPressEventArgs e, string cadena, bool bandera)
        {
            int contador = 1;
            String Caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                Caracter = cadena.Substring(i, 1);
                if (Caracter == ".") contador++;
            }
            if (contador == 0)//no existe un punto
            {
                bandera = true;
                if (e.KeyChar == '.' && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                else if (char.IsControl(e.KeyChar)) e.Handled = false;
                else e.Handled = true;
            }
        }
        public static void FillComboBox(string connectionString, string query, ComboBox comboBox1)
        {
            //leer  una secuencia de filas dentro de una talbla de sql
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                //string query = "Select * from Productos";
                
                //nos devuelve el string de conexion a sql
                con = Conexion.CrearInstancia().CrearConexion();
                con.Open();
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    comboBox1.Items.Add(lector.GetInt32(0).ToString());
                }    
                //return Tabla;
            }
            finally
            {
                // por estar dentro de un try en TEORIA no hace falta
                if (con.State == ConnectionState.Open) con.Close();
            }
            
        }
        /*
        public static void FillComboBox(string connectionString, string query, ComboBox comboBox)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    // Limpiar el ComboBox antes de llenarlo
                    comboBox.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["CategoriaId"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        */
        public static void MensajeError(object sender, EventArgs e, Panel Container)
        {
            if (Container.Text == string.Empty)
            {
                TextBox txt = sender as TextBox;
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl is PictureBox
                        && ctrl.Name == "pb" + txt.Tag.ToString())
                    {
                        if (txt.Text == string.Empty)
                        {
                            ctrl.BackColor = Color.Red;
                        }
                        else
                        {
                            ctrl.BackColor = Color.Black;
                        }
                    }
                    if (ctrl is Label
                        && ctrl.Name == "lbl" + txt.Tag.ToString())
                    {
                        if (txt.Text == string.Empty)
                        {
                            ctrl.ForeColor = Color.Red;
                        }
                        else
                        {
                            ctrl.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }
    }
}
