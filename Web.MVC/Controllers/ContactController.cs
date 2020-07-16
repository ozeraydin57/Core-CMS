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
    public class ContactController : Controller
    {

        private IContactService _contactService;
        public ContactController(IContactService contactService) => _contactService = contactService;

        public IActionResult Index()
        {
            return View();
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
                Message = "Mesajınız ilgili kişilere iletilmiştir."
            };

            return Ok(response);
        }
    }
}
