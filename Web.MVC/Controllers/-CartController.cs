using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class CartController : Controller
    {
        ICartSessionService _cartSessionService;
        ICartService _cartService;
        IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            this._cartSessionService = cartSessionService;
            this._cartService = cartService;
            this._productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, product);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", "ürününüz eklendi " + product.ProductName);

            return RedirectToAction("Index", "Product");
        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel model = new CartSummaryViewModel
            {
                Cart = cart
            };

            return View(model);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Ürün sepetinizden silindi!"));
            return RedirectToAction("List");
        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Teşekkürler {0}, siparişiniz alındı.", shippingDetails.FirstName));
            return View();
        }

    }
}