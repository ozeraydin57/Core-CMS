using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.ExtensionMethods;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class PostRecentViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PostRecentViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke(int skip, int categoryId)
        {
            int page = Request.Query.GetParamInt("page");
            if (page > 0)
                page--;

            skip += page * 10;

            var model = new PostViewModel();

            if (categoryId > 0)
                model.Posts = _postService.GetAllComplexByCategoryId(skip, 10, categoryId).ToList();
            else
                model.Posts = _postService.GetAllComplex(skip, 10).ToList();

            return View(model);
        }
    }
}