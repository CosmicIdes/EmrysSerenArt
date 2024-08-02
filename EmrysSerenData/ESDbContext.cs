using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmrysSerenData
{
    public class ESDbContext : DbContext
    {
        public ESDbContext(DbContextOptions<ESDbContext> options) : base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }  
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }

        protected readonly IConfiguration Configuration;

        public ESDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("BlogDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
