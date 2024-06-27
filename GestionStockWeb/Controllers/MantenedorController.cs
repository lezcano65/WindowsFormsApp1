using Microsoft.AspNetCore.Mvc;
using GestionStockWeb.Data;
using GestionStockWeb.Models;

namespace GestionStockWeb.Controllers
{
    public class MantenedorController : Controller
    {
        ProductosDatos _ProductoDatos=new ProductosDatos();
        ComprasDatos _ComprasDatos=new ComprasDatos();
        public IActionResult Listar()
        {
            var oLista = _ProductoDatos.Listar();
            return View(oLista);
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
        /*
        [HttpPost]
        public IActionResult Guardar(Producto oProducto)
        {
            //guardar un producto
            var respuesta = _ProductoDatos.Guardar(oProducto);
            if (respuesta)
                return RedirectToAction("Listar");
            else return View();
        }
        */
        [HttpPost]
        public IActionResult Guardar(Compra oCompra)
        {
            //guardar un producto
            var respuesta = _ComprasDatos.Guardar(oCompra);
            if (respuesta)
                return RedirectToAction("Listar");
            else return View();
        }
        [HttpPost]
        public IActionResult ComprarProducto(Compra oCompra)
        {
            //guardar un producto

            var respuesta = _ComprasDatos.Guardar(oCompra);
            if (respuesta)
                return RedirectToAction("Listar");
            else return View();
        }

    }
}
