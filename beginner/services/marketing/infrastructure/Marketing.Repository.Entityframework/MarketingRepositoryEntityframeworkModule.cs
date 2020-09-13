using Marketing.Domain;
using Marketing.Repository.EntityFramework.Contexts;
using Marketing.Repository.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Marketing.Repository.EntityFramework
{
    [DependsOn(
       typeof(MarketingDomainModule),
       typeof(AbpEntityFrameworkCoreModule)
    )]
    public class MarketingRepositoryEntityFrameworkModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MarketingDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
                options.AddRepository<Customer, CustomerRepository>();
            });
        }
    }
}
