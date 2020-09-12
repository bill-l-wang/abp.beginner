using Marketing.Application.Contracts.Dtos;
using Marketing.Application.Contracts.Services;
using Marketing.Domain.Factories;
using Marketing.Domain.Repositories;
using System.Threading.Tasks;

namespace Marketing.Application
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerFactory _customerFactory;

        public CustomerAppService(
            ICustomerRepository customerRepository,
            CustomerFactory customerFactory)
        {
            _customerRepository = customerRepository;
            _customerFactory = customerFactory;
        }

        public async Task AddCustomer(AddCustomerInput input)
        {
            var customer = _customerFactory.Create(input.Name, input.Mobile, null);
            await _customerRepository.InsertAsync(customer);
        }
    }
}
