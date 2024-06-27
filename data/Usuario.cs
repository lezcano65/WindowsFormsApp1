using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreU { get; set; }
        public string HashU { get; set; }
        public byte[] Salt { get; set; }
    }
}
