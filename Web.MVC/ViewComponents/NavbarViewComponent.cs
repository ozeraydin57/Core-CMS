using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.DataAccess.Concrete.EntityFramework;
using Tier.Entities.EnType;
using Web.MVC.Models;

namespace Web.MVC.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private IMenuService _menuService;
        public NavbarViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new MenuViewModel
            {
                Menus = _menuService.GetAllByType(MenuType.main)
            };

            return View(model);
        }
    }
}
