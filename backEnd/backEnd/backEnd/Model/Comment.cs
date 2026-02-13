using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Model
{
    [Table("comments")]
    public class Comment
    {
        public int id { get; set; }
        [Column("post_id")]
        public int postId { get; set; }
        [Column("commenter_name")]
        public string commenterName { get; set; } = string.Empty;
        [Column("commenter_avatar_color")]
        public string commenterAvatarColor { get; set; } = string.Empty;
        [Column("content")]
        public string content { get; set; } = string.Empty;
        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
