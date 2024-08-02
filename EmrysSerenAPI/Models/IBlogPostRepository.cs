using EmrysSerenShared;

namespace EmrysSerenAPI.Models
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> GetAllBlogPosts();
        BlogPost GetBlogPostById(int blogPostId);
        BlogPost CreateBlogPost(BlogPost blogPost);
        BlogPost EditBlogPost(BlogPost blogPost);
        void DeleteBlogPost(int blogPostId);

    }
}
