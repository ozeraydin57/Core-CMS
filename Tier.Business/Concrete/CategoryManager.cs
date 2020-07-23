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

        public void Add(Category data)
        {

        }

        public void Delete(int id)
        {

        }

        public List<Category> GetAll(string type)
        {
            return _categoryDal.GetList(k => k.Type == type);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(k => k.Id == id);
        }

        public void Update(Category data)
        {

        }
    }
}
