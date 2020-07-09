using Core.DataAccess;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        // özel sorgular için categoy ile igili
    }
}
