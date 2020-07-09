using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class Param : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}

