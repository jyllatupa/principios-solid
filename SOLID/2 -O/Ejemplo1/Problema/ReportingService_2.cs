using SOLID._1___S.Problema;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2__O.Problema
{
    internal class ReportingService_2
    {
        public void GenerateReport(List<Order> orders, ReportType_2 type)
        {
            if(type == ReportType_2.PDF)
            {
                CreatePDFReport(orders);
            }
            else if(type == ReportType_2.EXCEL)
            {
                CreateExcelReport(orders);
            }
            else if (type == ReportType_2.JSON)
            {
                CreateExcelReport(orders);
            }
            else if (type == ReportType_2.XML)
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

    public enum ReportType_2
    {
        PDF,
        EXCEL,
        JSON,
        XML
    }
}
