using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppListasDobles
{
    class Producto
    {
        public int CodProp { get; set; }
        public string NomProd { get; set; }
        public double PrecioProd { get; set; }
        public Producto()
        {
           CodProp = 0;
            NomProd = "";
            PrecioProd = 0.0;
        }
    }
}
