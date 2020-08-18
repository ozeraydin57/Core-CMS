using Core.DataAccess.EntitiyFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Concrete.EntityFramework
{
    public class EfNewsletterDal : EfEntityRepositoryBase<Newsletter, OADBContext>, INewsletterDal
    {
       
    }
}
