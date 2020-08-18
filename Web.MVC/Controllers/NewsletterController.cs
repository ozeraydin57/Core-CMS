using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class NewsletterController : Controller
    {
        private INewsletterService _service;

        public NewsletterController(INewsletterService service)
        {
            _service = service;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            Newsletter data = new Newsletter
            {
                Email = collection["Email"].ToString(),
                CreateDate = DateTime.Now,
                IsActive = true
            };

            _service.Add(data);

            var response = new ResponseModel<Newsletter>
            {
                Data = data,
                Success = true,
                Message = "Bülten kaydınız yapılmıştır.",
            };

            return Ok(response);
        }
    }
}