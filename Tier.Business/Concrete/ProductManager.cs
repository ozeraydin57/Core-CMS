using System;
using System.Collections.Generic;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;
        public ProductManager(IProductDal productDal) => _productDal = productDal;

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(k => k.CategoryId == categoryId || categoryId == 0);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(k => k.ProductId == productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
