using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; internal set; }
        public Product Product { get; set; }
    }
}
