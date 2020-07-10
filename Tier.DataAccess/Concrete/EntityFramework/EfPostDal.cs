using Core.DataAccess.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Concrete.EntityFramework
{
    public class EfPostDal : EfEntityRepositoryBase<Post, OADBContext>, IPostDal
    {
        public List<PostComplex> GetListComplex()
        {
            using (var context = new OADBContext())
            {
                var post = from p in context.Set<Post>()
                           join d in context.Set<PostDetail>() on p.Id equals d.PostId into temp
                           from j in temp.DefaultIfEmpty()
                           where p.IsActive
                           orderby p.CreateDate descending
                           select new PostComplex
                           {
                               Post = p,
                               PostDetail = j ?? new PostDetail(),
                               Caregories = (
                                       from pc in context.Set<PostCategory>()
                                       join c in context.Set<Category>() on pc.CategoryId equals c.Id
                                       where pc.PostId == p.Id
                                       select c
                               ).ToList() ?? new List<Category>()
                           };

                return post.ToList();
            }
        }
    }
}
