using System;
using Marketing.Application.Contracts.Services;
using Marketing.Domain.Factories;
using Marketing.Domain.Repositories;
using System.Threading.Tasks;
using Marketing.Application.Contracts.Inputs;
using Marketing.Application.Contracts.OutPuts;
using Volo.Abp.DependencyInjection;

namespace Marketing.Application
{
    public class CustomerAppService : ICustomerAppService, ITransientDependency
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

        public async Task<CustomerOutput> GetCustomerById(Guid id)
        {
            var customer = await _customerRepository.FindAsync(id);

            if (customer == null)
                return null;

            return new CustomerOutput()
            {
                Id = customer.Id,
                Name = customer.Name,
                Mobile = customer.Mobile
            };
        }
    }
}
