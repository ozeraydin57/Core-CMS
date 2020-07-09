using System.Collections.Generic;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategoryId(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
    }
}
