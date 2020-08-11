    <>s>E4RFQQS<using Microsoft.AspNetCore.Mvc;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;
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
                MetaTitle = "User" + _paramSessionService.GetParam(ParamType.Title).Description,
                MetaDescription = _paramSessionService.GetParam(ParamType.Description).Description,
                MetaKeywords = _paramSessionService.GetParam(ParamType.Keywords).Description,
                MetaAuthor = _paramSessionService.GetParam(ParamType.Author).Description,
                Data = user
            };

            return View(response);
        }
    }
}