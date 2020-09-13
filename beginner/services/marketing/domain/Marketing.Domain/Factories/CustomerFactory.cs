using System.Collections.Generic;
using System.Linq;
using Marketing.Domain.Exceptions;
using Marketing.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Marketing.Domain.Factories
{
    public class CustomerFactory : DomainService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerFactory(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Create(string name, string mobile, IList<string> labels)
        {
            if(_customerRepository.Any(c=>c.Mobile == mobile))
                throw new CustomerExistException(mobile);

            var customer = new Customer(GuidGenerator.Create(), name, mobile);

            if (labels == null || !labels.Any()) return customer;

            foreach (var label in labels)
            {
                customer.AddLabel(label);
            }
            
            return customer;
        }
    }
}
