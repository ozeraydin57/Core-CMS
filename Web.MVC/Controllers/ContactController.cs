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
    public class ContactController : Controller
    {

        private IContactService _contactService;
        private IParamSessionService _paramSessionService;
        public ContactController(IContactService contactService, IParamSessionService paramSessionService)
        {
            _contactService = contactService;
            _paramSessionService = paramSessionService;
        }

        public IActionResult Index()
        {
            var model = new ContactViewModel
            {
                MetaTitle = _paramSessionService.GetParam(ParamType.Title).Description,
                MetaDescription = _paramSessionService.GetParam(ParamType.Description).Description,
                MetaKeywords = _paramSessionService.GetParam(ParamType.Keywords).Description,
                MetaAuthor = _paramSessionService.GetParam(ParamType.Author).Description,
            };
            return View(model);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            Contact data = new Contact
            {
                Name = collection["Name"].ToString(),
                Email = collection["Email"].ToString(),
                Phone = collection["Phone"].ToString(),
                Subject = collection["Subject"].ToString(),
                Message = collection["Message"].ToString(),
                CreateDate = DateTime.Now
            };

            _contactService.Add(data);

            var response = new ContactViewModel
            {
                Contact = data,
                Success = true,
                Message = "Mesajınız ilgili kişilere iletilmiştir.",
            };

            return Ok(response);
        }
    }
}
