using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___S.Ejemplo2.Solucion
{
    internal class Program
    {
        public static void Main()
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Suma: 10 + 5 = " + calc.Sumar(10, 5));   // Output: 15
            Console.WriteLine("Resta: 10 - 5 = " + calc.Restar(10, 5)); // Output: 5
        }
    }
}
