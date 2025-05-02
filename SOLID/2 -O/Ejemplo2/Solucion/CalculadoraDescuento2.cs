using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Ejemplo2.Solucion
{
    public class CalculadoraDescuento2
    {
        public double CalcularConDescuento(IDescuento descuento, double precio)
        {
            return descuento.AplicarDescuento(precio);
        }
    }
}
