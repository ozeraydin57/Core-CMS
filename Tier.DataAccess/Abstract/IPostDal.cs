using Core.DataAccess;
using System.Collections.Generic;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
        //özel sorgu lazım olacak
        List<PostComplex> GetListComplex(); 
    }
}
