using GestionStockWeb.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace GestionStockWeb.Data
{
    public class ComprasDatos
    {
        public List<Compra> Listar()
        {
            var oLista = new List<Compra>();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Listar_Compra", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Compra()
                        {
                            CompraId = Convert.ToInt32(dr["CompraId"]),
                            FechaC = Convert.ToDateTime(dr["FechaC"].ToString()),
                            CantidadC = Convert.ToInt32(dr["CantidadC"]),
                            ProductoFk = Convert.ToInt32(dr["ProductoFk"]),
                            UsuarioFk = Convert.ToInt32(dr["UsuarioFk"])
                        });
                    }
                }
            }
            return oLista;
        }
        public Compra Obtener(int Compra)
        {
            var oCompra = new Compra();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Obtener_Compra", conexion);
                cmd.Parameters.AddWithValue("CompraId", Compra);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oCompra.CompraId = Convert.ToInt32(dr["CompraId"]);
                        oCompra.FechaC = Convert.ToDateTime(dr["FechaC"].ToString());
                        oCompra.CantidadC = Convert.ToInt32(dr["CantidadC"]);
                        oCompra.ProductoFk = Convert.ToInt32(dr["ProductoFk"]);
                        oCompra.UsuarioFk = Convert.ToInt32(dr["UsuarioFk"]);
                    }
                }
            }
            return oCompra;
        }
        public bool Guardar(Compra oCompra)
        {
            bool rpta = false;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar_Compra", conexion);
                    //cmd.Parameters.AddWithValue("CompraId", oCompra.CompraId);
                    cmd.Parameters.AddWithValue("FechaC", oCompra.FechaC);
                    cmd.Parameters.AddWithValue("CantidadC", oCompra.CantidadC);
                    cmd.Parameters.AddWithValue("ProductoFk", oCompra.ProductoFk);
                    cmd.Parameters.AddWithValue("UsuarioFk", oCompra.UsuarioFk);
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
