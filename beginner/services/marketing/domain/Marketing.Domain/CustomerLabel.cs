using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Marketing.Domain
{
    public class CustomerLabel : ValueObject
    {
        public CustomerLabel(Guid customerId, string name)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
            Name = name;
        }

        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public string Name { get; private set; }

        public Customer Customer { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
        }
    }
}
