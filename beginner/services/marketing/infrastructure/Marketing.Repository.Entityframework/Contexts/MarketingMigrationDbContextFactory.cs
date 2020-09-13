using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Marketing.Repository.EntityFramework.Contexts
{
    public class MarketingMigrationDbContextFactory : IDesignTimeDbContextFactory<MarketingDbContext>
    {
        public MarketingDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MarketingDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Marketing"));

            return new MarketingDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json", optional: false);

            return builder.Build();
        }
    }
}
