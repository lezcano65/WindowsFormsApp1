using Microsoft.AspNetCore.Mvc;
using GestionStockWeb.Data;
using GestionStockWeb.Models;
using Microsoft.EntityFrameworkCore;
using GestionStockWeb.ViewModels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace GestionStockWeb.Controllers
{
    public class AccesoController : Controller
    {
        private readonly StockDBContext _dbContext;

        public AccesoController(StockDBContext stockDBContext)
        {
            _dbContext = stockDBContext;
        }

        // Método para generar un hash utilizando PBKDF2
        private string GenerateHash(string password, string salt)
        {
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (var hmac = new HMACSHA256(saltBytes))
            {
                byte[] hashBytes = hmac.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Método para verificar la contraseña
        private bool VerifyPassword(string password, string salt, string expectedHash)
        {
            string actualHash = GenerateHash(password, salt);
            return actualHash == expectedHash;
        }

        // REGISTRARSE
        [HttpGet]
        public IActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrarse(UsuarioVM modelo)
        {
            if (ModelState.IsValid)
            {
                // Generar un salt único
                byte[] saltBytes = new byte[128 / 8];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(saltBytes);
                }
                string salt = Convert.ToBase64String(saltBytes);

                // Generar el hash de la contraseña con el salt
                string hash = GenerateHash(modelo.HashU, salt);

                Usuario usuario = new Usuario()
                {
                    NombreU = modelo.NombreU,
                    HashU = hash,
                    Salt = salt
                };

                await _dbContext.Usuarios.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();

                if (usuario.UsuarioId != 0)
                {
                    return RedirectToAction("Login", "Acceso");
                }
            }

            // Si hay errores en el modelo, vuelve a mostrar la vista de registro
            return View(modelo);
        }

        // LOGIN
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM modelo)
        {
            if (ModelState.IsValid)
            {
                Usuario usuarioEncontrado = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.NombreU == modelo.NombreU);
                if (usuarioEncontrado != null)
                {
                    if (VerifyPassword(modelo.HashU, usuarioEncontrado.Salt, usuarioEncontrado.HashU))
                    {
                        // La contraseña es correcta, iniciar sesión
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            // Si la autenticación falla, mostrar mensaje de error
            ViewData["Mensaje"] = "Nombre de usuario o contraseña incorrectos";
            return View();
        }
    }
}