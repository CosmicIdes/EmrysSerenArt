using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace EmrysSerenData
{
    public class ESDbContextFactory : IDesignTimeDbContextFactory<ESDbContext>
    {
        public ESDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ESDbContext>();

            var connectionString = configuration.GetConnectionString("BlogDB");

            optionsBuilder.UseSqlite(connectionString);

            return new ESDbContext(optionsBuilder.Options);
        }
    }
}