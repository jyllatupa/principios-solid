using SOLID._1___S.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___S.Solucion
{
    public interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }

    class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            return new Invoice();
        }
    }
}
