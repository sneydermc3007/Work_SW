using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesWiga
{
    public class Factura
    {
        public string date { get; set; }
        public List<Articulo> articulos { get; set; }
    }
}
