using System.Collections.Generic;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}