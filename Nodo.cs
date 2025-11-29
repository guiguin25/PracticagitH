using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppListasDobles
{
    class Nodo
    {
        public Nodo Ante { get; set; }
        public int Info { get; set; }
        public Nodo Sigte { get; set; }
        public Nodo()
        {
            Info = 0;
            Ante = null;
            Sigte = null;
        }
        public Nodo(int info)
        {
            Info = info;
            Ante = null;
            Sigte = null;
        }


    }
}
