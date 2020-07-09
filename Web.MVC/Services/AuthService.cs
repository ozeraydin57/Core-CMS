using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace Web.MVC.Services
{
    public class AuthService : IAuthService
    {
        private IHttpContextAccessor _httpContextAccessor;
        public AuthService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Login(string userName, string password)
        {

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userName)
            };

            var userIdentity = new ClaimsIdentity(claims, "login");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            var asd = _httpContextAccessor.HttpContext.SignInAsync(principal);

        }
    }
}
