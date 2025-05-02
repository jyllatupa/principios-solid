using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___I.Problema
{
    internal class Program
    {
        public static void Main()
        {
            BurgerOrderService orderService = new BurgerOrderService();
            orderService.OrderBurger(2);
        }
    }
}
