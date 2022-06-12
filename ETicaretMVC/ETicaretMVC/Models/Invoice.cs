using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretMVC.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(1)]
        public string SerialNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(6)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(60)]
        public string TaxAdministration { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Recipient { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Consigner { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
