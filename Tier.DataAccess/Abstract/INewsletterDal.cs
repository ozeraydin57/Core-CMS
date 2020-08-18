using Core.DataAccess;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Abstract
{
    public interface INewsletterDal : IEntityRepository<Newsletter>
    {
    }
}
