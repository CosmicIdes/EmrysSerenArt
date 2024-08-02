using EmrysSerenShared;

namespace EmrysSerenAPI.Models
{
    public interface ICommentPostRepository
    {
        IEnumerable<CommentPost> GetAllCommentPosts();
        CommentPost GetCommentPostsByBlogId(BlogPost blogPostid);
        CommentPost GetCommentPostsByUserId(User userid);


    }
}
