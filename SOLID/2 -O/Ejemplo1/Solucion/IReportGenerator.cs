using SOLID._1___S.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Solucion
{
    internal interface IReportGenerator
    {
        void GenerateReport(List<Order> orders);
    }
}
