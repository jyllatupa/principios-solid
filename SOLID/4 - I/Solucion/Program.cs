using SOLID._4___I.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___I.Solucion
{
    internal class Program
    {
        public static void Main()
        {
            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurger(2);
        }
    }
}
