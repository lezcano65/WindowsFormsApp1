using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

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
        public string NombreDuplicado(Producto valor)
        {
            string respuesta = "";
            //SqlDataReader lista;
            //DataTable Tabla = new DataTable();
            //debemos conectarnos a la base de datos
            //SqlConnection con = new SqlConnection();
            try
            {
                string query = "Select * from Productos where NombreP = '" + valor.NombreP1;
                //con = Conexion.CrearInstancia().CrearConexion();
                using (SqlConnection con = Conexion.CrearInstancia().CrearConexion())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NombreP", valor.NombreP1);

                    try
                    {
                        con.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            Actualizar(valor);
                            return "El producto ya existe y no se puede crear.";
                        }
                        else
                        {
                            Insertar(valor);
                            return "El producto no existe. Se puede crear.";
                            // Aquí puedes agregar la lógica para crear el producto si es necesario
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //SqlCommand comando = new SqlCommand(query, con);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return respuesta;
        }
        public string Insertar(Producto obj)
        {
            string respuesta = "";
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try
            {
                string query = "Insert into Productos (NombreP,Habilitado,CategoriaFk,CategoriaFkNavigationCategoriaId,CantidadP) values(" +
                    "'" +obj.NombreP1 + "'," +
                    "'"+obj.Habilitado1 + "'," +
                    "'"+obj.CategoriaFk1 + "'," +
                    "'" + obj.CategoriaFk1 + "'," +
                    "'" +obj.CantidadP1 + "')";
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
                string query = "Update Productos set NombreP = " +
                    "'"+obj.NombreP1 + "', Habilitado = " +
                    "'" +obj.Habilitado1 + "', CategoriaFkNavigationCategoriaId = "+
                    "'" + obj.CategoriaFk1 + "', CategoriaFk = " +
                    "'" +obj.CategoriaFk1 + "', CantidadP = " + 
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
