using Microsoft.AspNetCore.Mvc;

using SampleBackend.Domain;
using SampleBackend.Domain.Options;
using SampleBackend.Api;

namespace SampleBackend.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(
            ILogger<CustomerController> logger,
            ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetCustomersAsync();

            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] RegisterCustomerOptions options)
        {
            var registerResult = await _customerService.RegisterAsync(options);

            return registerResult.AsActionResult();
        }
    }
}