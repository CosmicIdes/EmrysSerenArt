using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EmrysSerenData
{
    public class ESDbContextFactory : IDesignTimeDbContextFactory<ESDbContext>
    {
        public ESDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ESDbContext>();
            optionsBuilder.UseSqlite("Data Source=Blog.db");

            return new ESDbContext(optionsBuilder.Options);
        }
    }
}