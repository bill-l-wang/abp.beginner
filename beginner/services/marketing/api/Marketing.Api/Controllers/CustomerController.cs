using System;
using System.Threading.Tasks;
using Marketing.Application.Contracts.Inputs;
using Marketing.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Marketing.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : AbpController
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var id = Guid.NewGuid();

            var result = await _customerAppService.GetCustomerById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {
            await _customerAppService.AddCustomer(new AddCustomerInput()
            { 
                Name = "name",
                Mobile = "123456"
            });

            return Ok();
        }
    }
}
