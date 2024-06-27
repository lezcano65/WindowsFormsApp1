using Microsoft.AspNetCore.Mvc;
using GestionStockWeb.Data;
using GestionStockWeb.Models;

namespace GestionStockWeb.Controllers
{
    public class CompraController : Controller
    {
        ComprasDatos _ComprasDatos = new ComprasDatos();
        public IActionResult Listar()
        {
            var oLista = _ComprasDatos.Listar();
            return View(oLista);
        }
        public IActionResult Comprar(int Compras)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        public IActionResult Guardar()
        {
            //devolver la vista
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(Compra oCompra)
        {
            //guardar un producto
            var respuesta = _ComprasDatos.Guardar(oCompra);
            if (respuesta)
                return RedirectToAction("Listar");
            else return View();
        }
    }
}
