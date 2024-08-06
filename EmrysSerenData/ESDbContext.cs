using EmrysSerenData.Configuration;
using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmrysSerenData
{
    public class ESDbContext : DbContext
    {
        private readonly string _connectionString;

        public ESDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ESDbContext(DbContextOptions<ESDbContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPostDetail>().HasKey(bd => new
            {
                bd.BlogPostId,
                bd.CommentPostId,
                bd.UserId
            });
            modelBuilder.ApplyConfiguration(new BlogPostDetailConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPostDetail> BlogPostDetails { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
      
    }
}
