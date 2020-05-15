using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAssignment.Models
{
    public class CarsModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Price { get; set; }
    }
}