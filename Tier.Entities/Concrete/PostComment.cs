using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class PostComment : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Web { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
