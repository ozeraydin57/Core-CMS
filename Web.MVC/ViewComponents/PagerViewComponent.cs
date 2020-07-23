using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.ExtensionMethods;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class PagerViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PagerViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke(int categoryId)
        {

            int totalCount;

            if (categoryId > 0)
                totalCount = _postService.GetAllComplexByCategoryId(0, 10000, categoryId).Count;
            else
                totalCount = _postService.GetAllCount() - 4;

            int page = Request.Query.GetParamInt("page");
            var model = new PagerViewModel
            {
                TotalPage = (int)Math.Ceiling((decimal)totalCount / 10),
                Page = page == 0 ? 1 : page,
                Take = 10,
            };
            return View(model);
        }
    }
}
