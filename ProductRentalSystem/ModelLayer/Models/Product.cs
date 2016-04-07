using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }

        public int? RentalId { get; set; }
        public Rental Rental { get; set; }
    }
}
