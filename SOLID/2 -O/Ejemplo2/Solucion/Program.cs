using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Ejemplo2.Solucion
{
    internal class Program
    {
        public static void Main()
        {
            // Crear instancia de la calculadora
            CalculadoraDescuento2 calculadora = new CalculadoraDescuento2();

            // Precio original
            double precio = 100.0;

            // Usar SinDescuento
            IDescuento sinDescuento = new SinDescuento();
            Console.WriteLine(calculadora.CalcularConDescuento(sinDescuento, precio));  // 100.0

            // Usar DescuentoElectronico
            IDescuento descuentoElectronico = new DescuentoElectronico();
            Console.WriteLine(calculadora.CalcularConDescuento(descuentoElectronico, precio));  // 80.0

            // Usar DescuentoRopa
            IDescuento descuentoRopa = new DescuentoRopa();
            Console.WriteLine(calculadora.CalcularConDescuento(descuentoRopa, precio));  // 90.0

        }
    }
}
