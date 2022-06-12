using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretMVC.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Amount { get; set; }
    }
}
