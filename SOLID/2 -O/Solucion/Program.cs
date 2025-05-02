using SOLID._1___S.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Solucion
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService(new ReportGeneratorPDF());
            service.GenerateReport(orders);
        }
    }
}
