using System;
using System.Threading.Tasks;
using Marketing.Application.Contracts.Inputs;
using Marketing.Application.Contracts.OutPuts;
using Volo.Abp.Application.Services;

namespace Marketing.Application.Contracts.Services
{
    public interface ICustomerAppService : IApplicationService
    {
        Task AddCustomer(AddCustomerInput input);

        Task<CustomerOutput> GetCustomerById(Guid id);
    }
}
