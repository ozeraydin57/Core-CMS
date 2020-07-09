using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
