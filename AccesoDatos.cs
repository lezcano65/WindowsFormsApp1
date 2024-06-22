using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AccesoDatos
    {
        public DataTable Listar()
        {
            //leer  una secuencia de filas dentro de una talbla de sql
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try {
                string query = "Select * from Productos";
                //nos devuelve el string de conexion a sql
                con = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open(); 
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;
            } catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                // por estar dentro de un try en TEORIA no hace falta
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        public DataTable Buscar(string valor)
        {
            //leer  una secuencia de filas dentro de una talbla de sql
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string query = "Select * from Productos where NombreP like '%' + '" + valor + "'+ '%'";// or pMarca like '%' + '"+valor+"'+ '%'";
                bool success = int.TryParse(valor, out int number);
                if (success)
                {
                    query += " or ProductoId like '%' + '" + number + "' + '%' or CategoriaFk like '%' + '" + number + "'+ '%'";
                }
                //nos devuelve el string de conexion a sql
                con = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // por estar dentro de un try en TEORIA no hace falta
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        public string Insertar(Producto obj)
        {
            string respuesta = "";
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string query = "Insert into Productos (NombreP,Habilitado,CategoriaFk,CantidadP) values(" +
                    "'" +obj.NombreP1 + "'," +
                    "'"+obj.Habilitado1 + "'," +
                    "'"+obj.CategoriaFk1 + "'," +
                    "'"+obj.CantidadP1 + "')";
                //nos devuelve el string de conexion a sql
                con = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open();
                //en 1 sola linea la exepcion
                respuesta = comando.ExecuteNonQuery() == 1 ?"OK":"No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                respuesta=ex.Message;
            }
            finally
            {
                // por estar dentro de un try en TEORIA no hace falta
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta; 
        }
        //metodo para actualizar
        public string Actualizar(Producto obj)
        {
            string respuesta = "";
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string query = "Update Productos set ProductoId = " +
                    "'"+obj.ProductoId1 + "', NombreP1 = " +
                    "'"+obj.NombreP1 + "', Habilitado = " +
                    "'"+obj.Habilitado1 + "', CategoriaFk = " +
                    "'"+obj.CategoriaFk1 + "', CantidadP = " + //obj.PrecioP1 = " +
                    //"'"+obj.CategoriaFk1 + "', CantidadP = " +
                    "'" + obj.CantidadP1 + "' where  ProductoId = '" + obj.ProductoId1 + "'";
                //nos devuelve el string de conexion a sql
                con = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open();
                //en 1 sola linea la exepcion
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                // por estar dentro de un try en TEORIA no hace falta
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }
        //borrar los registros
        public string Eliminar(int Id)
        {
            string respuesta = "";
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string query = "delete from Productos where ProductoId = '" + Id+"'";
                //nos devuelve el string de conexion a sql
                con = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open();
                //en 1 sola linea la exepcion
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro correctamente verifique que el ID sea correcto";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                // por estar dentro de un try en TEORIA no hace falta
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }
    }
}
