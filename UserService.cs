using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace WindowsFormsApp1
{
    public class UserService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
    /*
    public class HashController : Controller
    {
        private readonly UserService _userService;

        public AccountController()
        {
            _userService = new UserService();
        }

        public IActionResult Register(string username, string password)
        {
            string hashedPassword = _userService.HashPassword(password);

            // Guarda el usuario y el hashedPassword en la base de datos
            // Código para guardar en la base de datos aquí

            return Ok("registrado exitosamente");
        }

        public IActionResult Login(string username, string password)
        {
            // Recuperar el usuario de la base de datos aquí
            string hashedPasswordFromDb = ""; // Recuperar de la base de datos

            if (_userService.VerifyPassword(password, hashedPasswordFromDb))
            {
                return Ok("Inicio de sesión exitoso");
            }
            else
            {
                return BadRequest("pass incorecta");
            }
        }
    }
    */
}
