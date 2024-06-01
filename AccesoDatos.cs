﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{

    internal class AccesoDatos
    {
        /*
        OleDbCommand pComando;
        OleDbConnection pConexion;
        OleDbDataReader pLector;
        DataTable pTabla;
        string pCadenaConexion;

        public AccesoDatos(string pCadenaConexion)
        {
            this.pComando = new OleDbCommand();
            this.pConexion = new OleDbConnection(pCadenaConexion);
            this.pLector = null;
            this.pTabla = new DataTable();
            this.pCadenaConexion = pCadenaConexion;
        }
        public AccesoDatos() 
        {
            this.pComando = new OleDbCommand();
            this.pConexion = new OleDbConnection();
            this.pLector = null;
            this.pTabla = new DataTable();
            this.pCadenaConexion = "";
        }

        public OleDbCommand PComando { get => pComando; set => pComando = value; }
        public OleDbConnection PConexion { get => pConexion; set => pConexion = value; }
        public OleDbDataReader PLector { get => pLector; set => pLector = value; }
        public DataTable PTabla { get => pTabla; set => pTabla = value; }
        public string PCadenaConexion { get => pCadenaConexion; set => pCadenaConexion = value; }

        public void connectar() 
        {
            pConexion.ConnectionString = pCadenaConexion;
            pConexion.Open();
            pComando.Connection = pConexion;
            pComando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            pConexion.Close();
            pConexion.Dispose();
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            connectar();
            pComando.CommandText = "select * from " + nombreTabla;
            pTabla = new DataTable();
            pTabla.Load(pComando.ExecuteReader());
            desconectar();
            return pTabla;
        }
        public DataTable consultarBD(string consultaSQL)
        {
            connectar();
            pComando.CommandText = consultaSQL;
            pTabla = new DataTable();
            pTabla.Load(pComando.ExecuteReader());
            desconectar();
            return pTabla;
        }
        public void leerTabla(string nombreTabla)
        {
            connectar();
            pComando.CommandText = "select * from " + nombreTabla;
            pLector = pComando.ExecuteReader();
        }
        public void actualizarBD(string consultaSQL)
        {
            connectar();
            pComando.CommandText = consultaSQL;
            pComando.ExecuteNonQuery();
            desconectar();
        }
        */
        public DataTable listar()
        {
            //leer  una secuencia de filas dentro de una talbla de sql
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            //debemos conectarnos a la base de datos
            SqlConnection con = new SqlConnection();
            try {
                string query = "Select * from Producto";
                //nos devuelve el string de conexion a sql
                con = conexion.crearInstancia().crearConexion();
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
                string query = "Select * from Producto where pDetalle like '%' + '"+valor+"'+ '%' or pMarca like '%' + '"+valor+"'+ '%'";

                //nos devuelve el string de conexion a sql
                con = conexion.crearInstancia().crearConexion();
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
                string query = "Insert into Producto (pCodigo,pDetalle,pTipo,pMarca,pPrecio,pFecha) values(" +
                    "'" + obj.PCodigo + "'," +
                    "'" +obj.PDetalle+"'," +
                    "'"+obj.PTipo+"'," +
                    "'"+obj.PMarca+"'," +
                    "'"+obj.PPrecio+"'," +
                    "'"+obj.PFecha.Date + "')";
                //nos devuelve el string de conexion a sql
                con = conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open();
                //en 1 sola linea la exepcion
                respuesta = comando.ExecuteNonQuery() == 1 ?"OK":"No se pudo ingresar el registro";
                /*
                 if (comando.ExecuteNonQuery()==1)
                {
                    respuesta= "OK";
                }
                else
                {
                    respuesta = "No se pudo ingresar el registro"
                }
                 */

            }
            catch (Exception ex)
            {
                respuesta=ex.Message;
                //throw ex;
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
                string query = "Update Producto set pCodigo = '"+obj.PCodigo+"', pDetalle = " +
                    "'"+obj.PDetalle+"', pMarca = " +
                    "'"+obj.PMarca+"', pPrecio = " +
                    "'"+obj.PPrecio+"', pFecha = " +
                    "'"+obj.PFecha+ "' where  pCodigo = '"+obj.PCodigo+"'";
                //nos devuelve el string de conexion a sql
                con = conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(query, con);
                con.Open();
                //en 1 sola linea la exepcion
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
                
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                //throw ex;
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
