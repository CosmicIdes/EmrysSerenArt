namespace EmrysSerenShared
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; } 
        public string BlogPostBody { get; set; }
        public DateTime BlogPostDate { get; set; }
        public DateTime BlogPostTime { get; set; }
        public string[] BlogPostTags { get; set; }

    }
}
