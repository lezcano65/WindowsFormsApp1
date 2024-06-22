﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void comboEnter(object sender,EventArgs e,Panel Container)
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
        public static void DejarCombo(object sender, EventArgs e,Panel Container)
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
        /*public static void prueba(object sender, EventArgs e,Form numericCodigo) 
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
                    this.MensajeOk("Se actualizo de forma correcta el registro codigo: " + obj.PCodigo.ToString());
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
        }*/
    }
}
