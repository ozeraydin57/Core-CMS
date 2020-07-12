using System;
using System.Collections.Generic;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
           
        }

        public void Delete(int categoryId)
        {
            
        }

        public List<Category> GetAll(string type)
        {
            return _categoryDal.GetList(k=>k.Type==type);
        }

        public List<Category> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            
        }
    }
}
