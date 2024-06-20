using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        //nos permite esteblecer el metodo de autenticacion en SQL
        private bool Seguridad;
        // crea un obj de tipo conexion nos sirve para compartit y realizar la conexion
        private static conexion con = null;
        private conexion() 
        { 
            this.Base = "aplicacionBD";
            this.Servidor = "DESKTOP-0K564JG";
            this.Usuario = "sa";
            this.Clave = "contrasenia1";
            this.Seguridad = true;
        }
        // metodo para devolver el string de conexion 
        public SqlConnection crearConexion()
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
        public static conexion crearInstancia()
        {
            if (con == null)
            {
                con = new conexion();
            }
            return con;
        }

    }
}
