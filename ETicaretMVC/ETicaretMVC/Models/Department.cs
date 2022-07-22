using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretMVC.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [Required ,MaxLength(30)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
