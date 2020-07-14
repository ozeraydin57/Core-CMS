using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class Menu : IEntity
    {
        public int Id { get; set; }
        public int ParentMenuId { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
        public int OrderNo { get; set; }
        public string Type { get; set; }
    }
}
