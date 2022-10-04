using Codehub.Create.Core;

using SampleBackend.Domain.Options;
using SampleBackend.Model;

namespace SampleBackend.Domain
{
    public interface ICustomerService
    {
        public Task<IEnumerable<Customer>> GetCustomersAsync();

        public Task<ApiResult<Customer>> RegisterAsync(RegisterCustomerOptions options);
    }
}
