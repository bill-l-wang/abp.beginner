using System.Collections.Generic;
using Volo.Abp.Domain.Services;

namespace Marketing.Domain.Factories
{
    public class CustomerFactory : DomainService
    {
        public Customer Create(string name, string mobile, IEnumerable<string> labels)
        {
            var customer = new Customer(GuidGenerator.Create(), name, mobile);
            foreach (var label in labels)
                customer.AddLabel(new CustomerLabel(customer.Id, label));

            return customer;
        }
    }
}
