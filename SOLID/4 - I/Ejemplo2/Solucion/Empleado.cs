using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___I.Ejemplo2.Solucion
{
    internal class Empleado : ITrabajador, IDormir
    {
        public void Dormir()
        {
            Console.WriteLine("El empleado esta dormido");
        }

        public void Trabajar()
        {
            Console.WriteLine("El empleado esta trabajando");
        }
    }
}
