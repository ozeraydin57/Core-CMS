using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.Entities.ComplexType
{
    public class PostComplex
    {
        public Post Post { get; set; }
        public User User { get; set; }
        public PostDetail PostDetail { get; set; }
        public List<Category> Caregories { get; set; }
    }
}
