using System;

namespace ETicaretMVC.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public string OrderNumber { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string TaxAdministration { get; set; } 

        public string Recipient { get; set; } 
        public string Consigner { get; set; } 
    }
}
