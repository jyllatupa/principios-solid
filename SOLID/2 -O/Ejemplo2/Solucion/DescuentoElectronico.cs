using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Ejemplo2.Solucion
{
    public class DescuentoElectronico : IDescuento
    {
        public double AplicarDescuento(double precio)
        {
            return precio * 0.8;
        }
    }
}
