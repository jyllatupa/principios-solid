using SOLID._1___S.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Solucion
{
    internal class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order) 
        { 
            //TODO codigo para crear la orden

            //Send Notification to datadog
            _eventNotificationService.LogEvent("The order was successfully created");
        }
    }
}
