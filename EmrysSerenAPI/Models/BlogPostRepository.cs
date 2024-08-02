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

        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            return _esDbContext.BlogPosts;
        }

        public BlogPost GetBlogPostById(int blogPostId)
        {
            return _esDbContext.BlogPosts.FirstOrDefault(b => b.BlogPostId == blogPostId);
        }

        public BlogPost CreateBlogPost(BlogPost blogPost)
        {
            var addedEntity = _esDbContext.BlogPosts.Add(blogPost);
            _esDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public BlogPost EditBlogPost(BlogPost blogPost)
        {
            var foundBlogPost = _esDbContext.BlogPosts.FirstOrDefault(p => p.BlogPostId == blogPost.BlogPostId);

            if (foundBlogPost != null)
            {
                foundBlogPost.BlogPostId = blogPost.BlogPostId;
                foundBlogPost.BlogPostTitle = blogPost.BlogPostTitle;
                foundBlogPost.BlogPostBody = blogPost.BlogPostBody;
                foundBlogPost.BlogPostTags = blogPost.BlogPostTags;
                foundBlogPost.BlogPostDate = blogPost.BlogPostDate;
                foundBlogPost.BlogPostTime = blogPost.BlogPostTime;

                _esDbContext.SaveChanges();
                return foundBlogPost;
            }
            return null;
        }

        public void DeleteBlogPost(int BlogPostId)
        {
            var foundBlogPost = _esDbContext.BlogPosts.FirstOrDefault(p => p.BlogPostId == BlogPostId);
            if (foundBlogPost == null) return;

            _esDbContext.BlogPosts.Remove(foundBlogPost);
            _esDbContext.SaveChanges();

        }
    }
}
