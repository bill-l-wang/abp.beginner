using Marketing.Domain;
using Marketing.Repository.EntityFramework.Mappings;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Marketing.Repository.EntityFramework.Contexts
{
    [ConnectionStringName("Marketing")]
    public class MarketingDbContext : AbpDbContext<MarketingDbContext>, IMarketingDbContext
    {
        public MarketingDbContext(DbContextOptions<MarketingDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerLabel> CustomerLabels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ConfigCustomerMapping();
            builder.ConfigCustomerLabelMapping();
        }
    }
}
