using Marketing.Repository.EntityFramework.Mappings;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Marketing.Repository.EntityFramework.Contexts
{
    public class MarketingMigrationDbContext : AbpDbContext<MarketingMigrationDbContext>
    {
        public MarketingMigrationDbContext(DbContextOptions<MarketingMigrationDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigCustomerMapping();
            modelBuilder.ConfigCustomerLabelMapping();
        }
    }
}
