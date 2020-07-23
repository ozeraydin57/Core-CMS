using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Business.Abstract;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;
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
            List<Param> setting = _httpContextAccessor.HttpContext.Session.GetObject<List<Param>>(SessionType.param);
            if (setting == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject(SessionType.param, _paramService.GetAll());
                setting = _httpContextAccessor.HttpContext.Session.GetObject<List<Param>>(SessionType.param);
            }
            var ret = setting.Where(k => k.Name == key).FirstOrDefault();
            if (ret != null)
                return ret;
            else
                return new Param(); 
        }
    }
}