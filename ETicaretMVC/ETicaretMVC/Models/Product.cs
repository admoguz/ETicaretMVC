
using ETicaretMVC.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [Required, MaxLength(30)]
        public string Brand { get; set; }

        public short Stock { get; set; }

        public decimal Price { get; set; }

        public decimal SalePrice { get; set; }

        public bool Enum { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(250)]
        public string PhotoPath { get; set; }

        public Category Category { get; set; }

        public SalesMove SalesMove { get; set; }
    }
}
