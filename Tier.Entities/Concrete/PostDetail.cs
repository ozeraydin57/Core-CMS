using Core.Entities;

namespace Tier.Entities.Concrete
{
    public class PostDetail : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
       
    }
}
