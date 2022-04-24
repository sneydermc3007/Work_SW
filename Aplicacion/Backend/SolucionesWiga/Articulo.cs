    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesWiga
{
    public class Articulo
    {
        public string producto { get; set; }
        public int cantidad { get; set; }
        public double total { get; set; }

        public Articulo()
        {

        }

        public Articulo(string producto, int cantidad, double total)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.total = total;
        }

    }
}
