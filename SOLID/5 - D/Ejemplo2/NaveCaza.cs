using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Ejemplo2.Problema
{
    internal class NaveCaza : INaveEspacial
    {
        public void Aterrizar()
        {
            Console.WriteLine("Nave Caza despegando");
        }

        public void Despegar()
        {
            Console.WriteLine("Nave Caza aterrizando");
        }
    }
}
