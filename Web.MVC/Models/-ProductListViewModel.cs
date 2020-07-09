using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int PageCount { get; internal set; }
        public int Pagesize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
