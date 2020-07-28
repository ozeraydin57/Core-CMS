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
    public class PostCommentController : Controller
    {
        private IPostCommentService _postService;
        public PostCommentController(IPostCommentService postService) => _postService = postService;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            PostComment data = new PostComment
            {
                PostId = int.Parse(collection["PostId"].ToString()),
                Name = collection["Name"].ToString(),
                Email = collection["Email"].ToString(),
                Comment = collection["Comment"].ToString(),
                Web = collection["Web"].ToString(),
                CreateDate = DateTime.Now
            };
            _postService.Add(data);

            var response = new ResponseModel<int>
            {
                Success = true,
                Message = "Yorumunuz alımıştır, onay sürecinden geçtikten sonra eklenecektir."
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult List(int postId)
        {
            //var postId = int.Parse(collection["PostId"].ToString());
            var list = _postService.GetAllByPostId(postId);

            var response = new ResponseModel<List<PostComment>>
            {
                Data=list,
                Success = true,
                Message = "Yorum Listesi"
            };

            return Ok(response);
        }
    }
}