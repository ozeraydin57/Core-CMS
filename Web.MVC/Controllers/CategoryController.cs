using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.ComplexType;
using Tier.Entities.Concrete;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        private IParamSessionService _paramSessionService;
        public CategoryController(IParamSessionService paramSessionService, ICategoryService categoryService)
        {
            _paramSessionService = paramSessionService;
            _categoryService = categoryService;
        }

        [Route("Category/{categoryId:int}")]
        public ActionResult Index(int categoryId)
        {
            var cat = _categoryService.GetById(categoryId);

            var model = new CategoryViewModel
            {
                Title = cat.Name,
                Description = cat.Summary,
                Keywords = cat.Name,
                Author = _paramSessionService.GetParam("Author").Description,
                Category = cat
            };

            return View(model);
        }
    }
}
