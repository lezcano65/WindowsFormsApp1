using GestionStockWeb.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace GestionStockWeb.Data 
{
    public class ProductosDatos 
    {
        public List<Producto> Listar()
        {
            var oLista = new List<Producto>();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Listar",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader()) 
                {
                    while (dr.Read()) 
                    {
                        oLista.Add(new Producto()
                        {
                            ProductoId = Convert.ToInt32(dr["ProductoId"]),
                            NombreP = dr["NombreP"].ToString(),
                            Habilitado = Convert.ToBoolean(dr["Habilitado"]),
                            CategoriaFk = Convert.ToInt32(dr["CategoriaFk"]),
                            CantidadP = Convert.ToInt32(dr["CantidadP"])
                        }); 
                    }
                }
            }
            return oLista;
        }
        public Producto Obtener(int IdProducto)
        {
            var oProducto = new Producto();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);
                cmd.Parameters.AddWithValue("ProductoId", IdProducto);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oProducto.ProductoId = Convert.ToInt32(dr["ProductoId"]);
                        oProducto.NombreP = dr["NombreP"].ToString();
                        oProducto.Habilitado = Convert.ToBoolean(dr["Habilitado"]);
                        oProducto.CategoriaFk = Convert.ToInt32(dr["CategoriaFk"]);
                        oProducto.CantidadP = Convert.ToInt32(dr["CantidadP"]);
                    }
                }
            }
            return oProducto;
        }

        public bool Guardar(Producto oProducto)
        {
            bool rpta=false;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);
                    cmd.Parameters.AddWithValue("NombreP", oProducto.NombreP);
                    cmd.Parameters.AddWithValue("Habilitado", oProducto.Habilitado);
                    cmd.Parameters.AddWithValue("CategoriaFk", oProducto.CategoriaFk);
                    cmd.Parameters.AddWithValue("CantidadP", oProducto.CantidadP);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception ex) 
            { 
                string error=ex.Message;
                rpta = false; 
            }
            return rpta;
        }
        public bool Editar(Producto oProducto)
        {
            bool rpta = false;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Editar", conexion);
                    cmd.Parameters.AddWithValue("ProductoId", oProducto.ProductoId);
                    cmd.Parameters.AddWithValue("NombreP", oProducto.NombreP);
                    cmd.Parameters.AddWithValue("Habilitado", oProducto.Habilitado);
                    cmd.Parameters.AddWithValue("CategoriaFk", oProducto.CategoriaFk);
                    cmd.Parameters.AddWithValue("CantidadP", oProducto.CantidadP);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                rpta = false;
            }
            return rpta;
        }
        public bool Borrar(int IdProducto)
        {
            bool rpta = false;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Eliminar", conexion);
                    cmd.Parameters.AddWithValue("ProductoId", IdProducto);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                rpta = false;
            }
            return rpta;
        }
    }
}
