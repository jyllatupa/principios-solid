using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Ejemplo2.Problema
{
    internal class CalculadoraDescuento
    {
        public double AplicarDescuento(double precio, string tipoProducto)
        {
            if(tipoProducto == "Electrónico")
            {
                return precio * 0.8;
            }
            else if(tipoProducto == "Ropa")
            {
                 return precio * 0.9;
            }
            else
            {
                return precio;
            }
        }
    }
}
