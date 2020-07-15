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
    public class PostHeaderViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PostHeaderViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke()
        {
            var model = new PostViewModel
            {
                Posts = _postService.GetAllComplex(0,4).ToList()
            };

            return View(model);
        }
    }
}
