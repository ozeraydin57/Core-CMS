using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;
        private IParamSessionService _paramSessionService;
        public PostController(IPostService postService, IParamSessionService paramSessionService)
        {
            _postService = postService;
            _paramSessionService = paramSessionService;
        }

        // GET: PostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Detail(int id)
        {
            var posts = new List<PostComplex>();
            var post = _postService.GetById(id);
            posts.Add(post);
            var model = new PostViewModel
            {
                Posts = posts,
                Title = post.PostDetail.MetaTitle ?? post.Post.Title,
                Description = post.PostDetail.MetaDescription ?? post.Post.Summary,
                Keywords = post.PostDetail.MetaKeyword ?? post.Post.Title,
                Author = _paramSessionService.GetParam("Author").Description,
            };

            return View(model);
        }
    }
}