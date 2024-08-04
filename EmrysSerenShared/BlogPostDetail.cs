namespace EmrysSerenShared
{
    public class BlogPostDetail
	{
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostBody { get; set; }
        public DateTime BlogPostDate { get; set; }
        public DateTime BlogPostTime { get; set; }
        public BlogPost BlogPost { get; set; }

        public int BlogTagId { get; set; }
        public string BlogTagString { get; set; }
        public BlogTag BlogTag { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public byte[] UserAvatar { get; set; }
        public User User { get; set; }

        public int CommentPostId { get; set; }
        public string CommentPostBody { get; set; }
        public DateTime CommentPostDate { get; set; }
        public DateTime CommentPostTime { get; set; }
        public int CommentCount { get; set; }
        public ICollection<CommentPost> CommentPosts { get; set; }
        public CommentPost CommentPost { get; set; }
    }
}

