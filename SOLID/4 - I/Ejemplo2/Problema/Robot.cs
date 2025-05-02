using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___I.Ejemplo2.Problema
{
    internal class Robot : ITrabajador
    {
        public void Dormir()
        {
            //El robot no puede dormir
        }

        public void Trabajar()
        {
            Console.WriteLine("El robot esta trabajando");
        }
    }
}
