using EmrysSerenData.Configuration;
using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmrysSerenData
{
    public class ESDbContext : DbContext
    {

        public ESDbContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            var DbPath = Path.Join(path, "Blog.db");
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPostDetail>()
                .ToTable("BlogPostDetail");

            modelBuilder.Entity<User>()
                .ToTable("User");

            modelBuilder.Entity<CommentPost>()
                .ToTable("CommentPost");

            modelBuilder.Entity<BlogTag>()
                .ToTable("BlogTag");
            
            modelBuilder.Entity<BlogPostDetail>()
                .HasMany(e => e.CommentPosts)
                .WithOne(e => e.BlogPostDetail)
                .HasForeignKey(e => e.CommentPostId)
                .HasPrincipalKey(e => e.BlogPostDetailId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BlogPostDetailConfiguration());
        }

    

        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPostDetail> BlogPostDetails { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
      
    }
}
