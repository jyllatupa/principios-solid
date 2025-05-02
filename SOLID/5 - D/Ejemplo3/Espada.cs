using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Ejemplo3
{
    public class Espada : IArma
    {
        public void Atacar()
        {
            Console.WriteLine("Produce daño por cortes");
        }
    }

    public class Daga : IArma
    {
        public void Atacar()
        {
            Console.WriteLine("Produce daño de sangrado");
        }
    }
}
