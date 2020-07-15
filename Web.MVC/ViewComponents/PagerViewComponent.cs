using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using Tier.Business.Abstract;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class PagerViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PagerViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke()
        {
            var totalCount = _postService.GetAllCount()-4;

            var model = new PagerViewModel
            {
                TotalPage = (int)Math.Ceiling((decimal)totalCount / 10),
                Page = 0,
                Take = 10,

            };
            return View(model);
        }
    }
}
