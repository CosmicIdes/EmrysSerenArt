namespace EmrysSerenShared
{
    public class CommentPost
    {
        public int CommentPostId { get; set; }
        public string CommentPostBody { get; set; }
        public DateTime CommentPostDate { get; set; }
        public DateTime CommentPostTime { get; set; }
        public int CommentCount { get; set; }

        public User UserId { get; set; }
        public User UserName { get; set; }
        public User UserAvatar { get; set; }

        public BlogPost BlogPostId { get; set; }
        public BlogPost BlogPostTitle { get; set; }
        public BlogPost BlogPostBody { get; set; }
        public BlogPost BlogPostDate { get; set; }
        public BlogPost BlogPostTime { get; set; }
        public BlogPost BlogPostTags { get; set; }
      
    }
}
