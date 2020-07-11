using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
   public interface IPostService
    {
        List<PostComplex> GetAll(int skip, int take);
        PostComplex GetById(int id);
        void Add(Post data);
        void Update(Post data);
        void Delete(int id);
        List<Post> GetByCategoryId(int id);
        List<Post> GetByAuthorId(int id);

    }
}
