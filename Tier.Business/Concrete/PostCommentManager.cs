using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class PostCommentManager : IPostCommentService
    {
        private IPostCommentDal _contactDal;

        public PostCommentManager(IPostCommentDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Add(PostComment data)
        {
            _contactDal.Add(data);
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public List<PostComment> GetAll()
        {
            //throw new NotImplementedException();
            return _contactDal.GetList().OrderByDescending(k => k.CreateDate).ToList();
        }

        public List<PostComment> GetAllByPostId(int postId)
        {
            return _contactDal.GetList(k => k.PostId == postId).OrderByDescending(k => k.CreateDate).ToList();
        }

        public PostComment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostComment data)
        {
            //throw new NotImplementedException();
        }

    }
}
