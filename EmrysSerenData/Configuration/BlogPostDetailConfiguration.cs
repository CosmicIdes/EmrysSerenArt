using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmrysSerenData.Configuration
{
    public class BlogPostDetailConfiguration : IEntityTypeConfiguration<BlogPostDetail>
    {
        public void Configure(EntityTypeBuilder<BlogPostDetail> builder)
        {
            builder.HasData
            (
                new BlogPostDetail
                {
                    BlogPostDetailId = 1,
                    BlogPostTitle = "Introduction",
                    BlogPostBody = "Hi, I’m Emrys Seren, also called Emmeryn. I’m a disabled artist from the midwestern United States. I enjoy fantasy and magic especially, so the majority of my works are fantasy. But I also enjoy autobiographical comics. \r\n\r\nI spend quite a lot of time on native restoration in the garden, planting flowers and learning about my local ecosystem. My favorite animal is actually the moth, so the majority of plants are grown for them. \r\n\r\nMy cat, Hoshi, is also called Egg. It’s because she’s egg shaped. She’s the sweetest little cat ever and clings to me while she sleeps. She also follows me around, rubbing against my legs. However sometimes she feels anxiety around other cats and tries to commit atrocities. When this happens she is placed in an alternate room to cool down. What a good cat. \r\n\r\nYou have entered my domain, where the posts will be about things I like, like fantasy, moths, and cats. Welcome. \r\n",
                    BlogPostDate = DateTime.Now,
                    BlogPostTime = DateTime.Now,
                    UserId = 1,
                    BlogTag = new BlogTag
                    {
                        BlogTagId = 1,
                        BlogTagString = "updates"
                    },
                    CommentPost = new CommentPost
                    {
                        CommentPostId = 1,
                        CommentPostBody = "Hello Emmeryn!! Welcome to the internet!",
                        CommentPostDate = DateTime.Now,
                        CommentPostTime = DateTime.Now,
                        User = new User
                        {
                            UserId = 3,
                            UserName = "Calliope Woods",
                            UserEmail = "calliopewoods@gmail.com"
                        }
                    }
                }
            );
        }
    }
}
