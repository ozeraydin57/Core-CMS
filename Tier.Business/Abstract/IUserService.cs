using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
   public interface IUserService
    {
        List<User> GetAll();
        void Add(User data);
        void Update(User data);
        User GetById(int id);
    }
}
