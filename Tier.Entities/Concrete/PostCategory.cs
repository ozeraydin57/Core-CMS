using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class PostCategory : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
    }
}
