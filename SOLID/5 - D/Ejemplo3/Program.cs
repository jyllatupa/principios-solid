using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Ejemplo3
{
    internal class Program
    {
        public static void Main()
        {
            JugadorInyeccion jugador1 = new JugadorInyeccion(new Espada());
            JugadorInyeccion jugador2 = new JugadorInyeccion(new Daga());

            jugador1.Pelear();
            jugador2.Pelear();

            Console.ReadKey();
        }
    }
}
