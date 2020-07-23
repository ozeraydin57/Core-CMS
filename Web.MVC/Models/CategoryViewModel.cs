using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.ComplexType;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class CategoryViewModel : BaseViewModel
    {
        public Category Category { get; set; }
    }
}
