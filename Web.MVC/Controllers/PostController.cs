using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.Models;

namespace Web.MVC.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;
        public PostController(IPostService postService) => _postService = postService;

        // GET: PostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Detail(int id)
        {
            var posts = new List<PostComplex>();

            posts.Add(_postService.GetById(id));
            var model = new PostViewModel
            {
                Posts = posts
            };

            return View(model);
        }
    }
}