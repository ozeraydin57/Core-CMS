using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Tier.Business.Abstract;
using Tier.DataAccess.Abstract;
using Tier.Entities.Concrete;
using Tier.Entities.EnType;

namespace Tier.Business.Concrete
{
    public class MenuManager : IMenuService
    {
        private IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal) => _menuDal = menuDal;

        public void Add(Menu menu)
        {
            _menuDal.Add(menu);
        }

        public void Delete(int menuId)
        {
            _menuDal.Delete(new Menu { Id = menuId });
        }

        public List<Menu> GetAll()
        {
            return _menuDal.GetList().OrderBy(k => k.OrderNo).ToList();
        }
        public List<Menu> GetAllByType(MenuType type)
        {
            return _menuDal.GetList(k => k.Type == type.ToString()).OrderBy(k => k.OrderNo).ToList();
        }

        public Menu GetById(int menuId)
        {
            return _menuDal.Get(K => K.Id == menuId);
        }

        public void Update(Menu menu)
        {
            _menuDal.Update(menu);
        }
    }
}
