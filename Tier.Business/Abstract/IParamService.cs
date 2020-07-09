using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
   public interface IParamService
    {
        List<Param> GetAll();
        void Add(Param data);
        void Update(Param data);
        void Delete(int id);
        Param GetById(int id);
    }
}
