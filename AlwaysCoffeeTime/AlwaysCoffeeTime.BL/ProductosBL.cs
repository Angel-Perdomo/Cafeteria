using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysCoffeeTime.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Codigo = 1;
            producto1.Descripcion = "Cafe caliente";
            producto1.Precio = 55;
            producto1.Categoria = "CAFECITOS";
            producto1.Existencia = 12;
            producto1.Activo = true;

            var producto2 = new Producto();
            producto2.Codigo = 2;
            producto2.Descripcion = "Pepsi";
            producto2.Precio = 55;
            producto2.Categoria = "REFRESCOS";
            producto2.Existencia = 41;
            producto2.Activo = true;

            var producto3 = new Producto();
            producto3.Codigo = 3;
            producto3.Descripcion = "Capuchino";
            producto3.Precio = 56;
            producto3.Categoria = "CAFECITOS";
            producto3.Existencia = 15;
            producto3.Activo = true;

            var listaDeProductos = new List<Producto>();
            listaDeProductos.Add(producto1);
            listaDeProductos.Add(producto2);
            listaDeProductos.Add(producto3);

            return listaDeProductos;
        }
    }
}
