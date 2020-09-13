using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Marketing.Application.Contracts.Inputs
{
    public class AddCustomerInput : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Mobile { get; set; }

        public IList<string> Labels { get; set; }
    }
}
