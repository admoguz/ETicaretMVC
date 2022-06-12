using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretMVC.Models
{
    public class SalesMove
    {
        public int Id { get; set; }       

        public DateTime DateTime { get; set; }

        public int Piece { get; set; }

        public decimal Price { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
