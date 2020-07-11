using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;
using Web.MVC.Models;
using Web.MVC.Services;

namespace Web.MVC.ViewComponents
{
    public class ParamViewComponent : ViewComponent
    {
        private IParamSessionService _settingService;
        public ParamViewComponent(IParamSessionService settingService)
        {
            _settingService = settingService;
        }

        public ViewViewComponentResult Invoke(string key)
        {
            var value = _settingService.GetParam(key)?? new Param();

            var model = new ParamsViewModel
            {
                Key = value.Name,
                Value =value.Description
            };
            return View(model);
        }
    }
}
