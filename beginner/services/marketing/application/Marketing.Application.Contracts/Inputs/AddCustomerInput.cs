using System;
using Volo.Abp.Application.Dtos;

namespace Marketing.Application.Contracts.Dtos
{
    public class AddCustomerInput : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
    }
}
