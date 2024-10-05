using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domain.Entities
{
    public class Address
    {
        [MaxLength(40)]
        public string? City { get; set; }

        [MaxLength(40)]
        public string? Street { get; set; }

        [MaxLength(40)]
        public string? PostalCode { get; set; }
    }
}
