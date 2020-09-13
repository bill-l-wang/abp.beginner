using System;
using Volo.Abp.Application.Dtos;

namespace Marketing.Application.Contracts.Inputs
{
    public class AddCustomerInput : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
    }
}
