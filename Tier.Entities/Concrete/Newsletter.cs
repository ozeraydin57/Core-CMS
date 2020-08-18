using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class Newsletter : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
