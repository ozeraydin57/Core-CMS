using Core.DataAccess;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
        //özel sorgu lazım olacak
    }
}
