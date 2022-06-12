using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretMVC.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(10)]
        public int UserName { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(10)]
        public string Password { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(1)]
        public string Authority { get; set; }
    }
}
