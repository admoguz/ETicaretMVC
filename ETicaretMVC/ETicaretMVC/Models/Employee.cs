
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(250)]
        public string PhotoPath { get; set; }

        public SalesMove SalesMove { get; set; }

        public Department Department { get; set; }
    }
}
