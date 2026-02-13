using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Model
{
    [Table("posts")]
    public class Post
    {
        public int id { get; set; }
        [Column("author_name")]
        public string authorName { get; set; } = string.Empty;
        [Column("author_avatar_color")]
        public string authorAvatarColor { get; set; } = string.Empty;
        [Column("image_url")]
        public string imageUrl { get; set; } = string.Empty;
        [Column("created_at")]
        public DateTime createdAt { get; set; }
        public List<Comment> comments { get; set; } = new List<Comment>();
    }
}
