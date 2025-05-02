using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___S.Solucion
{
    public interface IOrderRepository
    {
        public bool InsertOrder(Order order); 
    }

    class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            return true;
        }
    }
}
