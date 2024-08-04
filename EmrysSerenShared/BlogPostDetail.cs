namespace EmrysSerenShared
{
    public class BlogPostDetail
	{
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostBody { get; set; }
        public DateTime BlogPostDate { get; set; }
        public DateTime BlogPostTime { get; set; }
        public string[] BlogPostTags { get; set; }
        public BlogPost BlogPost { get; set; }

        public User UserId { get; set; }
        public User UserName { get; set; }
        public User UserAvatar { get; set; }
        public User User { get; set; }

        public CommentPost CommentPostId { get; set; }
        public CommentPost CommentCount { get; set; }
        public ICollection<CommentPost> CommentPosts { get; set; }
        public CommentPost CommentPost { get; set; }
    }
}

