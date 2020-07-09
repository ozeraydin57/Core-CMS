using System;
using System.Linq;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
