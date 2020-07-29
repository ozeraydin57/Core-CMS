using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;

namespace Web.MVC.ViewComponents
{
    public class AuthorBoxViewComponent : ViewComponent
    {

        private IUserService _userService;
        public AuthorBoxViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public ViewViewComponentResult Invoke(int userId)
        {
            var model = new ResponseModel<User>
            {
                Success = true,
                Data = _userService.GetById(userId)
            };

            return View(model);
        }
    }
}
