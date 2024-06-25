using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Producto
    {
        int ProductoId;
        string NombreP;
        bool Habilitado;
        int CategoriaFk;
        int CantidadP;
        string PrecioP;
        public int ProductoId1 { get => ProductoId; set => ProductoId = value; }
        public string NombreP1 { get => NombreP; set => NombreP = value; }
        public bool Habilitado1 { get => Habilitado; set => Habilitado = value; }
        public int CategoriaFk1 { get => CategoriaFk; set => CategoriaFk = value; }
        public int CantidadP1 { get => CantidadP; set => CantidadP = value; }
        public string PrecioP1 { get => PrecioP; set => PrecioP = value; }
        public Producto(int codigo, string nombre, bool tipo, int categoria, int cantidad,string precio)
        {
            this.ProductoId = codigo;
            this.NombreP = nombre;
            this.Habilitado = tipo;
            this.CategoriaFk = categoria;
            this.CantidadP = cantidad;
            this.PrecioP = precio;
        }
        public Producto()
        {
            ProductoId = 0;
            NombreP = "";
            Habilitado = false;
            CategoriaFk = 0;
            CantidadP = 0;
            PrecioP = "";
        }
        public override string ToString()
        {
            return ProductoId + "-" + NombreP;
        }
    }
}