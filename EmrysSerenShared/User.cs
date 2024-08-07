namespace EmrysSerenShared
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public byte[] UserAvatar { get; set; }
        public List<CommentPost> CommentPosts { get; set; }
    }
}
