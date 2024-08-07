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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BlogPostDetail>()
                .Property(e => e.CommentPostId)
                .HasConversion(
                    v => v.ToString(), 
                    v => (CommentPost)Enum.Parse(typeof(CommentPost), v));

            modelBuilder.Entity<BlogPostDetail>().HasKey(bd => new
            {
                bd.BlogPostId,
                bd.CommentPostId,
                bd.UserId,
                bd.BlogTagId
            });
            
            modelBuilder.ApplyConfiguration(new BlogPostDetailConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BlogTagConfiguration());
            
            
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPostDetail> BlogPostDetails { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
      
    }
}
