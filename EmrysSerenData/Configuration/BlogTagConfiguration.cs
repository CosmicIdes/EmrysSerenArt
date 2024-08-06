using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmrysSerenData.Configuration
{
    public class BlogTagConfiguration : IEntityTypeConfiguration<BlogTag>
    {
        public void Configure(EntityTypeBuilder<BlogTag> builder)
        {
            builder.HasData
            (
                new BlogTag
                {
                    BlogTagId = 1,
                    BlogTagString = "updates" 
                },
                new BlogTag
                {
                    BlogTagId = 2,
                    BlogTagString = "posts"
                }
            );
        }
    }
}
