using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
