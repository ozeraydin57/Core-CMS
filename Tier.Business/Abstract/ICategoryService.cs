using System.Collections.Generic;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(string type);
        Category GetById(int id);
        void Add(Category data);
        void Update(Category data);
        void Delete(int id);
    }
}
