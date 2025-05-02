using SOLID._1___S.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Problema
{
    internal class Program2
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService();
            service.GenerateReport(orders, ReportType.PDF);
        }
    }
}
