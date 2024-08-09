using EmrysSerenShared;

namespace EmrysSerenAPI.Models
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPostDetail> GetAllBlogPosts();
        BlogPostDetail GetBlogPostById(int blogPostDetailId);
        BlogPostDetail CreateBlogPost(BlogPostDetail blogPostDetail);
        BlogPostDetail EditBlogPost(BlogPostDetail blogPostDetail);
        //void DeleteBlogPost(int blogPostDetailId);

    }
}
