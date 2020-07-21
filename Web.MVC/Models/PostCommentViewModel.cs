using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class PostCommentViewModel : ResponseModel
    {
        public PostComment Comment { get; set; }
    }
}
