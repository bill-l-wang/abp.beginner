using Marketing.Domain;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Marketing.Application
{
    [DependsOn(
        typeof(MarketingDomainModule),
        typeof(AbpAutoMapperModule)
        )]
    public class MarketingApplicationModule : AbpModule
    {

    }
}
