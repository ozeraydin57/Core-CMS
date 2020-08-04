using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;
using Web.MVC.ExtensionMethods;
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
            var postId = Request.Cookies.GetValue("Post" + id.ToString());
            if (string.IsNullOrEmpty(postId))
            {
                var tmpPost = _postService.GetById(id);
                tmpPost.ReadCount += 1;
                _postService.Update(tmpPost);
                Response.Cookies.SetValue("Post" + id.ToString());
            }

            var posts = new List<PostComplex>();
            var post = _postService.GetComplexById(id);
            posts.Add(post);
            var model = new PostViewModel
            {
                Posts = posts,
                MetaTitle = post.Post.MetaTitle ?? post.Post.Title,
                MetaDescription = post.Post.MetaDescription ?? post.Post.Summary,
                MetaKeywords = post.Post.MetaKeyword ?? post.Post.Title,
                MetaAuthor = _paramSessionService.GetParam(ParamType.Author).Description,
            };

            return View(model);
        }
    }
}