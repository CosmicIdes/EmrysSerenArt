using EmrysSerenShared;
using EmrysSerenData;

namespace EmrysSerenAPI.Models
{
    public class CommentPostRepository : ICommentPostRepository
    {
        private readonly ESDbContext _esDbContext;

        public CommentPostRepository(ESDbContext esDbContext)
        {
            _esDbContext = esDbContext;
        }

        public IEnumerable<CommentPost> GetAllCommentPosts()
        {
            return _esDbContext.CommentPosts;
        }
        /*
        public CommentPost GetCommentPostsByBlogId(BlogPostDetail blogPostDetailId)
        {
            return _esDbContext.CommentPosts.FirstOrDefault(c => c.BlogPostDetailId == blogPostDetailId);
        }

        public CommentPost GetCommentPostsByUserId(User userId)
        {
            return _esDbContext.CommentPosts.FirstOrDefault(u => u.UserId == userId);
        }
        */
    }
}
