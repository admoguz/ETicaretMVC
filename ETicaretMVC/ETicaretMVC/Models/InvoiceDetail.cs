using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretMVC.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(100)]
        public string Description { get; set; }

        public int Piece { get; set; }

        public int UnitPrice { get; set; }

        public int Amount { get; set; }

        public Invoice Invoice { get; set; }
    }
}
