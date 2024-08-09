using EmrysSerenShared;
using EmrysSerenData;

namespace EmrysSerenAPI.Models
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ESDbContext _esDbContext;

        public BlogPostRepository(ESDbContext esDbContext)
        {
            _esDbContext = esDbContext;
        }

        public IEnumerable<BlogPostDetail> GetAllBlogPosts()
        {
            return _esDbContext.BlogPostDetails;
        }

        public BlogPostDetail GetBlogPostById(int blogPostDetailId)
        {
            return _esDbContext.BlogPostDetails.FirstOrDefault(b => b.BlogPostDetailId == blogPostDetailId);
        }

        public BlogPostDetail CreateBlogPost(BlogPostDetail blogPostDetail)
        {
            var addedEntity = _esDbContext.BlogPostDetails.Add(blogPostDetail);
            _esDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public BlogPostDetail EditBlogPost(BlogPostDetail blogPostDetail)
        {
            var foundBlogPost = _esDbContext.BlogPostDetails.FirstOrDefault(p => p.BlogPostDetailId == blogPostDetail.BlogPostDetailId);

            if (foundBlogPost != null)
            {
                foundBlogPost.BlogPostDetailId = blogPostDetail.BlogPostDetailId;
                foundBlogPost.BlogPostTitle = blogPostDetail.BlogPostTitle;
                foundBlogPost.BlogPostBody = blogPostDetail.BlogPostBody;
                foundBlogPost.BlogPostDate = blogPostDetail.BlogPostDate;
                foundBlogPost.BlogPostTime = blogPostDetail.BlogPostTime;

                _esDbContext.SaveChanges();
                return foundBlogPost;
            }
            return null;
        }
        
        public void DeleteBlogPost(int blogPostDetailId)
        {
            var foundBlogPost = _esDbContext.BlogPostDetails.FirstOrDefault(p => p.BlogPostDetailId == blogPostDetailId);
            if (foundBlogPost == null) return;

            _esDbContext.BlogPostDetails.Remove(foundBlogPost);
            _esDbContext.SaveChanges();

        }
        
    }
}
