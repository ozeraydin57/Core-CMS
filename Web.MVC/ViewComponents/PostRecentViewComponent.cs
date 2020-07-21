using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using Tier.Business.Abstract;
using Web.MVC.ExtensionMethods;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class PostRecentViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PostRecentViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke(int skip)
        {
            int page = Request.Query.GetParamInt("page");
            if (page > 0)
                page--;

            skip += page * 10;

            var model = new PostViewModel
            {
                Posts = _postService.GetAllComplex(skip, 10).ToList()
            };

            return View(model);
        }
    }
}
