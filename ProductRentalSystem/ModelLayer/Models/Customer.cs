using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember, MaxLength(50), Required]
        public string Name { get; set; }
        [DataMember]
        public DateTime? Birthday { get; set; }
        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}
