using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    [DataContract]
    public class Rental
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
        [DataMember, Key, DatabaseGenerated(DatabaseGeneratedOption.None), ForeignKey("Product")]
        public int ProductId { get; set; }
        [DataMember]
        public Product Product { get; set; }
    }
}
