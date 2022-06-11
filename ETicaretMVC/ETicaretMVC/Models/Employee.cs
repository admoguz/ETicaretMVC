using System.ComponentModel.DataAnnotations;

namespace ETicaretMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PhotoPath { get; set; }
    }
}
