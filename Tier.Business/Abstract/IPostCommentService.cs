using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;

namespace Tier.Business.Abstract
{
   public interface IPostCommentService
    {
        List<PostComment> GetAll();
        void Add(PostComment data);
        void Update(PostComment data);
        void Delete(int id);
        PostComment GetById(int id);
    }
}
