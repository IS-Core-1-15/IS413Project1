using System;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class TasksModel
    {
        [Key]
        [Required]
        public int TaskID { get; set; }

        [Required(ErrorMessage = "You must provide a task description")]
        public string Task { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "You must provide a quadrant")]
        public int Quadrant { get; set; }

        public string Category { get; set; }

        public bool Completed { get; set; }
    }
}
