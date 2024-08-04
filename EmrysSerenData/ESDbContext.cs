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

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
        }
    }
}
