using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
        //özel sorgu lazım olacak
        List<PostComplex> GetListComplex(int skip,int take, Expression<Func<PostComplex, bool>> filter = null);
        List<PostComplex> GetListComplexByCategoryId(int skip,int take, int categoryId, Expression<Func<PostComplex, bool>> filter = null);
        PostComplex GetComplex(Expression<Func<PostComplex, bool>> filter = null);
    }
}
