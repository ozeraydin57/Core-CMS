using Core.Entities;

namespace Tier.Entities.Concrete
{
    public class PostDetail : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int ReadCount { get; set; }
        public int LikeCount { get; set; }
        public int UnlikeCount { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}
