using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmrysSerenShared
{
    public class BlogPostDetail
	{
        public int BlogPostId { get; set; }
        [Required]
        public string BlogPostTitle { get; set; }
        [Required]
        public string BlogPostBody { get; set; }
        [Required]
        public DateTime BlogPostDate { get; set; }
        public DateTime BlogPostTime { get; set; }
        public BlogPost BlogPost { get; set; }

        public int BlogTagId { get; set; }
        public BlogTag BlogTag { get; set; }

        public int UserId { get; set; }
        [Required]
        public User User { get; set; }

        [NotMapped]
        public CommentPost? CommentPostId { get; set; }
        public CommentPost CommentPost { get; set; }
    }
}

