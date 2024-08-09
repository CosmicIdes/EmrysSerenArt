using EmrysSerenAPI.Models;
using EmrysSerenShared;
using Microsoft.AspNetCore.Mvc;

namespace EmrysSerenAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : Controller
    {

        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostController(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        [HttpGet]
        public IActionResult GetBlogPosts()
        {
            return Ok(_blogPostRepository.GetAllBlogPosts());
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogPostById(int id)
        {
            return Ok(_blogPostRepository.GetBlogPostById(id));
        }

        [HttpPost]
        public IActionResult CreateBlogPost([FromBody] BlogPostDetail blogPostDetail)
        {
            if (blogPostDetail == null)
                return BadRequest();

            if (blogPostDetail.BlogPostTitle == string.Empty)
            {
                ModelState.AddModelError("Blog Post Title", "The blog post title cannot be blank.");
            }

            if (blogPostDetail.BlogPostBody == string.Empty)
            {
                ModelState.AddModelError("Blog Post Body", "The blog post body cannot be blank.");
            }

            if (!ModelState.IsValid)
                return BadRequest();

            var createdBlogPost = _blogPostRepository.CreateBlogPost(blogPostDetail);

            return Created("blogPost", createdBlogPost);
        }

        [HttpPut]
        public IActionResult EditBlogPost([FromBody] BlogPostDetail blogPostDetail)
        {
            if (blogPostDetail == null)
                return BadRequest();

            if (blogPostDetail.BlogPostTitle == string.Empty)
            {
                ModelState.AddModelError("Blog Post Title", "The blog post title cannot be blank.");
            }

            if (blogPostDetail.BlogPostBody == string.Empty)
            {
                ModelState.AddModelError("Blog Post Body", "The blog post body cannot be blank.");
            }

            if (!ModelState.IsValid)
                return BadRequest();

            var blogPostToEdit = _blogPostRepository.GetBlogPostById(blogPostDetail.BlogPostDetailId);

            if (blogPostToEdit == null)
                return NotFound();

            _blogPostRepository.EditBlogPost(blogPostDetail);

            return NoContent();

        }
        /*
        [HttpDelete]
        public IActionResult DeleteBlogPost(int id)
        {
            if (id == 0)
                return BadRequest();

            var blogPostToDelete = _blogPostRepository.GetBlogPostById(id);

            if (blogPostToDelete == null)
                return NotFound();

            _blogPostRepository.DeleteBlogPost(id);

            return NoContent();
        }
        */
    }
}
