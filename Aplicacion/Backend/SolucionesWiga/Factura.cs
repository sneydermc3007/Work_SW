using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesWiga
{
    public class Factura
    {
        public DateTime date { get; set; }
        public List<Articulo> articulos { get; set; }

        public Factura()
        {
           
        }

        public Factura(DateTime date, List<Articulo> articulos)
        {
            this.date = date;
            this.articulos = articulos;

            Console.WriteLine("\tFecha: " + date);
        }
    }
}
