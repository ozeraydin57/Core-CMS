using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.EnType;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class FooterMenuViewComponent : ViewComponent
    {
        private IMenuService _menuService;
        public FooterMenuViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new MenuViewModel
            {
                Menus = _menuService.GetAllByType(MenuType.footer)
            };

            return View(model);
        }
    }
}
