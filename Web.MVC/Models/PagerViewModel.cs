using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.MVC.Models
{
    public class PagerViewModel
    {
        public int Page { get; set; }
        public int Take { get; set; }
        public int TotalPage { get; internal set; }
    }
}
