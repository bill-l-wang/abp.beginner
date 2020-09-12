using Marketing.Domain;
using Marketing.Domain.Repositories;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Marketing.Repository.Entityframework
{
    public class CustomerRepository : EfCoreRepository<MarketingDbContext, Customer, Guid>, ICustomerRepository
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerRepository(IDbContextProvider<MarketingDbContext> dbContextProvider)
            :base(dbContextProvider)
        {
            
        }
    }
}
