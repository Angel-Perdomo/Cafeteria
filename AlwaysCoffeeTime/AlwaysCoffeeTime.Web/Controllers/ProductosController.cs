using AlwaysCoffeeTime.Web.Models;
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

            var producto1 = new ProductoModel();
            producto1.Codigo = 1;
            producto1.Descripcion = "Cafe caliente";
            producto1.Precio = 55;
            producto1.Categoria = "CAFECITOS";
            producto1.Activo = true;

            var producto2 = new ProductoModel();
            producto2.Codigo = 2;
            producto2.Descripcion = "Pepsi";
            producto2.Precio = 55;
            producto2.Categoria = "REFRESCOS";
            producto2.Activo = true;

            var producto3 = new ProductoModel();
            producto3.Codigo = 3;
            producto3.Descripcion = "Capuchino";
            producto3.Precio = 56;
            producto3.Categoria = "CAFECITOS";
            producto3.Activo = true;

            var listaDeProductos = new List<ProductoModel>();
            listaDeProductos.Add(producto1);
            listaDeProductos.Add(producto2);
            listaDeProductos.Add(producto3);

            return View(listaDeProductos);
        }
    }
}