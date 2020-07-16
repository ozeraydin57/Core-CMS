using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;

namespace Tier.Business.Abstract
{
   public interface IContactService
    {
        List<Contact> GetAll();
        void Add(Contact data);
        void Update(Contact data);
        void Delete(int id);
        Contact GetById(int id);
    }
}
