using Marketing.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Marketing.Repository.Entityframework
{
    public interface IMarketingDbContext : IEfCoreDbContext
    {
        DbSet<Customer> Customers { get; }
    }
}
