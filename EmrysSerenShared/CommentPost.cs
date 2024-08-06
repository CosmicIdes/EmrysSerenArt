namespace EmrysSerenShared
{
    public class CommentPost
    {
        public int CommentPostId { get; set; }
        public string CommentPostBody { get; set; }
        public DateTime CommentPostDate { get; set; }
        public DateTime CommentPostTime { get; set; }
        public int CommentCount { get; set; }
        public BlogPost BlogPostId { get; set; }
        public User UserId { get; set; }
    }
}
