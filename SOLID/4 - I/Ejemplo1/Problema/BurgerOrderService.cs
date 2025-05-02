using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___I.Problema
{
    public class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            //Code
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
