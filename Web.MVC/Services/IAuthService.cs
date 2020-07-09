using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.MVC.Services
{
    public interface IAuthService
    {
        void Login(string userName, string password);
    }
}
