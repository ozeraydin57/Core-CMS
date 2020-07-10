using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class PostRecentViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PostRecentViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke()
        {
            var model = new PostViewModel
            {
                Posts = _postService.GetAll()
            };

            return View(model);
        }
    }
}
