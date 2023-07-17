using System.ComponentModel.DataAnnotations;
using System;


namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }    
        public string DisplayOrder { get; set; }
    }
}
