using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class CategoryController: Controller
    {

        private IPostService _postService;
        private IParamSessionService _paramSessionService;
        public CategoryController(IPostService postService, IParamSessionService paramSessionService)
        {
            _postService = postService;
            _paramSessionService = paramSessionService;
        }

        //[Route("[controller]/")]
        //public ActionResult Index()
        //{
        //    var posts = new List<PostComplex>();
        //    var post = _postService.GetById(1);
        //    posts.Add(post);
        //    var model = new PostViewModel
        //    {
        //        Posts = posts,
        //        Title = post.PostDetail.MetaTitle ?? post.Post.Title,
        //        Description = post.PostDetail.MetaDescription ?? post.Post.Summary,
        //        Keywords = post.PostDetail.MetaKeyword ?? post.Post.Title,
        //        Author = _paramSessionService.GetParam("Author").Description,
        //    };

        //    return View(model);
        //}
    }
}
