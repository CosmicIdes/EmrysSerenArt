using EmrysSerenShared;

namespace EmrysSerenAPI.Models
{
    public interface ICommentPostRepository
    {
        IEnumerable<CommentPost> GetAllCommentPosts();
        CommentPost GetCommentPostsByBlogId(BlogPostDetail blogPostDetailId);
        CommentPost GetCommentPostsByUserId(User userid);


    }
}
