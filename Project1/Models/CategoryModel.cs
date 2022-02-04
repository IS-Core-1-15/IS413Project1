using System;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class CategoryModel
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
