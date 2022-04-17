using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesWiga
{
    public class Cliente
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Factura> factura { get; set; }
    }
}
