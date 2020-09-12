using System;
using Volo.Abp.Domain.Repositories;

namespace Marketing.Domain.Repositories
{
    public interface ICustomerRepository: IRepository<Customer, Guid>
    {

    }
}
