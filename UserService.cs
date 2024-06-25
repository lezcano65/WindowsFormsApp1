using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace WindowsFormsApp1
{
    public class UserService
    {
        // Generar un salt seguro
        public static byte[] GenerateSalt(int size = 128)
        {
            byte[] salt = new byte[size / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        // Crear un hash de la contraseña con el salt proporcionado
        public static string HashPassword(string password, byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        // Verificar que el hash de la contraseña coincide con el hash almacenado
        public static bool VerifyPassword(string password, string hashedPassword, byte[] salt)
        {
            string hashOfInput = HashPassword(password, salt);
            return hashOfInput == hashedPassword;
        }
    }
}
