
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
