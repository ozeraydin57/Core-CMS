using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        private INewsletterDal _dataDal;

        public NewsletterManager(INewsletterDal dataDal)
        {
            _dataDal = dataDal;
        }
        public void Add(Newsletter data)
        {
            var list = _dataDal.GetList(k => k.Email == data.Email);
            foreach (var item in list)
                _dataDal.Delete(item);

            _dataDal.Add(data);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> GetAll()
        {
            throw new NotImplementedException();
        }

        public Newsletter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Newsletter data)
        {
            throw new NotImplementedException();
        }
    }
}
