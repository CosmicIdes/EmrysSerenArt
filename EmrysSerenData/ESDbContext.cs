using EmrysSerenData.Configuration;
using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmrysSerenData
{
    public class ESDbContext : DbContext
    {
        private readonly IConfiguration Configuration;

        public ESDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

   
        public ESDbContext(DbContextOptions<ESDbContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("BlogDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<BlogPostDetail>()
                .HasMany(e => e.CommentPosts)
                .WithOne(e => e.BlogPostDetail)
                .HasForeignKey(e => e.CommentPostId)
                .HasPrincipalKey(e => e.BlogPostDetailId)
                .OnDelete(DeleteBehavior.Cascade);
            /*
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BlogPostDetailConfiguration());
            */
        }

        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPostDetail> BlogPostDetails { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
      
    }
}
