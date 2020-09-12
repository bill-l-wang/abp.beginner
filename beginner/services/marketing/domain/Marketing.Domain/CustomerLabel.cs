using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Marketing.Domain
{
    public class CustomerLabel : ValueObject
    {
        public CustomerLabel(Guid customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public Guid CustomerId { get; private set; }
        public string Name { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
        }
    }
}
