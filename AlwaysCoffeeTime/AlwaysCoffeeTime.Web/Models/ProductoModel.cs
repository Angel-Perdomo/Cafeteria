using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlwaysCoffeeTime.Web.Models
{
    public class ProductoModel
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }
    }
}