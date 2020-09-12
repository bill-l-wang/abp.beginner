using Marketing.Application.Contracts.Dtos;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Marketing.Application.Contracts.Services
{
    public interface ICustomerAppService : IApplicationService
    {
        Task AddCustomer(AddCustomerInput input);
    }
}
