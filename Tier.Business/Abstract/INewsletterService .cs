using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;

namespace Tier.Business.Abstract
{
   public interface INewsletterService
    {
        List<Newsletter> GetAll();
        void Add(Newsletter data);
        void Update(Newsletter data);
        void Delete(int id);
        Newsletter GetById(int id);
    }
}
