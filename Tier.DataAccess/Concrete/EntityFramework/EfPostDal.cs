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
        public List<PostComplex> GetListComplex(int skip, int take)
        {
            using (var context = new OADBContext())
            {
                var post = from p in context.Set<Post>()
                           join pd in context.Set<PostDetail>() on p.Id equals pd.PostId into temp
                           from pdj in temp.DefaultIfEmpty()
                           join u in context.Set<User>() on p.UserId equals u.Id into tempU
                           from uj in tempU.DefaultIfEmpty()
                           where p.IsActive
                           orderby p.CreateDate descending

                           select new PostComplex
                           {
                               Post = p,
                               User = uj ?? new User(),
                               PostDetail = pdj ?? new PostDetail(),
                               Caregories = (
                                       from pc in context.Set<PostCategory>()
                                       join c in context.Set<Category>() on pc.CategoryId equals c.Id
                                       where pc.PostId == p.Id
                                       select c
                               ).ToList() ?? new List<Category>()
                           };

                return post.Skip(skip).Take(take).ToList();
            }
        }
    }
}
