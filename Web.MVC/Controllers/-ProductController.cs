using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Web.MVC.Models;

namespace Web.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int page=1, int category=0)
        {
            int pageSize = 10;
            var list = _productService.GetByCategoryId(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = list.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount =  (int)Math.Ceiling(list.Count/(double)pageSize),
                Pagesize= pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };
            return View(model);
        }

        //public IActionResult AddToCart()
        //{

        //}
    }
}
