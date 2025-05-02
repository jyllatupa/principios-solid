using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___S.Ejemplo2.Solucion
{
    internal class Calculadora
    {
        private readonly Sumador _sumador = new Sumador();
        private readonly Restador _restador = new Restador();

        public double Sumar(double a, double b)
        {
            return _sumador.Sumar(a, b);
        }

        public double Restar(double a, double b)
        {
            return _restador.Restar(a, b);
        }

    }
}
