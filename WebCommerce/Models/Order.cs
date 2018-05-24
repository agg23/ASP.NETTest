using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Product OrderedProduct { get; set; }
        public virtual User OrderingUser { get; set; }
    }
}
