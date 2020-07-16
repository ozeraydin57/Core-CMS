using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Add(Contact data)
        {
            _contactDal.Add(data);
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            //throw new NotImplementedException();
            return _contactDal.GetList().OrderByDescending(k=>k.CreateDate).ToList();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact data)
        {
            //throw new NotImplementedException();
        }
    }
}
