using AlwaysCoffeeTime.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlwaysCoffeeTime.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listaDeProductos = productosBL.ObtenerProductos();

            return View(listaDeProductos);
        }
    }
}