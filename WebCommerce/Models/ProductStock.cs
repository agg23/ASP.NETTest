using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCommerce.Models
{
    public class ProductStock
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public virtual Product Product { get; set; }
    }
}
