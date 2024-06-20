using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Producto
    {
        int pCodigo;
        string pDetalle;
        int pCantidad;
        string pMarca;
        string pPrecio;
        DateTime pFecha;

        public int PCodigo { get => pCodigo; set => pCodigo = value; }
        public string PDetalle { get => pDetalle; set => pDetalle = value; }
        public int PCantidad { get => pCantidad; set => pCantidad = value; }
        public string PMarca { get => pMarca; set => pMarca = value; }
        public string PPrecio { get => pPrecio; set => pPrecio = value; }
        public DateTime PFecha { get => pFecha; set => pFecha = value; }

        public Producto(int codigo, string detalle, int tipo, string marca, string precio, DateTime fecha)
        {
            this.PCodigo = codigo;
            this.PDetalle = detalle;
            this.PCantidad = tipo;
            this.PMarca = marca;
            this.PPrecio = precio;
            this.PFecha = fecha;
        }
        public Producto() 
        {
            PCodigo = 0;
            PDetalle = "";
            PCantidad = 0;
            PMarca = "";
            PPrecio = "";
            PFecha = DateTime.Today;
        }
        public override string ToString()
        {
            return PCodigo + "-" + PDetalle;
        }
    }
}
