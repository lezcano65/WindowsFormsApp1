using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Conexion
    {
        public string Base;
        public string Servidor;
        public string Usuario;
        public string Clave;
        //nos permite esteblecer el metodo de autenticacion en SQL
        public bool Seguridad;
        // crea un obj de tipo conexion nos sirve para compartit y realizar la conexion
        public static Conexion con = null;
        public Conexion() 
        { 
            this.Base = "aplicacionBD";
            this.Servidor = "DESKTOP-0K564JG";
            this.Usuario = "sa";
            this.Clave = "contrasenia1";
            this.Seguridad = true;
        }
        // metodo para devolver el string de conexion 
        public SqlConnection CrearConexion()
        {
            //variable del tipo sql connection
            SqlConnection cadena = new SqlConnection();
            try
            {
                //crear la cadena de conexion
                cadena.ConnectionString = "Server =" + this.Servidor + "; Database=" + this.Base + ";";
                //validar el tipo de seguridad
                if (this.Seguridad)
                {
                    // es el metodo a travez de windows
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;//muestra el error por consola
            }
            return cadena;
        }
        //crear un metodo para generar una instancia al constructor
        //de la clase para poder asignar la variables
        public static Conexion CrearInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
