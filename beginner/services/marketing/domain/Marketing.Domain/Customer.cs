using JetBrains.Annotations;
using Marketing.Domain.Shared;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Marketing.Domain
{
    public class Customer : AuditedAggregateRoot<Guid>
    {
        public Customer(Guid id, [NotNull] string name, [NotNull] string mobile)
        {
            Id = id;
            Check.NotNullOrWhiteSpace(name, nameof(name));
            Check.NotNullOrWhiteSpace(name, nameof(mobile));
            Name = name;
            Mobile = mobile;
            Labels = new List<CustomerLabel>();
        }

        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public string Mobile { get; private set; }

        public string Note { get; private set; }

        public List<CustomerLabel> Labels { get; private set; }

        public void AddNote(string note)
        {
            Check.NotNullOrWhiteSpace(note, nameof(note));
            Note = note;
        }

        public void AddLabel(CustomerLabel label)
        {
            Labels.AddIfNotContains(label);
        }

        public void RemoveLabel(CustomerLabel label)
        {
            if (!Labels.Contains(label))
                throw new InvalidOperationException("this label is not exist");

            Labels.Remove(label);
        }
    }
}
