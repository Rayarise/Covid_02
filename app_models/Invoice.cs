using app_models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BillingManagement.Models
{
    public class Invoice : INotifyPropertyChanged
    
    {

        public int InvoiceId { get; set; }

        DateTime CreationDateTime;

        Customer customer { get; set; }

        public Double SubTotal { get; set; }

        public Double Fedtax
        {
            get { return SubTotal * 0.05; }
            set { }
        }       
            
            
        
        
        public Double ProvTax
        {
            get { return SubTotal * 0.09975; }
            set { }
        }
        public Double Total
        {
            get { return SubTotal + ProvTax + Fedtax; }
            set { }
        }

        public Invoice() {

            CreationDateTime = DateTime.Now;

        }

        public Invoice(Customer c)
        {
            customer = c;
            CreationDateTime = DateTime.Now;
        }








        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
