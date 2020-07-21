using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;

namespace Web.MVC.ViewComponents
{
    public class CommentListViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke(int postId)
        {
            var model = new ResponseModel<int>
            {
                Success = true,
                Data = postId
            };

            return View(model);
        }
    }
}
