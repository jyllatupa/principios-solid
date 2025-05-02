using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Ejemplo2.Problema
{
    internal class NaveRecolector : INaveEspacial
    {
        public void Aterrizar()
        {
            Console.WriteLine("Nave Recolector despegando");
        }

        public void Despegar()
        {
            Console.WriteLine("Nave Recolector aterrizando");
        }
    }
}
