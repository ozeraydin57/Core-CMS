using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
   public interface IPostService
    {
        List<Post> GetAll();
        List<PostComplex> GetAllComplex();
        void Add(Post data);
        void Update(Post data);
        void Delete(int id);
        Post GetById(int id);

        List<Post> GetByCategoryId(int id);
        List<Post> GetByAuthorId(int id);

    }
}
