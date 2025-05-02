using SOLID._1___S.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___S.Solucion
{
    public interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }

    class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            return true;
        }
    }
}
