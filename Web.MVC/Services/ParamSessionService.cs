using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Web.MVC.ExtensionMethods;

namespace Web.MVC.Services
{
    public class ParamSessionService : IParamSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IParamService _paramService;
        public ParamSessionService(IHttpContextAccessor httpContextAccessor, IParamService paramService)
        {
            _httpContextAccessor = httpContextAccessor;
            _paramService = paramService;
        }

        public Param GetParam(string key)
        {
            List<Param> setting = _httpContextAccessor.HttpContext.Session.GetObject<List<Param>>("param");
            if (setting == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("param", _paramService.GetAll());
                setting = _httpContextAccessor.HttpContext.Session.GetObject<List<Param>>("param");
            }
            return setting.Where(k=>k.Name== key).FirstOrDefault();
        }
    }
}
