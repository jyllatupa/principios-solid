using SOLID._1___S.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Problema
{
    public class DataDogService
    {
        public void LogEvent(string message) 
        { 
            //Code to event on dataDog
        }
    }

    public class OrderService
    {
        public readonly DataDogService _datadogService;

        public OrderService(DataDogService datadogService)
        {
            _datadogService = datadogService;
        } 
        
        public void GenerateOrder(Order order) 
        {
            //Codigo para crear la orden

            //Send notification to datadog
            _datadogService.LogEvent("The order was successfully created");
        }
    }
}
