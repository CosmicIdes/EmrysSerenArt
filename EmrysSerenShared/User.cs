namespace EmrysSerenShared
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public byte[] UserAvatar { get; set; }

        public BlogPost BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public BlogPost BlogPostTitle { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
        public ICollection<CommentPost> CommentPosts { get; set; } 

    }
}
