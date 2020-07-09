using Core.DataAccess.EntitiyFramework;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, OADBContext>, ICategoryDal
    {
    }
}
