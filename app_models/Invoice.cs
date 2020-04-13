using app_models;
using System;

namespace BillingManagement.Models
{
    class Invoice
    {

        public int InvoiceId { get; set; }

        DateTime CreationDateTime;

        Customer customer { get; set; }

        public Double SubTotal { get; set; }
        public Double Fedtax { get; set; }
        public Double ProvTax { get; set; }
        public Double Total { get; set; }

        public Invoice() {

            CreationDateTime = DateTime.Now;

        }

        public Invoice(Customer c)
        {
            customer = c;
            CreationDateTime = DateTime.Now;
        }
    }
}
