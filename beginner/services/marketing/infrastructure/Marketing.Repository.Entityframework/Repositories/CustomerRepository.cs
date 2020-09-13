using System;
using Marketing.Domain;
using Marketing.Domain.Repositories;
using Marketing.Repository.EntityFramework.Contexts;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Marketing.Repository.EntityFramework.Repositories
{
    public class CustomerRepository : EfCoreRepository<MarketingDbContext, Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<MarketingDbContext> dbContextProvider)
            :base(dbContextProvider)
        {
            
        }
    }
}
