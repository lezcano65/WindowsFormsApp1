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
        int pTipo;
        int pMarca;
        double pPrecio;
        DateTime pFecha;

        public int PCodigo { get => pCodigo; set => pCodigo = value; }
        public string PDetalle { get => pDetalle; set => pDetalle = value; }
        public int PTipo { get => pTipo; set => pTipo = value; }
        public int PMarca { get => pMarca; set => pMarca = value; }
        public double PPrecio { get => pPrecio; set => pPrecio = value; }
        public DateTime PFecha { get => pFecha; set => pFecha = value; }

        public Producto(int codigo, string detalle, int tipo, int marca, double precio, DateTime fecha)
        {
            this.PCodigo = codigo;
            this.PDetalle = detalle;
            this.PTipo = tipo;
            this.PMarca = marca;
            this.PPrecio = precio;
            this.PFecha = fecha;
        }
        public Producto() 
        {
            PCodigo = 0;
            PDetalle = "";
            PTipo = 0;
            PMarca = 0;
            PPrecio = 0;
            PFecha = DateTime.Today;
        }
        public override string ToString()
        {
            return PCodigo + "-" + PDetalle;
        }
    }
}
