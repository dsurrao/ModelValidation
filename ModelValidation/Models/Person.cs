using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
