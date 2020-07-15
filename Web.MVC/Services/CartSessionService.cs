using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;
using Web.MVC.ExtensionMethods;

namespace Web.MVC.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;
        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(SessionType.cart);
            if (cart == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject(SessionType.cart, new Cart());
                cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(SessionType.cart);
            }
            return cart;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(SessionType.cart, cart);
        }
    }
}
