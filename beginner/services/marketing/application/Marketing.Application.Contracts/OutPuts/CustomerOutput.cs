using System;
using System.Collections.Generic;

namespace Marketing.Application.Contracts.OutPuts
{
    public class CustomerOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public IEnumerable<string> Labels { get; set; }
    }
}
