using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace GestionStockWeb.ViewModels
{
    public class UsuarioVM
    {
        public string? NombreU { get; set; }

        public string? HashU { get; set; }

        public string? Salt { get; set; }

        public void SetPassword(string password)
        {
            // Generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            Salt = Convert.ToBase64String(salt);

            // Derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            HashU = hashed;
        }

        public bool VerifyPassword(string password)
        {
            if (string.IsNullOrEmpty(Salt) || string.IsNullOrEmpty(HashU))
            {
                return false;
            }

            byte[] salt = Convert.FromBase64String(Salt);
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return HashU == hashed;
        }
    }
}