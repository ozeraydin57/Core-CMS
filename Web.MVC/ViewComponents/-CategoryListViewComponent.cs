using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var list = _categoryService.GetAll();
            var model = new CategoryListViewModel
            {
                Categories=list,
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
