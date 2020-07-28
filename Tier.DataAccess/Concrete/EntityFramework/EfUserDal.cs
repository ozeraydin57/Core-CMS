using Core.DataAccess.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, OADBContext>, IUserDal
    {
    }
}
