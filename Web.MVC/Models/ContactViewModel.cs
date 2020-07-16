using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class ContactViewModel :ResponseModel
    {
        public Contact  Contact { get; set; }
    }
}
