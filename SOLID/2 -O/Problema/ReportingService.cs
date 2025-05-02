using SOLID._1___S.Problema;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Problema
{
    internal class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            if(type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if(type == ReportType.EXCEL)
            {
                CreateExcelReport(orders);
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {

        }

        public void CreateExcelReport(List<Order> orders)
        {

        }
    }

    public enum ReportType
    {
        PDF,
        EXCEL
    }
}
