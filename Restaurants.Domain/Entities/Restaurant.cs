using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domain.Entities
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(40)]
        public string Category {  get; set; } = string.Empty;
        public bool HasDelivery { get; set; }

        [MaxLength(40)]
        public string? ContactEmail { get; set; }

        [Required]
        [MaxLength(10)]
        public string? ContactNumber { get; set; }

        public Address? Address { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
