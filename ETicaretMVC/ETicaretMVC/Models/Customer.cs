﻿using System.ComponentModel.DataAnnotations;

namespace ETicaretMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

        public string Email { get; set; }
    }
}
