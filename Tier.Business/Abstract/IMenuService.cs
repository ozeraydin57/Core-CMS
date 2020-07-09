using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Business.Abstract
{
   public interface IMenuService
    {
        List<Menu> GetAll();
        void Add(Menu menu);
        void Update(Menu menu);
        void Delete(int menuId);
        Menu GetById(int menuId);
    }
}
