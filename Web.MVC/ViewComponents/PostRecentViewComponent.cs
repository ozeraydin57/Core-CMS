using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using Tier.Business.Abstract;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class PostRecentViewComponent : ViewComponent
    {
        private IPostService _postService;
        public PostRecentViewComponent(IPostService postService) => _postService = postService;

        public ViewViewComponentResult Invoke(int skip)
        {
            var query = Request.Query["Page"];
            int page = 1;
            if (!string.IsNullOrEmpty(query))
                int.TryParse(query.ToString(), out page);
            else
                page = 1;

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
