using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }

}
