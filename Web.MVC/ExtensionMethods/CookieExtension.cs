using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.MVC.ExtensionMethods
{
    public static class CookieExtension
    {
        public static string GetValue(this IRequestCookieCollection request, string cookieName)
        {
            var val = request[cookieName];
            return val;
        }
        public static void SetValue(this IResponseCookies cook, string cookieName, string val = "1")
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddHours(1);
            cook.Append(cookieName, val, cookie);
        }
    }
}
