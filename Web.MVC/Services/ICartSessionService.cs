﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;

namespace Web.MVC.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
