using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___I.Ejemplo2.Solucion
{
    internal class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El robo esta trabajando");
        }
    }
}
