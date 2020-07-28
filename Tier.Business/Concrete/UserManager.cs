using System;
using System.Collections.Generic;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal) => _userDal = userDal;

        public void Add(User data)
        {
            _userDal.Add(data);
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetById(int id)
        {
            return _userDal.Get(k => k.Id == id);
        }

        public void Update(User data)
        {
            _userDal.Update(data);
        }
    }
}
