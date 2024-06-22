using Microsoft.AspNetCore.Mvc;
using GestionStockWeb.Data;
using GestionStockWeb.Models;
using Microsoft.EntityFrameworkCore;
using GestionStockWeb.ViewModels;
using System.Security.Policy;

namespace GestionStockWeb.Controllers
{
    public class AccesoController : Controller
    {
        private readonly StockDBContext _dbContext;
        public AccesoController(StockDBContext stockDBContext) 
        {
            _dbContext = stockDBContext;
        }
        [HttpGet]
        public IActionResult registrarse()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registrar(UsuarioVM modelo)
        {
            //if (modelo.HashU != modelo.Salt)
            //{
            //    ViewData["Mensaje"] = "las contraseñas no coinciden";
            //}
            Usuario usuario = new Usuario()
            {
                NombreU = modelo.NombreU,
                HashU = modelo.HashU,
                Salt = modelo.Salt
            }; 
            
            
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            if (usuario.UsuarioId != 0)
            {
                return RedirectToAction("Login", "Acceso");

            }
            //ViewData["Mensaje"] = "no se pudo crear el usuario";
            return View();
        }
    }
}
