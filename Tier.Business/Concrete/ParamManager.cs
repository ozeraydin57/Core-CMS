using System;
using System.Collections.Generic;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;

namespace Tier.Business.Concrete
{
    public class ParamManager : IParamService
    {
        private IParamDal _settingDal;
        public ParamManager(IParamDal settingDal) => _settingDal = settingDal;

        public void Add(Param data)
        {
            _settingDal.Add(data);
        }

        public void Delete(int id)
        {
            _settingDal.Delete(new Param { Id = id });
        }

        public List<Param> GetAll()
        {
            return _settingDal.GetList();
        }

        public Param GetById(int id)
        {
            return _settingDal.Get(k => k.Id == id);
        }

        public void Update(Param data)
        {
            _settingDal.Update(data);
        }
    }
}
