using System.Text;
using System.Security.Cryptography;
using GestionStockWeb.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace GestionStockWeb.ViewModels
{
    public class UsuarioVM
    {
        public string? NombreU { get; set; }

        public string? HashU { get; set; }

        //public string? HashU2 { get; set; }

        public string? Salt { get; set; }

    
        
    }
}
