using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Ejemplo2.Problema
{
    internal class SistemaControlNaves 
    {
        private readonly INaveEspacial _nave;

        public SistemaControlNaves(INaveEspacial nave)
        {
            _nave = nave;
        }

        public void OperarNave()
        {
            _nave.Despegar();
            _nave.Aterrizar();
        }
    }
}
