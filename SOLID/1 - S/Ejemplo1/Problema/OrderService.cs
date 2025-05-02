using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___S.Problema
{
    public class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);
                var invoice = this.CreateInvoice(order);
                this.EmailInvoice(invoice);
                File.WriteAllText(@"c:\Infolog.txt", "The order has been completo");
            }
            catch (Exception ex) { 
                File.WriteAllText(@"c:\Errorlog.txt", ex.Message);
            }    
        }

        public bool InsertOrder(Order order)
        {
            return true;
        }

        public Invoice CreateInvoice(Order order)
        {
            return new Invoice();
        }

        public bool EmailInvoice(Invoice invoice) { 
            return true;
        }
    }

    public class Order
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
    }

    public class Invoice { }

}
