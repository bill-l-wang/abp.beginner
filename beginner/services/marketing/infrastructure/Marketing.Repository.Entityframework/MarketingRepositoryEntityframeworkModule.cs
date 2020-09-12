using Marketing.Domain;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Marketing.Repository.Entityframework
{
    [DependsOn(
       typeof(MarketingDomainModule),
       typeof(AbpEntityFrameworkCoreModule)
    )]
    public class MarketingRepositoryEntityframeworkModule : AbpModule
    {
        
    }
}
