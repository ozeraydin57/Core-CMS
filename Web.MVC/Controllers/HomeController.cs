using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tier.Entities.EnType;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class HomeController : Controller
    {

        private IParamSessionService _paramSessionService;

        public HomeController(IParamSessionService paramSessionService)
        {
            _paramSessionService = paramSessionService;
        }

        public IActionResult Index() //?Page=0&
        {
            var model = new HomeViewModel
            {
                MetaTitle = _paramSessionService.GetParam(ParamType.Title).Description,
                MetaDescription = _paramSessionService.GetParam(ParamType.Description).Description,
                MetaKeywords = _paramSessionService.GetParam(ParamType.Keywords).Description,
                MetaAuthor = _paramSessionService.GetParam(ParamType.Author).Description,
            };
            return View(model);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
