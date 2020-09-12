using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Marketing.Application.Contracts
{
    [DependsOn(typeof(AbpDddApplicationModule))]
    public class MarketingApplicationContractsModule : AbpModule
    {
    }
}