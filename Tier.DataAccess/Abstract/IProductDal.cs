using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // özel sorgular için product ile igili
    }
}
