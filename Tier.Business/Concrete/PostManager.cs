using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.ComplexType;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            this._postDal = postDal;
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
            return _postDal.GetList(k => k.IsActive == true).Count;
        }
        public List<PostComplex> GetAllComplex(int skip, int take)
        {
            return _postDal.GetListComplex(skip, take);
        }
        public List<PostComplex> GetAllComplexByCategoryId(int skip, int take, int categoryId)
        {
            return _postDal.GetListComplexByCategoryId(skip, take, categoryId);
        }
        public List<PostComplex> GetAllComplexByUserId(int skip, int take, int userId)
        {
            return _postDal.GetListComplex(skip, take, k => k.Post.UserId == userId);
        }

        public PostComplex GetComplexById(int id)
        {
            return _postDal.GetComplex(k => k.Post.Id == id);
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
            _postDal.Update(data);
        }

        public Post GetById(int id)
        {
            return _postDal.Get(k => k.Id == id);
        }
    }
}
