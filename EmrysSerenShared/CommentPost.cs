namespace EmrysSerenShared
{
    public class CommentPost
    {
        public int CommentPostId { get; set; }
        public string CommentPostBody { get; set; }
        public DateTime CommentPostDate { get; set; }
        public DateTime CommentPostTime { get; set; }
        public int CommentCount { get; set; }
        public BlogPostDetail BlogPostDetail { get; set; }
        public User User { get; set; }
    }
}
