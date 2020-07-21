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
        private IPostCommentService _contactService;
        public PostCommentController(IPostCommentService contactService) => _contactService = contactService;

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
                Comment = collection["Phone"].ToString(),
                Web = collection["Web"].ToString(),
                CreateDate = DateTime.Now
            };

            _contactService.Add(data);

            var response = new PostCommentViewModel
            {
                Comment = data,
                Success = true,
                Message = "Yorumunuz alımıştır, kısa bir onay sürecinden geçtikten sonra eklenecektir."
            };

            return Ok(response);
        }
    }
}