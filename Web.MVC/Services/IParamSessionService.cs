using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;

namespace Web.MVC.Services
{
    public interface IParamSessionService
    {
        Param GetParam(ParamType key);
    }
}