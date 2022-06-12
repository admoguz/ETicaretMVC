
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        public string City { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        public SalesMove SalesMove { get; set; }
    }
}
