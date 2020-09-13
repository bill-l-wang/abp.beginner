using Marketing.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Marketing.Repository.EntityFramework.Contexts
{
    [ConnectionStringName("Marketing")]
    public interface IMarketingDbContext : IEfCoreDbContext
    {
        DbSet<Customer> Customers { get; }
    }
}
