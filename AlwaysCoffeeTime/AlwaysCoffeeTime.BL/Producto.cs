using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysCoffeeTime.BL
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}
