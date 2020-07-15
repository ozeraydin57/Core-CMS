using System;
using System.Collections.Generic;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        private IPostDetailDal _postDetailDal;
        public PostManager(IPostDal postDal, IPostDetailDal postDetailDal)
        {
            this._postDal = postDal;
            this._postDetailDal = postDetailDal;
        }

        public void Add(Post data)
        {
            _postDal.Add(data);
        }

        public void Delete(int id)
        {
            _postDal.Delete(new Post { Id = id });
        }

        public int GetAllCount()
        {
            return _postDal.GetList().Count;
        }
        public List<PostComplex> GetAllComplex(int skip, int take)
        {
            return _postDal.GetListComplex(skip, take);
        }
        public PostComplex GetById(int id)
        {
            return _postDal.GetComplex(k=>k.Post.Id==id);
        }


        public List<Post> GetByAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Post data)
        {
            throw new NotImplementedException();
        }
    }
}
