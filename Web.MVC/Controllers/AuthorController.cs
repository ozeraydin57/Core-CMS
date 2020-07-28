using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.Services;

namespace Web.MVC.Controllers
{
    public class AuthorController : Controller
    {

        private IParamSessionService _paramSessionService;
        private IUserService _userService;
        public AuthorController(IParamSessionService paramSessionService, IUserService userService)
        {
            _paramSessionService = paramSessionService;
            _userService = userService;
        }

        [Route("u/{userId:int}")]
        public IActionResult Index(int userId)
        {
            var user = _userService.GetById(userId);
            var response = new ResponseModel<User>
            {
                Title = "User" + _paramSessionService.GetParam("Title").Description,
                Description = _paramSessionService.GetParam("Description").Description,
                Keywords = _paramSessionService.GetParam("Keywords").Description,
                Author = _paramSessionService.GetParam("Author").Description,
                Data = user
            };


            return View(response);
        }
    }
}